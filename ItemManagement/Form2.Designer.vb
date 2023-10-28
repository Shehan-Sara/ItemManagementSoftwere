<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel2 = New Panel()
        Button7 = New Button()
        Button6 = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Panel4 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button6)
        Panel2.Location = New Point(189, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(656, 59)
        Panel2.TabIndex = 2
        ' 
        ' Button7
        ' 
        Button7.FlatAppearance.BorderColor = Color.Red
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Image = My.Resources.Resources.create
        Button7.Location = New Point(25, 7)
        Button7.Name = "Button7"
        Button7.Size = New Size(162, 44)
        Button7.TabIndex = 2
        Button7.Text = " Create New"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Image = My.Resources.Resources.close
        Button6.Location = New Point(624, 8)
        Button6.Name = "Button6"
        Button6.Size = New Size(22, 22)
        Button6.TabIndex = 0
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(211, 453)
        Panel1.TabIndex = 3
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Barlow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        Button5.Image = My.Resources.Resources.about
        Button5.Location = New Point(3, 334)
        Button5.Name = "Button5"
        Button5.Size = New Size(211, 47)
        Button5.TabIndex = 9
        Button5.Text = " About"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Barlow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        Button4.Image = My.Resources.Resources.records
        Button4.Location = New Point(3, 271)
        Button4.Name = "Button4"
        Button4.Size = New Size(211, 47)
        Button4.TabIndex = 7
        Button4.Text = " Records"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Barlow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        Button3.Image = My.Resources.Resources.complete
        Button3.Location = New Point(3, 208)
        Button3.Name = "Button3"
        Button3.Size = New Size(211, 47)
        Button3.TabIndex = 5
        Button3.Text = " Complete"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(173), CByte(181))
        Panel4.Location = New Point(3, 145)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(15, 47)
        Panel4.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Barlow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        Button2.Image = My.Resources.Resources.pending
        Button2.Location = New Point(3, 145)
        Button2.Name = "Button2"
        Button2.Size = New Size(211, 47)
        Button2.TabIndex = 3
        Button2.Text = " Pending"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Barlow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        Button1.Image = My.Resources.Resources.icons8_home_20
        Button1.Location = New Point(3, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 47)
        Button1.TabIndex = 0
        Button1.Text = " Home"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 404)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
