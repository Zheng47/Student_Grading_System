Imports MySql.Data.MySqlClient
Public Class databaseConnection
    Public dbconn As New MySqlConnection("server=localhost;username=root;password=;database=gradingsystem")
    Public Function openDB()
        Try
            dbconn.Open()
            MsgBox("Note: Database is running successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dbconn
    End Function

    Public Function closeDB()
        Try
            dbconn.Close()
            MsgBox("Successfully Sign Out!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dbconn
    End Function

    Public Sub VerifyStudentNumber(std_num As String)
        Try
            Dim verifyQuery As String = "SELECT COUNT(*) FROM studentinformation WHERE std_num = @1"
            Using command As New MySqlCommand(verifyQuery, dbconn)
                command.Parameters.AddWithValue("@1", std_num)

                Dim count As String = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then

                    Dim displayStudentInfo As String = "SELECT std_num, std_ln, std_fn, std_mn, std_department, std_gender, std_cnum FROM studentinformation WHERE std_num = @1"
                    Dim secondCommand As New MySqlCommand(displayStudentInfo, dbconn)
                    secondCommand.Parameters.AddWithValue("@1", std_num)

                    Try
                        Dim reader As MySqlDataReader = secondCommand.ExecuteReader()
                        reader.Read()

                        Dim std_fullname, std_ln, std_fn, std_mn, std_gender, std_department, std_cnum As String

                        std_ln = reader("std_ln").ToString
                        std_fn = reader("std_fn").ToString
                        std_mn = reader("std_mn").ToString
                        std_num = reader("std_num").ToString
                        std_gender = reader("std_gender").ToString
                        std_department = reader("std_department").ToString
                        std_cnum = reader("std_cnum").ToString

                        std_fullname = std_ln + ", " + std_fn + " " + std_mn

                        StudentGrades.stdNameLbl.Text = std_fullname
                        StudentGrades.stdIDLbl.Text = std_num
                        StudentGrades.stdDepLbl.Text = std_department
                        StudentGrades.stdGenderLbl.Text = std_gender
                        StudentGrades.stdCNLbl.Text = std_cnum

                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    MsgBox("Login Successfully!")
                    StudentGrades.Show()
                    StudentLogin.Hide()

                Else
                    MsgBox("Invalid student number. Please try again!")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub sadGrades(std_num As String)
        Dim displayStudentSADGrade As String = "SELECT sad_mg, sad_fg, sad_eqg, sad_remarks FROM sadgrades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentSADGrade, dbconn)
        command.Parameters.AddWithValue("@1", std_num)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim sad_mg, sad_fg, sad_eqg As Double
            Dim sad_remarks As String

            sad_mg = reader("sad_mg").ToString
            sad_fg = reader("sad_fg").ToString
            sad_eqg = reader("sad_eqg").ToString
            sad_remarks = reader("sad_remarks").ToString

            StudentGrades.SADmtg.Text = sad_mg
            StudentGrades.SADftg.Text = sad_fg
            StudentGrades.SADeqg.Text = sad_eqg
            StudentGrades.SADremarks.Text = sad_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cc104grades(std_num As String)
        Dim displayStudentcc104Grade As String = "SELECT cc104_mg, cc104_fg, cc104_eqg, cc104_remarks FROM cc104grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentcc104Grade, dbconn)
        command.Parameters.AddWithValue("@1", std_num)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim cc104_mg, cc104_fg, cc104_eqg As Double
            Dim cc104_remarks As String

            cc104_mg = reader("cc104_mg").ToString
            cc104_fg = reader("cc104_fg").ToString
            cc104_eqg = reader("cc104_eqg").ToString
            cc104_remarks = reader("cc104_remarks").ToString

            StudentGrades.CC104mtg.Text = cc104_mg
            StudentGrades.CC104ftg.Text = cc104_fg
            StudentGrades.CC104eqg.Text = cc104_eqg
            StudentGrades.CC104remarks.Text = cc104_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub pf101Grades(std_num As String)
        Dim displayStudentpf101Grade As String = "SELECT pf101_mg, pf101_fg, pf101_eqg, pf101_remarks FROM pf101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentpf101Grade, dbconn)
        command.Parameters.AddWithValue("@1", std_num)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim pf101_mg, pf101_fg, pf101_eqg As Double
            Dim pf101_remarks As String

            pf101_mg = reader("pf101_mg").ToString
            pf101_fg = reader("pf101_fg").ToString
            pf101_eqg = reader("pf101_eqg").ToString
            pf101_remarks = reader("pf101_remarks").ToString

            StudentGrades.PF101mtg.Text = pf101_mg
            StudentGrades.PF101ftg.Text = pf101_fg
            StudentGrades.PF101eqg.Text = pf101_eqg
            StudentGrades.PF101remarks.Text = pf101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub im101Grades(std_num As String)
        Dim displayStudentim101Grade As String = "SELECT im101_mg, im101_fg, im101_eqg, im101_remarks FROM im101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentim101Grade, dbconn)
        command.Parameters.AddWithValue("@1", std_num)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim im101_mg, im101_fg, im101_eqg As Double
            Dim im101_remarks As String

            im101_mg = reader("im101_mg").ToString
            im101_fg = reader("im101_fg").ToString
            im101_eqg = reader("im101_eqg").ToString
            im101_remarks = reader("im101_remarks").ToString

            StudentGrades.IM101mtg.Text = im101_mg
            StudentGrades.IM101ftg.Text = im101_fg
            StudentGrades.IM101eqg.Text = im101_eqg
            StudentGrades.IM101remarks.Text = im101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub net101Grades(std_num As String)
        Dim displayStudentnet101Grade As String = "SELECT net101_mg, net101_fg, net101_eqg, net101_remarks FROM net101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentnet101Grade, dbconn)
        command.Parameters.AddWithValue("@1", std_num)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim net101_mg, net101_fg, net101_eqg As Double
            Dim net101_remarks As String

            net101_mg = reader("net101_mg").ToString
            net101_fg = reader("net101_fg").ToString
            net101_eqg = reader("net101_eqg").ToString
            net101_remarks = reader("net101_remarks").ToString

            StudentGrades.NET101mtg.Text = net101_mg
            StudentGrades.NET101ftg.Text = net101_fg
            StudentGrades.NET101eqg.Text = net101_eqg
            StudentGrades.NET101remarks.Text = net101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class