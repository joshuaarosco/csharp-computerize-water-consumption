<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dashboard))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datagrid_transaction = New System.Windows.Forms.DataGridView()
        Me.btn_create_account = New System.Windows.Forms.Button()
        Me.btn_view_transaction = New System.Windows.Forms.Button()
        Me.btn_view_account = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.LightCoral
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(889, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Dashboard"
        '
        'datagrid_transaction
        '
        Me.datagrid_transaction.AllowUserToAddRows = False
        Me.datagrid_transaction.AllowUserToDeleteRows = False
        Me.datagrid_transaction.AllowUserToResizeColumns = False
        Me.datagrid_transaction.AllowUserToResizeRows = False
        Me.datagrid_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_transaction.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.datagrid_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagrid_transaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_transaction.Location = New System.Drawing.Point(337, 37)
        Me.datagrid_transaction.MultiSelect = False
        Me.datagrid_transaction.Name = "datagrid_transaction"
        Me.datagrid_transaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.datagrid_transaction.Size = New System.Drawing.Size(576, 344)
        Me.datagrid_transaction.TabIndex = 15
        '
        'btn_create_account
        '
        Me.btn_create_account.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_create_account.FlatAppearance.BorderSize = 0
        Me.btn_create_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_account.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_create_account.Location = New System.Drawing.Point(725, 387)
        Me.btn_create_account.Name = "btn_create_account"
        Me.btn_create_account.Size = New System.Drawing.Size(188, 30)
        Me.btn_create_account.TabIndex = 16
        Me.btn_create_account.Text = "+ Create New Account"
        Me.btn_create_account.UseVisualStyleBackColor = False
        '
        'btn_view_transaction
        '
        Me.btn_view_transaction.BackColor = System.Drawing.Color.Silver
        Me.btn_view_transaction.Enabled = False
        Me.btn_view_transaction.FlatAppearance.BorderSize = 0
        Me.btn_view_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_transaction.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_view_transaction.Location = New System.Drawing.Point(337, 387)
        Me.btn_view_transaction.Name = "btn_view_transaction"
        Me.btn_view_transaction.Size = New System.Drawing.Size(188, 30)
        Me.btn_view_transaction.TabIndex = 17
        Me.btn_view_transaction.Text = "View Meter Trail"
        Me.btn_view_transaction.UseVisualStyleBackColor = False
        '
        'btn_view_account
        '
        Me.btn_view_account.BackColor = System.Drawing.Color.Silver
        Me.btn_view_account.Enabled = False
        Me.btn_view_account.FlatAppearance.BorderSize = 0
        Me.btn_view_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_account.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_view_account.Location = New System.Drawing.Point(531, 387)
        Me.btn_view_account.Name = "btn_view_account"
        Me.btn_view_account.Size = New System.Drawing.Size(188, 30)
        Me.btn_view_account.TabIndex = 18
        Me.btn_view_account.Text = "View Account"
        Me.btn_view_account.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_search.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(337, 5)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(382, 27)
        Me.txt_search.TabIndex = 19
        Me.txt_search.WordWrap = False
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_search.Location = New System.Drawing.Point(342, 10)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(46, 15)
        Me.lbl_search.TabIndex = 20
        Me.lbl_search.Text = "Search"
        '
        'frm_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 424)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_view_account)
        Me.Controls.Add(Me.btn_view_transaction)
        Me.Controls.Add(Me.btn_create_account)
        Me.Controls.Add(Me.datagrid_transaction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datagrid_transaction As System.Windows.Forms.DataGridView
    Friend WithEvents btn_create_account As System.Windows.Forms.Button
    Friend WithEvents btn_view_transaction As System.Windows.Forms.Button
    Friend WithEvents btn_view_account As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents lbl_search As System.Windows.Forms.Label
End Class
