<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        std_idTxtBox = New TextBox()
        viewDataBtn = New Button()
        Label1 = New Label()
        cnLbl = New Label()
        gLbl = New Label()
        numLbl = New Label()
        nameLbl = New Label()
        Label7 = New Label()
        net101Lbl = New Label()
        im101Lbl = New Label()
        pf101Lbl = New Label()
        cc104lbl = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SADlbl = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        NET101remarksTxt = New TextBox()
        NET101eqgTxt = New TextBox()
        NET101ftgTxt = New TextBox()
        NET101mtgTxt = New TextBox()
        IM101remarksTxt = New TextBox()
        IM101eqgTxt = New TextBox()
        IM101ftgTxt = New TextBox()
        PF101remarksTxt = New TextBox()
        PF101eqgTxt = New TextBox()
        PF101ftgTxt = New TextBox()
        CC104remarksTxt = New TextBox()
        CC104eqgTxt = New TextBox()
        CC104ftgTxt = New TextBox()
        SADremarksTxt = New TextBox()
        SADeqgTxt = New TextBox()
        SADftgTxt = New TextBox()
        SADmtgTxt = New TextBox()
        CC104mtgTxt = New TextBox()
        PF101mtgTxt = New TextBox()
        IM101mtgTxt = New TextBox()
        regDbBtn = New Button()
        eqgBtn = New Button()
        stdLnTxt = New TextBox()
        stdFnTxt = New TextBox()
        stdMnTxt = New TextBox()
        stdNumTxt = New TextBox()
        stdGenderTxt = New TextBox()
        stdCnumTxt = New TextBox()
        stdDepartmentTxt = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' std_idTxtBox
        ' 
        std_idTxtBox.Font = New Font("Segoe UI", 18F)
        std_idTxtBox.Location = New Point(220, 12)
        std_idTxtBox.Multiline = True
        std_idTxtBox.Name = "std_idTxtBox"
        std_idTxtBox.PlaceholderText = "XX-XXXX"
        std_idTxtBox.Size = New Size(167, 53)
        std_idTxtBox.TabIndex = 0
        std_idTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' viewDataBtn
        ' 
        viewDataBtn.Location = New Point(408, 16)
        viewDataBtn.Name = "viewDataBtn"
        viewDataBtn.Size = New Size(126, 43)
        viewDataBtn.TabIndex = 1
        viewDataBtn.Text = "VIEW DATA"
        viewDataBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 271)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 32)
        Label1.TabIndex = 22
        Label1.Text = "Department:"
        ' 
        ' cnLbl
        ' 
        cnLbl.AutoSize = True
        cnLbl.Font = New Font("Segoe UI", 12F)
        cnLbl.Location = New Point(12, 225)
        cnLbl.Name = "cnLbl"
        cnLbl.Size = New Size(196, 32)
        cnLbl.TabIndex = 21
        cnLbl.Text = "Contact Number:"
        ' 
        ' gLbl
        ' 
        gLbl.AutoSize = True
        gLbl.Font = New Font("Segoe UI", 12F)
        gLbl.Location = New Point(12, 180)
        gLbl.Name = "gLbl"
        gLbl.Size = New Size(97, 32)
        gLbl.TabIndex = 20
        gLbl.Text = "Gender:"
        ' 
        ' numLbl
        ' 
        numLbl.AutoSize = True
        numLbl.Font = New Font("Segoe UI", 12F)
        numLbl.Location = New Point(12, 134)
        numLbl.Name = "numLbl"
        numLbl.Size = New Size(197, 32)
        numLbl.TabIndex = 19
        numLbl.Text = "Student Number:"
        ' 
        ' nameLbl
        ' 
        nameLbl.AutoSize = True
        nameLbl.Font = New Font("Segoe UI", 12F)
        nameLbl.Location = New Point(12, 84)
        nameLbl.Name = "nameLbl"
        nameLbl.Size = New Size(83, 32)
        nameLbl.TabIndex = 18
        nameLbl.Text = "Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(12, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(197, 32)
        Label7.TabIndex = 23
        Label7.Text = "Student Number:"
        ' 
        ' net101Lbl
        ' 
        net101Lbl.Anchor = AnchorStyles.Left
        net101Lbl.AutoSize = True
        net101Lbl.Location = New Point(20, 448)
        net101Lbl.Margin = New Padding(20, 0, 3, 0)
        net101Lbl.Name = "net101Lbl"
        net101Lbl.Size = New Size(218, 25)
        net101Lbl.TabIndex = 21
        net101Lbl.Text = "NET101 - NETWORKING 1"
        ' 
        ' im101Lbl
        ' 
        im101Lbl.Anchor = AnchorStyles.Left
        im101Lbl.AutoSize = True
        im101Lbl.Location = New Point(20, 365)
        im101Lbl.Margin = New Padding(20, 0, 3, 0)
        im101Lbl.Name = "im101Lbl"
        im101Lbl.Size = New Size(308, 25)
        im101Lbl.TabIndex = 20
        im101Lbl.Text = "IM101 - Advanced Database Systems"
        ' 
        ' pf101Lbl
        ' 
        pf101Lbl.Anchor = AnchorStyles.Left
        pf101Lbl.AutoSize = True
        pf101Lbl.Location = New Point(20, 281)
        pf101Lbl.Margin = New Padding(20, 0, 3, 0)
        pf101Lbl.Name = "pf101Lbl"
        pf101Lbl.Size = New Size(319, 25)
        pf101Lbl.TabIndex = 19
        pf101Lbl.Text = "PF101 - Object Oriented Programming"
        ' 
        ' cc104lbl
        ' 
        cc104lbl.Anchor = AnchorStyles.Left
        cc104lbl.AutoSize = True
        cc104lbl.Location = New Point(20, 200)
        cc104lbl.Margin = New Padding(20, 0, 3, 0)
        cc104lbl.Name = "cc104lbl"
        cc104lbl.Size = New Size(334, 25)
        cc104lbl.TabIndex = 18
        cc104lbl.Text = "CC104 - Data Structures and Algorithms "
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(198, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 12
        Label2.Text = "SUBJECTS"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(551, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 25)
        Label3.TabIndex = 13
        Label3.Text = "MIDTERM"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(803, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 14
        Label4.Text = "FINALS"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(1000, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(175, 25)
        Label5.TabIndex = 15
        Label5.Text = "EQUIVALENT GRADE"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(1269, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 25)
        Label6.TabIndex = 16
        Label6.Text = "REMARKS"
        ' 
        ' SADlbl
        ' 
        SADlbl.Anchor = AnchorStyles.Left
        SADlbl.AutoSize = True
        SADlbl.Location = New Point(20, 122)
        SADlbl.Margin = New Padding(20, 0, 3, 0)
        SADlbl.Name = "SADlbl"
        SADlbl.Size = New Size(285, 25)
        SADlbl.TabIndex = 17
        SADlbl.Text = "SAD - System Analysis and Design"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.ActiveBorder
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 486F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.4545441F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54.5454559F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 235F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 218F))
        TableLayoutPanel1.Controls.Add(NET101remarksTxt, 4, 5)
        TableLayoutPanel1.Controls.Add(NET101eqgTxt, 3, 5)
        TableLayoutPanel1.Controls.Add(NET101ftgTxt, 2, 5)
        TableLayoutPanel1.Controls.Add(NET101mtgTxt, 1, 5)
        TableLayoutPanel1.Controls.Add(IM101remarksTxt, 4, 4)
        TableLayoutPanel1.Controls.Add(IM101eqgTxt, 3, 4)
        TableLayoutPanel1.Controls.Add(IM101ftgTxt, 2, 4)
        TableLayoutPanel1.Controls.Add(PF101remarksTxt, 4, 3)
        TableLayoutPanel1.Controls.Add(PF101eqgTxt, 3, 3)
        TableLayoutPanel1.Controls.Add(PF101ftgTxt, 2, 3)
        TableLayoutPanel1.Controls.Add(CC104remarksTxt, 4, 2)
        TableLayoutPanel1.Controls.Add(CC104eqgTxt, 3, 2)
        TableLayoutPanel1.Controls.Add(CC104ftgTxt, 2, 2)
        TableLayoutPanel1.Controls.Add(SADremarksTxt, 4, 1)
        TableLayoutPanel1.Controls.Add(SADeqgTxt, 3, 1)
        TableLayoutPanel1.Controls.Add(SADftgTxt, 2, 1)
        TableLayoutPanel1.Controls.Add(SADlbl, 0, 1)
        TableLayoutPanel1.Controls.Add(Label6, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 3, 0)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(Label3, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(cc104lbl, 0, 2)
        TableLayoutPanel1.Controls.Add(pf101Lbl, 0, 3)
        TableLayoutPanel1.Controls.Add(im101Lbl, 0, 4)
        TableLayoutPanel1.Controls.Add(net101Lbl, 0, 5)
        TableLayoutPanel1.Controls.Add(SADmtgTxt, 1, 1)
        TableLayoutPanel1.Controls.Add(CC104mtgTxt, 1, 2)
        TableLayoutPanel1.Controls.Add(PF101mtgTxt, 1, 3)
        TableLayoutPanel1.Controls.Add(IM101mtgTxt, 1, 4)
        TableLayoutPanel1.Location = New Point(22, 315)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 56.01852F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 43.98148F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 79F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 83F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 85F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 81F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1424, 502)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' NET101remarksTxt
        ' 
        NET101remarksTxt.Anchor = AnchorStyles.None
        NET101remarksTxt.Font = New Font("Segoe UI", 18F)
        NET101remarksTxt.Location = New Point(1231, 434)
        NET101remarksTxt.Multiline = True
        NET101remarksTxt.Name = "NET101remarksTxt"
        NET101remarksTxt.Size = New Size(167, 53)
        NET101remarksTxt.TabIndex = 43
        NET101remarksTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' NET101eqgTxt
        ' 
        NET101eqgTxt.Anchor = AnchorStyles.None
        NET101eqgTxt.Font = New Font("Segoe UI", 18F)
        NET101eqgTxt.Location = New Point(1004, 434)
        NET101eqgTxt.Multiline = True
        NET101eqgTxt.Name = "NET101eqgTxt"
        NET101eqgTxt.Size = New Size(167, 53)
        NET101eqgTxt.TabIndex = 42
        NET101eqgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' NET101ftgTxt
        ' 
        NET101ftgTxt.Anchor = AnchorStyles.None
        NET101ftgTxt.Font = New Font("Segoe UI", 18F)
        NET101ftgTxt.Location = New Point(754, 434)
        NET101ftgTxt.Multiline = True
        NET101ftgTxt.Name = "NET101ftgTxt"
        NET101ftgTxt.Size = New Size(167, 53)
        NET101ftgTxt.TabIndex = 41
        NET101ftgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' NET101mtgTxt
        ' 
        NET101mtgTxt.Anchor = AnchorStyles.None
        NET101mtgTxt.Font = New Font("Segoe UI", 18F)
        NET101mtgTxt.Location = New Point(512, 434)
        NET101mtgTxt.Multiline = True
        NET101mtgTxt.Name = "NET101mtgTxt"
        NET101mtgTxt.Size = New Size(167, 53)
        NET101mtgTxt.TabIndex = 40
        NET101mtgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' IM101remarksTxt
        ' 
        IM101remarksTxt.Anchor = AnchorStyles.None
        IM101remarksTxt.Font = New Font("Segoe UI", 18F)
        IM101remarksTxt.Location = New Point(1231, 351)
        IM101remarksTxt.Multiline = True
        IM101remarksTxt.Name = "IM101remarksTxt"
        IM101remarksTxt.Size = New Size(167, 53)
        IM101remarksTxt.TabIndex = 39
        IM101remarksTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' IM101eqgTxt
        ' 
        IM101eqgTxt.Anchor = AnchorStyles.None
        IM101eqgTxt.Font = New Font("Segoe UI", 18F)
        IM101eqgTxt.Location = New Point(1004, 351)
        IM101eqgTxt.Multiline = True
        IM101eqgTxt.Name = "IM101eqgTxt"
        IM101eqgTxt.Size = New Size(167, 53)
        IM101eqgTxt.TabIndex = 38
        IM101eqgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' IM101ftgTxt
        ' 
        IM101ftgTxt.Anchor = AnchorStyles.None
        IM101ftgTxt.Font = New Font("Segoe UI", 18F)
        IM101ftgTxt.Location = New Point(754, 351)
        IM101ftgTxt.Multiline = True
        IM101ftgTxt.Name = "IM101ftgTxt"
        IM101ftgTxt.Size = New Size(167, 53)
        IM101ftgTxt.TabIndex = 37
        IM101ftgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PF101remarksTxt
        ' 
        PF101remarksTxt.Anchor = AnchorStyles.None
        PF101remarksTxt.Font = New Font("Segoe UI", 18F)
        PF101remarksTxt.Location = New Point(1231, 267)
        PF101remarksTxt.Multiline = True
        PF101remarksTxt.Name = "PF101remarksTxt"
        PF101remarksTxt.Size = New Size(167, 53)
        PF101remarksTxt.TabIndex = 36
        PF101remarksTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PF101eqgTxt
        ' 
        PF101eqgTxt.Anchor = AnchorStyles.None
        PF101eqgTxt.Font = New Font("Segoe UI", 18F)
        PF101eqgTxt.Location = New Point(1004, 267)
        PF101eqgTxt.Multiline = True
        PF101eqgTxt.Name = "PF101eqgTxt"
        PF101eqgTxt.Size = New Size(167, 53)
        PF101eqgTxt.TabIndex = 35
        PF101eqgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PF101ftgTxt
        ' 
        PF101ftgTxt.Anchor = AnchorStyles.None
        PF101ftgTxt.Font = New Font("Segoe UI", 18F)
        PF101ftgTxt.Location = New Point(754, 267)
        PF101ftgTxt.Multiline = True
        PF101ftgTxt.Name = "PF101ftgTxt"
        PF101ftgTxt.Size = New Size(167, 53)
        PF101ftgTxt.TabIndex = 34
        PF101ftgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' CC104remarksTxt
        ' 
        CC104remarksTxt.Anchor = AnchorStyles.None
        CC104remarksTxt.Font = New Font("Segoe UI", 18F)
        CC104remarksTxt.Location = New Point(1231, 186)
        CC104remarksTxt.Multiline = True
        CC104remarksTxt.Name = "CC104remarksTxt"
        CC104remarksTxt.Size = New Size(167, 53)
        CC104remarksTxt.TabIndex = 33
        CC104remarksTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' CC104eqgTxt
        ' 
        CC104eqgTxt.Anchor = AnchorStyles.None
        CC104eqgTxt.Font = New Font("Segoe UI", 18F)
        CC104eqgTxt.Location = New Point(1004, 186)
        CC104eqgTxt.Multiline = True
        CC104eqgTxt.Name = "CC104eqgTxt"
        CC104eqgTxt.Size = New Size(167, 53)
        CC104eqgTxt.TabIndex = 32
        CC104eqgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' CC104ftgTxt
        ' 
        CC104ftgTxt.Anchor = AnchorStyles.None
        CC104ftgTxt.Font = New Font("Segoe UI", 18F)
        CC104ftgTxt.Location = New Point(754, 186)
        CC104ftgTxt.Multiline = True
        CC104ftgTxt.Name = "CC104ftgTxt"
        CC104ftgTxt.Size = New Size(167, 53)
        CC104ftgTxt.TabIndex = 31
        CC104ftgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' SADremarksTxt
        ' 
        SADremarksTxt.Anchor = AnchorStyles.None
        SADremarksTxt.Font = New Font("Segoe UI", 18F)
        SADremarksTxt.Location = New Point(1231, 108)
        SADremarksTxt.Multiline = True
        SADremarksTxt.Name = "SADremarksTxt"
        SADremarksTxt.Size = New Size(167, 53)
        SADremarksTxt.TabIndex = 30
        SADremarksTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' SADeqgTxt
        ' 
        SADeqgTxt.Anchor = AnchorStyles.None
        SADeqgTxt.Font = New Font("Segoe UI", 18F)
        SADeqgTxt.Location = New Point(1004, 108)
        SADeqgTxt.Multiline = True
        SADeqgTxt.Name = "SADeqgTxt"
        SADeqgTxt.Size = New Size(167, 53)
        SADeqgTxt.TabIndex = 29
        SADeqgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' SADftgTxt
        ' 
        SADftgTxt.Anchor = AnchorStyles.None
        SADftgTxt.Font = New Font("Segoe UI", 18F)
        SADftgTxt.Location = New Point(754, 108)
        SADftgTxt.Multiline = True
        SADftgTxt.Name = "SADftgTxt"
        SADftgTxt.Size = New Size(167, 53)
        SADftgTxt.TabIndex = 28
        SADftgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' SADmtgTxt
        ' 
        SADmtgTxt.Anchor = AnchorStyles.None
        SADmtgTxt.Font = New Font("Segoe UI", 18F)
        SADmtgTxt.Location = New Point(512, 108)
        SADmtgTxt.Multiline = True
        SADmtgTxt.Name = "SADmtgTxt"
        SADmtgTxt.Size = New Size(167, 53)
        SADmtgTxt.TabIndex = 24
        SADmtgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' CC104mtgTxt
        ' 
        CC104mtgTxt.Anchor = AnchorStyles.None
        CC104mtgTxt.Font = New Font("Segoe UI", 18F)
        CC104mtgTxt.Location = New Point(512, 186)
        CC104mtgTxt.Multiline = True
        CC104mtgTxt.Name = "CC104mtgTxt"
        CC104mtgTxt.Size = New Size(167, 53)
        CC104mtgTxt.TabIndex = 25
        CC104mtgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PF101mtgTxt
        ' 
        PF101mtgTxt.Anchor = AnchorStyles.None
        PF101mtgTxt.Font = New Font("Segoe UI", 18F)
        PF101mtgTxt.Location = New Point(512, 267)
        PF101mtgTxt.Multiline = True
        PF101mtgTxt.Name = "PF101mtgTxt"
        PF101mtgTxt.Size = New Size(167, 53)
        PF101mtgTxt.TabIndex = 26
        PF101mtgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' IM101mtgTxt
        ' 
        IM101mtgTxt.Anchor = AnchorStyles.None
        IM101mtgTxt.Font = New Font("Segoe UI", 18F)
        IM101mtgTxt.Location = New Point(512, 351)
        IM101mtgTxt.Multiline = True
        IM101mtgTxt.Name = "IM101mtgTxt"
        IM101mtgTxt.Size = New Size(167, 53)
        IM101mtgTxt.TabIndex = 27
        IM101mtgTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' regDbBtn
        ' 
        regDbBtn.Location = New Point(1258, 858)
        regDbBtn.Name = "regDbBtn"
        regDbBtn.Size = New Size(190, 43)
        regDbBtn.TabIndex = 24
        regDbBtn.Text = "REGISTER"
        regDbBtn.UseVisualStyleBackColor = True
        ' 
        ' eqgBtn
        ' 
        eqgBtn.Location = New Point(1019, 858)
        eqgBtn.Name = "eqgBtn"
        eqgBtn.Size = New Size(218, 43)
        eqgBtn.TabIndex = 26
        eqgBtn.Text = "EQUIVALENT GRADES"
        eqgBtn.UseVisualStyleBackColor = True
        ' 
        ' stdLnTxt
        ' 
        stdLnTxt.Font = New Font("Segoe UI", 12F)
        stdLnTxt.Location = New Point(209, 84)
        stdLnTxt.Multiline = True
        stdLnTxt.Name = "stdLnTxt"
        stdLnTxt.PlaceholderText = "LN"
        stdLnTxt.Size = New Size(167, 41)
        stdLnTxt.TabIndex = 28
        stdLnTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdFnTxt
        ' 
        stdFnTxt.Font = New Font("Segoe UI", 12F)
        stdFnTxt.Location = New Point(389, 84)
        stdFnTxt.Multiline = True
        stdFnTxt.Name = "stdFnTxt"
        stdFnTxt.PlaceholderText = "FN"
        stdFnTxt.Size = New Size(548, 41)
        stdFnTxt.TabIndex = 29
        stdFnTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdMnTxt
        ' 
        stdMnTxt.Font = New Font("Segoe UI", 12F)
        stdMnTxt.Location = New Point(950, 84)
        stdMnTxt.Multiline = True
        stdMnTxt.Name = "stdMnTxt"
        stdMnTxt.PlaceholderText = "MN"
        stdMnTxt.Size = New Size(287, 41)
        stdMnTxt.TabIndex = 30
        stdMnTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdNumTxt
        ' 
        stdNumTxt.Font = New Font("Segoe UI", 12F)
        stdNumTxt.Location = New Point(209, 130)
        stdNumTxt.Multiline = True
        stdNumTxt.Name = "stdNumTxt"
        stdNumTxt.PlaceholderText = "XX-XXXX"
        stdNumTxt.Size = New Size(284, 41)
        stdNumTxt.TabIndex = 31
        stdNumTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdGenderTxt
        ' 
        stdGenderTxt.Font = New Font("Segoe UI", 12F)
        stdGenderTxt.Location = New Point(209, 177)
        stdGenderTxt.Multiline = True
        stdGenderTxt.Name = "stdGenderTxt"
        stdGenderTxt.Size = New Size(200, 41)
        stdGenderTxt.TabIndex = 32
        stdGenderTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdCnumTxt
        ' 
        stdCnumTxt.Font = New Font("Segoe UI", 12F)
        stdCnumTxt.Location = New Point(209, 223)
        stdCnumTxt.Multiline = True
        stdCnumTxt.Name = "stdCnumTxt"
        stdCnumTxt.PlaceholderText = "09XXXXXXXXX"
        stdCnumTxt.Size = New Size(343, 41)
        stdCnumTxt.TabIndex = 33
        stdCnumTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' stdDepartmentTxt
        ' 
        stdDepartmentTxt.Font = New Font("Segoe UI", 12F)
        stdDepartmentTxt.Location = New Point(209, 269)
        stdDepartmentTxt.Multiline = True
        stdDepartmentTxt.Name = "stdDepartmentTxt"
        stdDepartmentTxt.PlaceholderText = "INFORMATION TECHNOLOGY"
        stdDepartmentTxt.Size = New Size(808, 41)
        stdDepartmentTxt.TabIndex = 34
        stdDepartmentTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(1478, 944)
        Controls.Add(stdDepartmentTxt)
        Controls.Add(stdCnumTxt)
        Controls.Add(stdGenderTxt)
        Controls.Add(stdNumTxt)
        Controls.Add(stdMnTxt)
        Controls.Add(stdFnTxt)
        Controls.Add(stdLnTxt)
        Controls.Add(eqgBtn)
        Controls.Add(regDbBtn)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(cnLbl)
        Controls.Add(gLbl)
        Controls.Add(numLbl)
        Controls.Add(nameLbl)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(viewDataBtn)
        Controls.Add(std_idTxtBox)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents std_idTxtBox As TextBox
    Friend WithEvents viewDataBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cnLbl As Label
    Friend WithEvents gLbl As Label
    Friend WithEvents numLbl As Label
    Friend WithEvents nameLbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents net101Lbl As Label
    Friend WithEvents im101Lbl As Label
    Friend WithEvents pf101Lbl As Label
    Friend WithEvents cc104lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SADlbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NET101remarksTxt As TextBox
    Friend WithEvents NET101eqgTxt As TextBox
    Friend WithEvents NET101ftgTxt As TextBox
    Friend WithEvents NET101mtgTxt As TextBox
    Friend WithEvents IM101remarksTxt As TextBox
    Friend WithEvents IM101eqgTxt As TextBox
    Friend WithEvents IM101ftgTxt As TextBox
    Friend WithEvents PF101remarksTxt As TextBox
    Friend WithEvents PF101eqgTxt As TextBox
    Friend WithEvents PF101ftgTxt As TextBox
    Friend WithEvents CC104remarksTxt As TextBox
    Friend WithEvents CC104eqgTxt As TextBox
    Friend WithEvents CC104ftgTxt As TextBox
    Friend WithEvents SADremarksTxt As TextBox
    Friend WithEvents SADeqgTxt As TextBox
    Friend WithEvents SADftgTxt As TextBox
    Friend WithEvents CC104mtgTxt As TextBox
    Friend WithEvents PF101mtgTxt As TextBox
    Friend WithEvents IM101mtgTxt As TextBox
    Friend WithEvents regDbBtn As Button
    Friend WithEvents eqgBtn As Button
    Friend WithEvents SADmtgTxt As TextBox
    Friend WithEvents stdLnTxt As TextBox
    Friend WithEvents stdFnTxt As TextBox
    Friend WithEvents stdMnTxt As TextBox
    Friend WithEvents stdNumTxt As TextBox
    Friend WithEvents stdGenderTxt As TextBox
    Friend WithEvents stdCnumTxt As TextBox
    Friend WithEvents stdDepartmentTxt As TextBox
End Class
