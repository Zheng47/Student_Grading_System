Public Class StudentGrades
    Dim dbconn As New databaseConnection()
    Private Sub StudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        dbconn.closeDB()
        StudentLogin.Show()
        Me.Hide()
    End Sub

End Class