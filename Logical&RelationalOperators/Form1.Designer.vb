<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnGrade = New Button()
        lblScore = New Label()
        txtScore = New TextBox()
        SuspendLayout()
        ' 
        ' btnGrade
        ' 
        btnGrade.Location = New Point(326, 186)
        btnGrade.Name = "btnGrade"
        btnGrade.Size = New Size(124, 74)
        btnGrade.TabIndex = 0
        btnGrade.Text = "Get Grade"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Location = New Point(125, 106)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(199, 20)
        lblScore.TabIndex = 1
        lblScore.Text = "Enter the examination Score!"
        ' 
        ' txtScore
        ' 
        txtScore.Location = New Point(346, 99)
        txtScore.Name = "txtScore"
        txtScore.Size = New Size(125, 27)
        txtScore.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtScore)
        Controls.Add(lblScore)
        Controls.Add(btnGrade)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGrade As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents txtScore As TextBox
End Class
