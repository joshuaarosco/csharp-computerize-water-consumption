<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_account_details
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_contact_number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.LightCoral
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(502, 1)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_exit.TabIndex = 31
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Coral
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(281, 290)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(221, 30)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Contact Number"
        '
        'txt_contact_number
        '
        Me.txt_contact_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_contact_number.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_contact_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contact_number.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact_number.Location = New System.Drawing.Point(33, 146)
        Me.txt_contact_number.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_contact_number.Multiline = True
        Me.txt_contact_number.Name = "txt_contact_number"
        Me.txt_contact_number.Size = New System.Drawing.Size(469, 30)
        Me.txt_contact_number.TabIndex = 27
        Me.txt_contact_number.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_address.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(33, 205)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(469, 56)
        Me.txt_address.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Last Name"
        '
        'txt_lname
        '
        Me.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_lname.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lname.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(281, 87)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_lname.Multiline = True
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(221, 30)
        Me.txt_lname.TabIndex = 26
        Me.txt_lname.WordWrap = False
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(34, 69)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(57, 13)
        Me.lbl_username.TabIndex = 33
        Me.lbl_username.Text = "First Name"
        '
        'txt_fname
        '
        Me.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_fname.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(33, 87)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_fname.Multiline = True
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(221, 30)
        Me.txt_fname.TabIndex = 25
        Me.txt_fname.WordWrap = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_update.Location = New System.Drawing.Point(33, 289)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(221, 30)
        Me.btn_update.TabIndex = 29
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(26, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(145, 24)
        Me.lbl_title.TabIndex = 32
        Me.lbl_title.Text = "Update Account"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 343)
        Me.Panel1.TabIndex = 37
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_minimize.Location = New System.Drawing.Point(471, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimize.TabIndex = 9
        Me.btn_minimize.Text = "_"
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'frm_account_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 343)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_contact_number)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_account_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_account_details"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_contact_number As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_minimize As System.Windows.Forms.Button
End Class
