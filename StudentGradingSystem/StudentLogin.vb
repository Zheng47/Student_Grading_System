Public Class StudentLogin
    Dim dbconn As New databaseConnection()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        dbconn.openDB()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim std_num As String
        std_num = studentIDTxtBox.Text
        dbconn.VerifyStudentNumber(std_num)
        dbconn.sadGrades(std_num)
        dbconn.cc104grades(std_num)
        dbconn.pf101Grades(std_num)
        dbconn.im101Grades(std_num)
        dbconn.net101Grades(std_num)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginButton.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class
