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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dashboard))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_auth_name = New System.Windows.Forms.Label()
        Me.datagrid_transaction = New System.Windows.Forms.DataGridView()
        Me.btn_create_account = New System.Windows.Forms.Button()
        Me.btn_view_transaction = New System.Windows.Forms.Button()
        Me.btn_view_account = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.pnl_account = New System.Windows.Forms.Panel()
        Me.btn_update_account_status = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_months = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_last_meter_date = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_total_peso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total_meter = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_no_of_user = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_paid = New System.Windows.Forms.Label()
        Me.lbl_unpaid = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_clock = New System.Windows.Forms.Label()
        Me.lbl_greet = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_account.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.LightCoral
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(888, 1)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_auth_name
        '
        Me.lbl_auth_name.AutoSize = True
        Me.lbl_auth_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_auth_name.Location = New System.Drawing.Point(63, 17)
        Me.lbl_auth_name.Name = "lbl_auth_name"
        Me.lbl_auth_name.Size = New System.Drawing.Size(83, 18)
        Me.lbl_auth_name.TabIndex = 14
        Me.lbl_auth_name.Text = "Super User"
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
        Me.datagrid_transaction.GridColor = System.Drawing.SystemColors.ScrollBar
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
        'pnl_account
        '
        Me.pnl_account.Controls.Add(Me.btn_update_account_status)
        Me.pnl_account.Controls.Add(Me.Label7)
        Me.pnl_account.Controls.Add(Me.txt_status)
        Me.pnl_account.Controls.Add(Me.Label6)
        Me.pnl_account.Controls.Add(Me.txt_months)
        Me.pnl_account.Controls.Add(Me.Label3)
        Me.pnl_account.Controls.Add(Me.txt_last_meter_date)
        Me.pnl_account.Controls.Add(Me.Label5)
        Me.pnl_account.Controls.Add(Me.txt_total_peso)
        Me.pnl_account.Controls.Add(Me.Label2)
        Me.pnl_account.Controls.Add(Me.txt_total_meter)
        Me.pnl_account.Controls.Add(Me.lbl_name)
        Me.pnl_account.Controls.Add(Me.txt_name)
        Me.pnl_account.Location = New System.Drawing.Point(10, 101)
        Me.pnl_account.Name = "pnl_account"
        Me.pnl_account.Size = New System.Drawing.Size(320, 316)
        Me.pnl_account.TabIndex = 21
        '
        'btn_update_account_status
        '
        Me.btn_update_account_status.BackColor = System.Drawing.Color.Silver
        Me.btn_update_account_status.Enabled = False
        Me.btn_update_account_status.FlatAppearance.BorderSize = 0
        Me.btn_update_account_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update_account_status.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_update_account_status.Location = New System.Drawing.Point(0, 286)
        Me.btn_update_account_status.Name = "btn_update_account_status"
        Me.btn_update_account_status.Size = New System.Drawing.Size(320, 30)
        Me.btn_update_account_status.TabIndex = 26
        Me.btn_update_account_status.Text = "Settle Account"
        Me.btn_update_account_status.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Account Status :"
        '
        'txt_status
        '
        Me.txt_status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_status.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_status.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.Location = New System.Drawing.Point(177, 234)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_status.Multiline = True
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ReadOnly = True
        Me.txt_status.Size = New System.Drawing.Size(143, 27)
        Me.txt_status.TabIndex = 18
        Me.txt_status.Text = "0000"
        Me.txt_status.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "No. of Month(s) :"
        '
        'txt_months
        '
        Me.txt_months.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_months.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_months.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_months.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_months.Location = New System.Drawing.Point(0, 234)
        Me.txt_months.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_months.Multiline = True
        Me.txt_months.Name = "txt_months"
        Me.txt_months.ReadOnly = True
        Me.txt_months.Size = New System.Drawing.Size(143, 27)
        Me.txt_months.TabIndex = 16
        Me.txt_months.Text = "0"
        Me.txt_months.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last Meter Reading Date :"
        '
        'txt_last_meter_date
        '
        Me.txt_last_meter_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_last_meter_date.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_last_meter_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_last_meter_date.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last_meter_date.Location = New System.Drawing.Point(0, 181)
        Me.txt_last_meter_date.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_last_meter_date.Multiline = True
        Me.txt_last_meter_date.Name = "txt_last_meter_date"
        Me.txt_last_meter_date.ReadOnly = True
        Me.txt_last_meter_date.Size = New System.Drawing.Size(320, 27)
        Me.txt_last_meter_date.TabIndex = 14
        Me.txt_last_meter_date.Text = "000 00,0000"
        Me.txt_last_meter_date.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Amount in Peso :"
        '
        'txt_total_peso
        '
        Me.txt_total_peso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_total_peso.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_total_peso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total_peso.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_peso.Location = New System.Drawing.Point(0, 127)
        Me.txt_total_peso.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_total_peso.Multiline = True
        Me.txt_total_peso.Name = "txt_total_peso"
        Me.txt_total_peso.ReadOnly = True
        Me.txt_total_peso.Size = New System.Drawing.Size(320, 27)
        Me.txt_total_peso.TabIndex = 9
        Me.txt_total_peso.Text = "0.00"
        Me.txt_total_peso.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Cubic Meter :"
        '
        'txt_total_meter
        '
        Me.txt_total_meter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_total_meter.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_total_meter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total_meter.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_meter.Location = New System.Drawing.Point(0, 73)
        Me.txt_total_meter.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_total_meter.Multiline = True
        Me.txt_total_meter.Name = "txt_total_meter"
        Me.txt_total_meter.ReadOnly = True
        Me.txt_total_meter.Size = New System.Drawing.Size(320, 27)
        Me.txt_total_meter.TabIndex = 7
        Me.txt_total_meter.Text = "0.00"
        Me.txt_total_meter.WordWrap = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(2, 4)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(78, 13)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Accout Name :"
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_name.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(0, 20)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(320, 27)
        Me.txt_name.TabIndex = 5
        Me.txt_name.Text = "0000 0000"
        Me.txt_name.WordWrap = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbl_date.Location = New System.Drawing.Point(250, 42)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(79, 15)
        Me.lbl_date.TabIndex = 22
        Me.lbl_date.Text = "XXX 00,0000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(14, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Users :"
        '
        'lbl_no_of_user
        '
        Me.lbl_no_of_user.AutoSize = True
        Me.lbl_no_of_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_of_user.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_no_of_user.Location = New System.Drawing.Point(56, 72)
        Me.lbl_no_of_user.Name = "lbl_no_of_user"
        Me.lbl_no_of_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_no_of_user.Size = New System.Drawing.Size(52, 15)
        Me.lbl_no_of_user.TabIndex = 24
        Me.lbl_no_of_user.Text = "000,000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(123, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Paid :"
        '
        'lbl_paid
        '
        Me.lbl_paid.AutoSize = True
        Me.lbl_paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paid.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_paid.Location = New System.Drawing.Point(157, 72)
        Me.lbl_paid.Name = "lbl_paid"
        Me.lbl_paid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_paid.Size = New System.Drawing.Size(52, 15)
        Me.lbl_paid.TabIndex = 26
        Me.lbl_paid.Text = "000,000"
        Me.lbl_paid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_unpaid
        '
        Me.lbl_unpaid.AutoSize = True
        Me.lbl_unpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unpaid.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_unpaid.Location = New System.Drawing.Point(272, 72)
        Me.lbl_unpaid.Name = "lbl_unpaid"
        Me.lbl_unpaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_unpaid.Size = New System.Drawing.Size(52, 15)
        Me.lbl_unpaid.TabIndex = 28
        Me.lbl_unpaid.Text = "000,000"
        Me.lbl_unpaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label13.Location = New System.Drawing.Point(219, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Unpaid  :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_clock)
        Me.Panel1.Controls.Add(Me.lbl_no_of_user)
        Me.Panel1.Controls.Add(Me.lbl_greet)
        Me.Panel1.Controls.Add(Me.lbl_unpaid)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_paid)
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbl_auth_name)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 424)
        Me.Panel1.TabIndex = 29
        '
        'lbl_clock
        '
        Me.lbl_clock.AutoSize = True
        Me.lbl_clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clock.Location = New System.Drawing.Point(218, 16)
        Me.lbl_clock.Name = "lbl_clock"
        Me.lbl_clock.Size = New System.Drawing.Size(117, 29)
        Me.lbl_clock.TabIndex = 30
        Me.lbl_clock.Text = "00:00 MM"
        '
        'lbl_greet
        '
        Me.lbl_greet.AutoSize = True
        Me.lbl_greet.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbl_greet.Location = New System.Drawing.Point(63, 36)
        Me.lbl_greet.Name = "lbl_greet"
        Me.lbl_greet.Size = New System.Drawing.Size(52, 13)
        Me.lbl_greet.TabIndex = 29
        Me.lbl_greet.Text = "Greetings"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ComputerizedWaterConsumption.My.Resources.Resources.face02
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_minimize.Location = New System.Drawing.Point(857, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimize.TabIndex = 11
        Me.btn_minimize.Text = "_"
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 67)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(106, 27)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.WordWrap = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(402, 198)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(113, 27)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.WordWrap = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(112, 67)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(103, 27)
        Me.TextBox3.TabIndex = 32
        Me.TextBox3.WordWrap = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(204, 67)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(125, 27)
        Me.TextBox4.TabIndex = 33
        Me.TextBox4.WordWrap = False
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
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.pnl_account)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.datagrid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_account.ResumeLayout(False)
        Me.pnl_account.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents lbl_auth_name As System.Windows.Forms.Label
    Friend WithEvents datagrid_transaction As System.Windows.Forms.DataGridView
    Friend WithEvents btn_create_account As System.Windows.Forms.Button
    Friend WithEvents btn_view_transaction As System.Windows.Forms.Button
    Friend WithEvents btn_view_account As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents lbl_search As System.Windows.Forms.Label
    Friend WithEvents pnl_account As System.Windows.Forms.Panel
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_total_peso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_total_meter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_last_meter_date As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_months As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_no_of_user As System.Windows.Forms.Label
    Friend WithEvents btn_update_account_status As System.Windows.Forms.Button
    Friend WithEvents lbl_paid As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_unpaid As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_minimize As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_greet As System.Windows.Forms.Label
    Friend WithEvents lbl_clock As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
