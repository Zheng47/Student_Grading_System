<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        studentIDLabel = New Label()
        studentIDTxtBox = New TextBox()
        loginButton = New Button()
        SuspendLayout()
        ' 
        ' studentIDLabel
        ' 
        studentIDLabel.BackColor = SystemColors.ControlText
        studentIDLabel.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentIDLabel.ForeColor = Color.Yellow
        studentIDLabel.Location = New Point(42, 151)
        studentIDLabel.Name = "studentIDLabel"
        studentIDLabel.Size = New Size(376, 52)
        studentIDLabel.TabIndex = 0
        studentIDLabel.Text = "STUDENT NUMBER"
        studentIDLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' studentIDTxtBox
        ' 
        studentIDTxtBox.BorderStyle = BorderStyle.FixedSingle
        studentIDTxtBox.Cursor = Cursors.IBeam
        studentIDTxtBox.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentIDTxtBox.Location = New Point(30, 248)
        studentIDTxtBox.Multiline = True
        studentIDTxtBox.Name = "studentIDTxtBox"
        studentIDTxtBox.Size = New Size(404, 56)
        studentIDTxtBox.TabIndex = 1
        studentIDTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' loginButton
        ' 
        loginButton.Cursor = Cursors.Hand
        loginButton.Location = New Point(301, 446)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(133, 49)
        loginButton.TabIndex = 2
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' StudentLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(478, 644)
        Controls.Add(loginButton)
        Controls.Add(studentIDTxtBox)
        Controls.Add(studentIDLabel)
        Name = "StudentLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studentIDLabel As Label
    Friend WithEvents studentIDTxtBox As TextBox
    Friend WithEvents loginButton As Button

End Class
