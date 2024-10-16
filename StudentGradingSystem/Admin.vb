Imports System.Numerics

Public Class Admin
    Dim dbcon As New dbconnection()
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon.openDB()
    End Sub

    Private Sub viewDataBtn_Click(sender As Object, e As EventArgs) Handles viewDataBtn.Click
        Dim std_num As String
        std_num = std_idTxtBox.Text
        dbcon.ViewStudentData(std_num)
        dbcon.sadGrades(std_num)
        dbcon.cc104grades(std_num)
        dbcon.pf101Grades(std_num)
        dbcon.im101Grades(std_num)
        dbcon.net101Grades(std_num)
    End Sub

    Private Sub eqgBtn_Click(sender As Object, e As EventArgs) Handles eqgBtn.Click
        Dim sadcomputedeqg, cc104computedeqg, pf101computedeqg, im101computedeqg, net101computedeqg As Double
        sadcomputedeqg = (Convert.ToDouble(SADmtgTxt.Text) + Convert.ToDouble(SADftgTxt.Text)) / 2
        cc104computedeqg = (Convert.ToDouble(CC104mtgTxt.Text) + Convert.ToDouble(CC104ftgTxt.Text)) / 2
        pf101computedeqg = (Convert.ToDouble(PF101mtgTxt.Text) + Convert.ToDouble(PF101ftgTxt.Text)) / 2
        im101computedeqg = (Convert.ToDouble(IM101mtgTxt.Text) + Convert.ToDouble(IM101ftgTxt.Text)) / 2
        net101computedeqg = (Convert.ToDouble(NET101mtgTxt.Text) + Convert.ToDouble(NET101ftgTxt.Text)) / 2

        SADeqgTxt.Text = sadcomputedeqg
        CC104eqgTxt.Text = cc104computedeqg
        PF101eqgTxt.Text = pf101computedeqg
        IM101eqgTxt.Text = im101computedeqg
        NET101eqgTxt.Text = net101computedeqg

        Dim passingGrade As Double
        passingGrade = 75

        If (Convert.ToDouble(SADeqgTxt.Text) >= passingGrade) Then
            SADremarksTxt.Text = "PASSED"
        Else
            SADremarksTxt.Text = "FAILED"
        End If

        If (Convert.ToDouble(CC104eqgTxt.Text) >= passingGrade) Then
            CC104remarksTxt.Text = "PASSED"
        Else
            CC104remarksTxt.Text = "FAILED"
        End If

        If (Convert.ToDouble(PF101eqgTxt.Text) >= passingGrade) Then
            PF101remarksTxt.Text = "PASSED"
        Else
            PF101remarksTxt.Text = "FAILED"
        End If

        If (Convert.ToDouble(IM101eqgTxt.Text) >= passingGrade) Then
            IM101remarksTxt.Text = "PASSED"
        Else
            IM101remarksTxt.Text = "FAILED"
        End If

        If (Convert.ToDouble(NET101eqgTxt.Text) >= passingGrade) Then
            NET101remarksTxt.Text = "PASSED"
        Else
            NET101remarksTxt.Text = "FAILED"
        End If
    End Sub

    Private Sub regDbBtn_Click(sender As Object, e As EventArgs) Handles regDbBtn.Click
        Dim std_ln, std_fn, std_mn, std_num, std_gender, std_department, std_cnum, sad_remarks, cc104_remarks, pf101_remarks,
        im101_remarks, net101_remarks As String

        Dim sad_mg, sad_fg, sad_eqg As String
        Dim cc104_mg, cc104_fg, cc104_eqg As String
        Dim pf101_mg, pf101_fg, pf101_eqg As String
        Dim im101_mg, im101_fg, im101_eqg As String
        Dim net101_mg, net101_fg, net101_eqg As String



        std_ln = stdLnTxt.Text
        std_fn = stdFnTxt.Text
        std_mn = stdMnTxt.Text
        std_num = stdNumTxt.Text
        std_gender = stdGenderTxt.Text
        std_department = stdDepartmentTxt.Text
        std_cnum = stdCnumTxt.Text
        sad_mg = SADmtgTxt.Text
        sad_fg = SADftgTxt.Text
        sad_eqg = SADeqgTxt.Text
        sad_remarks = SADremarksTxt.Text
        cc104_mg = CC104mtgTxt.Text
        cc104_fg = CC104ftgTxt.Text
        cc104_eqg = CC104eqgTxt.Text
        cc104_remarks = CC104remarksTxt.Text
        pf101_mg = PF101mtgTxt.Text
        pf101_fg = PF101ftgTxt.Text
        pf101_eqg = PF101eqgTxt.Text
        pf101_remarks = PF101remarksTxt.Text
        im101_mg = IM101mtgTxt.Text
        im101_fg = IM101ftgTxt.Text
        im101_eqg = IM101eqgTxt.Text
        im101_remarks = IM101remarksTxt.Text
        net101_mg = NET101mtgTxt.Text
        net101_fg = NET101ftgTxt.Text
        net101_eqg = NET101eqgTxt.Text
        net101_remarks = NET101remarksTxt.Text

        dbcon.InsertStudentInfo(std_ln, std_fn, std_mn, std_num, std_gender, std_department, std_cnum)
        dbcon.InsertSADGrades(std_num, sad_mg, sad_fg, sad_eqg, sad_remarks)
        dbcon.InsertCC104Grades(std_num, cc104_mg, cc104_fg, cc104_eqg, cc104_remarks)
        dbcon.InsertPF101Grades(std_num, pf101_mg, pf101_fg, pf101_eqg, pf101_remarks)
        dbcon.InsertIM101Grades(std_num, im101_mg, im101_fg, im101_eqg, im101_remarks)
        dbcon.InsertNET101Grades(std_num, net101_mg, net101_fg, net101_eqg, net101_remarks)
    End Sub
End Class