<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_transaction))
        Me.datagrid_transaction = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_cubicmeter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usedcubicmeter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_previouscubicmeter = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_total = New System.Windows.Forms.Button()
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid_transaction
        '
        Me.datagrid_transaction.AllowUserToAddRows = False
        Me.datagrid_transaction.AllowUserToDeleteRows = False
        Me.datagrid_transaction.AllowUserToResizeColumns = False
        Me.datagrid_transaction.AllowUserToResizeRows = False
        Me.datagrid_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_transaction.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.datagrid_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_transaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_transaction.Location = New System.Drawing.Point(337, 37)
        Me.datagrid_transaction.Name = "datagrid_transaction"
        Me.datagrid_transaction.Size = New System.Drawing.Size(517, 344)
        Me.datagrid_transaction.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.LightCoral
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(831, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_calculate
        '
        Me.btn_calculate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_calculate.FlatAppearance.BorderSize = 0
        Me.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calculate.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_calculate.Location = New System.Drawing.Point(32, 351)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(278, 30)
        Me.btn_calculate.TabIndex = 4
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = False
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(29, 88)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(64, 13)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "Cubic Meter"
        '
        'txt_cubicmeter
        '
        Me.txt_cubicmeter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cubicmeter.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_cubicmeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cubicmeter.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cubicmeter.Location = New System.Drawing.Point(33, 106)
        Me.txt_cubicmeter.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cubicmeter.Multiline = True
        Me.txt_cubicmeter.Name = "txt_cubicmeter"
        Me.txt_cubicmeter.Size = New System.Drawing.Size(277, 30)
        Me.txt_cubicmeter.TabIndex = 5
        Me.txt_cubicmeter.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Used Cubic Meter"
        '
        'txt_usedcubicmeter
        '
        Me.txt_usedcubicmeter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_usedcubicmeter.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_usedcubicmeter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usedcubicmeter.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usedcubicmeter.Location = New System.Drawing.Point(33, 168)
        Me.txt_usedcubicmeter.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_usedcubicmeter.Multiline = True
        Me.txt_usedcubicmeter.Name = "txt_usedcubicmeter"
        Me.txt_usedcubicmeter.ReadOnly = True
        Me.txt_usedcubicmeter.Size = New System.Drawing.Size(277, 30)
        Me.txt_usedcubicmeter.TabIndex = 7
        Me.txt_usedcubicmeter.Text = "0.00"
        Me.txt_usedcubicmeter.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Peso"
        '
        'txt_peso
        '
        Me.txt_peso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_peso.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_peso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_peso.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_peso.Location = New System.Drawing.Point(33, 231)
        Me.txt_peso.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_peso.Multiline = True
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.ReadOnly = True
        Me.txt_peso.Size = New System.Drawing.Size(277, 30)
        Me.txt_peso.TabIndex = 9
        Me.txt_peso.Text = "0.00"
        Me.txt_peso.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Previous Cubic Meter"
        '
        'txt_previouscubicmeter
        '
        Me.txt_previouscubicmeter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_previouscubicmeter.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_previouscubicmeter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_previouscubicmeter.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_previouscubicmeter.Location = New System.Drawing.Point(33, 293)
        Me.txt_previouscubicmeter.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_previouscubicmeter.Multiline = True
        Me.txt_previouscubicmeter.Name = "txt_previouscubicmeter"
        Me.txt_previouscubicmeter.ReadOnly = True
        Me.txt_previouscubicmeter.Size = New System.Drawing.Size(277, 30)
        Me.txt_previouscubicmeter.TabIndex = 11
        Me.txt_previouscubicmeter.Text = "0.00"
        Me.txt_previouscubicmeter.WordWrap = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(26, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(194, 24)
        Me.lbl_title.TabIndex = 13
        Me.lbl_title.Text = "Calculate Cubic Meter"
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.DarkGray
        Me.btn_history.FlatAppearance.BorderSize = 0
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btn_history.Location = New System.Drawing.Point(741, 387)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(113, 30)
        Me.btn_history.TabIndex = 14
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkGray
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btn_back.Location = New System.Drawing.Point(337, 387)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(113, 30)
        Me.btn_back.TabIndex = 15
        Me.btn_back.Text = "< Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_total
        '
        Me.btn_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_total.FlatAppearance.BorderSize = 0
        Me.btn_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_total.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btn_total.Location = New System.Drawing.Point(456, 387)
        Me.btn_total.Name = "btn_total"
        Me.btn_total.Size = New System.Drawing.Size(279, 30)
        Me.btn_total.TabIndex = 16
        Me.btn_total.Text = "Total"
        Me.btn_total.UseVisualStyleBackColor = False
        '
        'frm_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 424)
        Me.Controls.Add(Me.btn_total)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_previouscubicmeter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usedcubicmeter)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_cubicmeter)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.datagrid_transaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagrid_transaction As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents txt_cubicmeter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_usedcubicmeter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_peso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_previouscubicmeter As System.Windows.Forms.TextBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_history As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_total As System.Windows.Forms.Button
End Class
