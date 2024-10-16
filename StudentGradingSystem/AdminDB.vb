Imports System.Numerics
Imports MySql.Data.MySqlClient
Public Class dbconnection
    Dim dbcon As New MySqlConnection("server=localhost;username=root;password=;database=gradingsystem")

    Public Function openDB()
        Try
            dbcon.Open()
            MsgBox("Database is Open!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dbcon
    End Function

    Public Function closeDB()
        Try
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dbcon
    End Function

    'THIS CODE BELOW IS FOR RETRIEVING DATA OF STUDENTS FROM DATABASE'
    Public Sub ViewStudentData(std_num As String)
        Try
            Dim viewStudentData As String = "SELECT COUNT(*) FROM studentinformation WHERE std_num = @1"
            Using command As New MySqlCommand(viewStudentData, dbcon)
                command.Parameters.AddWithValue("@1", std_num)

                Dim count As String = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then

                    Dim displayStudentInfo As String = "SELECT std_num, std_ln, std_fn, std_mn, std_department, std_gender, std_cnum FROM studentinformation WHERE std_num = @1"
                    Dim secondCommand As New MySqlCommand(displayStudentInfo, dbcon)
                    secondCommand.Parameters.AddWithValue("@1", std_num)

                    Try
                        Dim reader As MySqlDataReader = secondCommand.ExecuteReader()
                        reader.Read()

                        Dim std_ln, std_fn, std_mn, std_gender, std_department, std_cnum As String

                        std_ln = reader("std_ln").ToString
                        std_fn = reader("std_fn").ToString
                        std_mn = reader("std_mn").ToString
                        std_num = reader("std_num").ToString
                        std_gender = reader("std_gender").ToString
                        std_department = reader("std_department").ToString
                        std_cnum = reader("std_cnum").ToString

                        Admin.stdLnTxt.Text = std_ln
                        Admin.stdFnTxt.Text = std_fn
                        Admin.stdMnTxt.Text = std_mn
                        Admin.stdNumTxt.Text = std_num
                        Admin.stdGenderTxt.Text = std_gender
                        Admin.stdDepartmentTxt.Text = std_department
                        Admin.stdCnumTxt.Text = std_cnum

                        reader.Close()
                        MsgBox("Success retrieving data from database!")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
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
        Dim command As New MySqlCommand(displayStudentSADGrade, dbcon)
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

            Admin.SADmtgTxt.Text = sad_mg
            Admin.SADftgTxt.Text = sad_fg
            Admin.SADeqgTxt.Text = sad_eqg
            Admin.SADremarksTxt.Text = sad_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cc104grades(std_num As String)
        Dim displayStudentcc104Grade As String = "SELECT cc104_mg, cc104_fg, cc104_eqg, cc104_remarks FROM cc104grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentcc104Grade, dbcon)
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

            Admin.CC104mtgTxt.Text = cc104_mg
            Admin.CC104ftgTxt.Text = cc104_fg
            Admin.CC104eqgTxt.Text = cc104_eqg
            Admin.CC104remarksTxt.Text = cc104_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub pf101Grades(std_num As String)
        Dim displayStudentpf101Grade As String = "SELECT pf101_mg, pf101_fg, pf101_eqg, pf101_remarks FROM pf101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentpf101Grade, dbcon)
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

            Admin.PF101mtgTxt.Text = pf101_mg
            Admin.PF101ftgTxt.Text = pf101_fg
            Admin.PF101eqgTxt.Text = pf101_eqg
            Admin.PF101remarksTxt.Text = pf101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub im101Grades(std_num As String)
        Dim displayStudentim101Grade As String = "SELECT im101_mg, im101_fg, im101_eqg, im101_remarks FROM im101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentim101Grade, dbcon)
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

            Admin.IM101mtgTxt.Text = im101_mg
            Admin.IM101ftgTxt.Text = im101_fg
            Admin.IM101eqgTxt.Text = im101_eqg
            Admin.IM101remarksTxt.Text = im101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub net101Grades(std_num As String)
        Dim displayStudentnet101Grade As String = "SELECT net101_mg, net101_fg, net101_eqg, net101_remarks FROM net101grades WHERE std_num = @1"
        Dim command As New MySqlCommand(displayStudentnet101Grade, dbcon)
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

            Admin.NET101mtgTxt.Text = net101_mg
            Admin.NET101ftgTxt.Text = net101_fg
            Admin.NET101eqgTxt.Text = net101_eqg
            Admin.NET101remarksTxt.Text = net101_remarks

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'THIS CODE BELOW WILL BE USE FOR INSERTING DATA'S OF STUDENT IN DATABASE'
    Public Sub InsertStudentInfo(std_ln As String, std_fn As String, std_mn As String, std_num As String, std_gender As String, std_department As String, std_cnum As String)
        Try
            Dim insertStudentInformation As String = "INSERT INTO studentinformation (std_ln, std_fn, std_mn, std_num, std_gender, std_department, std_cnum)
                                                  VALUES(@1, @2, @3, @4, @5, @6, @7)"
            Dim command As New MySqlCommand(insertStudentInformation, dbcon)
            command.Parameters.AddWithValue("@1", std_ln)
            command.Parameters.AddWithValue("@2", std_fn)
            command.Parameters.AddWithValue("@3", std_mn)
            command.Parameters.AddWithValue("@4", std_num)
            command.Parameters.AddWithValue("@5", std_gender)
            command.Parameters.AddWithValue("@6", std_department)
            command.Parameters.AddWithValue("@7", std_cnum)

            command.ExecuteNonQuery()

            MsgBox("Added to Database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertSADGrades(std_num As String, sad_mg As String, sad_fg As String, sad_eqg As String, sad_remarks As String)
        Try
            Dim insertSADgrades As String = "INSERT INTO sadgrades (sad_mg, sad_fg, sad_eqg, sad_remarks, std_num) VALUES(@1, @2, @3, @4, @5)"
            Dim command As New MySqlCommand(insertSADgrades, dbcon)
            command.Parameters.AddWithValue("@1", sad_mg)
            command.Parameters.AddWithValue("@2", sad_fg)
            command.Parameters.AddWithValue("@3", sad_eqg)
            command.Parameters.AddWithValue("@4", sad_remarks)
            command.Parameters.AddWithValue("@5", std_num)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InsertCC104Grades(std_num As String, cc104_mg As String, cc104_fg As String, cc104_eqg As String, cc104_remarks As String)
        Try
            Dim insertCC104grades As String = "INSERT INTO cc104grades (cc104_mg, cc104_fg, cc104_eqg, cc104_remarks, std_num) VALUES(@1, @2, @3, @4, @5)"
            Dim command As New MySqlCommand(insertCC104grades, dbcon)
            command.Parameters.AddWithValue("@1", cc104_mg)
            command.Parameters.AddWithValue("@2", cc104_fg)
            command.Parameters.AddWithValue("@3", cc104_eqg)
            command.Parameters.AddWithValue("@4", cc104_remarks)
            command.Parameters.AddWithValue("@5", std_num)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InsertPF101Grades(std_num As String, PF101_mg As String, PF101_fg As String, PF101_eqg As String, PF101_remarks As String)
        Try
            Dim insertPF101grades As String = "INSERT INTO pf101grades (pf101_mg, pf101_fg, pf101_eqg, pf101_remarks, std_num) VALUES(@1, @2, @3, @4, @5)"
            Dim command As New MySqlCommand(insertPF101grades, dbcon)
            command.Parameters.AddWithValue("@1", PF101_mg)
            command.Parameters.AddWithValue("@2", PF101_fg)
            command.Parameters.AddWithValue("@3", PF101_eqg)
            command.Parameters.AddWithValue("@4", PF101_remarks)
            command.Parameters.AddWithValue("@5", std_num)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InsertIM101Grades(std_num As String, IM101_mg As String, IM101_fg As String, IM101_eqg As String, IM101_remarks As String)
        Try
            Dim insertIM101grades As String = "INSERT INTO im101grades (IM101_mg, IM101_fg, IM101_eqg, IM101_remarks, std_num) VALUES(@1, @2, @3, @4, @5)"
            Dim command As New MySqlCommand(insertIM101grades, dbcon)
            command.Parameters.AddWithValue("@1", IM101_mg)
            command.Parameters.AddWithValue("@2", IM101_fg)
            command.Parameters.AddWithValue("@3", IM101_eqg)
            command.Parameters.AddWithValue("@4", IM101_remarks)
            command.Parameters.AddWithValue("@5", std_num)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub InsertNET101Grades(std_num As String, net101_mg As String, net101_fg As String, net101_eqg As String, net101_remarks As String)
        Try
            Dim insertNET101grades As String = "INSERT INTO net101grades (net101_mg, net101_fg, net101_eqg, net101_remarks, std_num) VALUES(@1, @2, @3, @4, @5)"
            Dim command As New MySqlCommand(insertNET101grades, dbcon)
            command.Parameters.AddWithValue("@1", net101_mg)
            command.Parameters.AddWithValue("@2", net101_fg)
            command.Parameters.AddWithValue("@3", net101_eqg)
            command.Parameters.AddWithValue("@4", net101_remarks)
            command.Parameters.AddWithValue("@5", std_num)

            command.ExecuteNonQuery()
            MsgBox("Registered Successfully!")
        Catch ex As Exception

        End Try
    End Sub
End Class