<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing_Statement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnBillPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBillingPrice = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtBillDiscount = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.gdatetime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtBillingQnty = New Guna.UI.WinForms.GunaTextBox()
        Me.txtBillTotal = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvBilling = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClearBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBillingName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtBillID = New Guna.UI.WinForms.GunaTextBox()
        Me.lblItemPrice = New Guna.UI.WinForms.GunaLabel()
        Me.lblItemName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnBillPrint
        '
        Me.btnBillPrint.BorderColor = System.Drawing.Color.White
        Me.btnBillPrint.BorderRadius = 20
        Me.btnBillPrint.CheckedState.Parent = Me.btnBillPrint
        Me.btnBillPrint.CustomBorderColor = System.Drawing.Color.White
        Me.btnBillPrint.CustomImages.Parent = Me.btnBillPrint
        Me.btnBillPrint.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnBillPrint.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillPrint.ForeColor = System.Drawing.Color.White
        Me.btnBillPrint.HoverState.Parent = Me.btnBillPrint
        Me.btnBillPrint.Location = New System.Drawing.Point(671, 521)
        Me.btnBillPrint.Name = "btnBillPrint"
        Me.btnBillPrint.ShadowDecoration.Parent = Me.btnBillPrint
        Me.btnBillPrint.Size = New System.Drawing.Size(90, 34)
        Me.btnBillPrint.TabIndex = 176
        Me.btnBillPrint.Text = "Print"
        '
        'txtBillingPrice
        '
        Me.txtBillingPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtBillingPrice.BaseColor = System.Drawing.Color.White
        Me.txtBillingPrice.BorderColor = System.Drawing.Color.Silver
        Me.txtBillingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillingPrice.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillingPrice.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillingPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillingPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillingPrice.Location = New System.Drawing.Point(208, 167)
        Me.txtBillingPrice.Name = "txtBillingPrice"
        Me.txtBillingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillingPrice.Radius = 10
        Me.txtBillingPrice.SelectedText = ""
        Me.txtBillingPrice.Size = New System.Drawing.Size(185, 26)
        Me.txtBillingPrice.TabIndex = 175
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel6.Location = New System.Drawing.Point(153, 174)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(40, 19)
        Me.GunaLabel6.TabIndex = 174
        Me.GunaLabel6.Text = "Price"
        '
        'txtBillDiscount
        '
        Me.txtBillDiscount.BackColor = System.Drawing.Color.Transparent
        Me.txtBillDiscount.BaseColor = System.Drawing.Color.White
        Me.txtBillDiscount.BorderColor = System.Drawing.Color.Silver
        Me.txtBillDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillDiscount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillDiscount.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillDiscount.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillDiscount.Location = New System.Drawing.Point(623, 439)
        Me.txtBillDiscount.Name = "txtBillDiscount"
        Me.txtBillDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillDiscount.Radius = 10
        Me.txtBillDiscount.SelectedText = ""
        Me.txtBillDiscount.Size = New System.Drawing.Size(185, 39)
        Me.txtBillDiscount.TabIndex = 173
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel5.Location = New System.Drawing.Point(681, 408)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(62, 19)
        Me.GunaLabel5.TabIndex = 172
        Me.GunaLabel5.Text = "Discount"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel4.Location = New System.Drawing.Point(460, 174)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(78, 19)
        Me.GunaLabel4.TabIndex = 171
        Me.GunaLabel4.Text = "Billing Date"
        '
        'gdatetime
        '
        Me.gdatetime.BorderRadius = 6
        Me.gdatetime.CheckedState.Parent = Me.gdatetime
        Me.gdatetime.FillColor = System.Drawing.Color.White
        Me.gdatetime.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.gdatetime.HoverState.Parent = Me.gdatetime
        Me.gdatetime.Location = New System.Drawing.Point(560, 164)
        Me.gdatetime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gdatetime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gdatetime.Name = "gdatetime"
        Me.gdatetime.ShadowDecoration.Parent = Me.gdatetime
        Me.gdatetime.Size = New System.Drawing.Size(200, 36)
        Me.gdatetime.TabIndex = 170
        Me.gdatetime.Value = New Date(2022, 12, 7, 15, 45, 34, 275)
        '
        'txtBillingQnty
        '
        Me.txtBillingQnty.BackColor = System.Drawing.Color.Transparent
        Me.txtBillingQnty.BaseColor = System.Drawing.Color.White
        Me.txtBillingQnty.BorderColor = System.Drawing.Color.Silver
        Me.txtBillingQnty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillingQnty.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillingQnty.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillingQnty.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillingQnty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillingQnty.Location = New System.Drawing.Point(631, 108)
        Me.txtBillingQnty.Name = "txtBillingQnty"
        Me.txtBillingQnty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillingQnty.Radius = 10
        Me.txtBillingQnty.SelectedText = ""
        Me.txtBillingQnty.Size = New System.Drawing.Size(167, 26)
        Me.txtBillingQnty.TabIndex = 169
        '
        'txtBillTotal
        '
        Me.txtBillTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtBillTotal.BaseColor = System.Drawing.Color.White
        Me.txtBillTotal.BorderColor = System.Drawing.Color.Silver
        Me.txtBillTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillTotal.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillTotal.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillTotal.Location = New System.Drawing.Point(623, 349)
        Me.txtBillTotal.Name = "txtBillTotal"
        Me.txtBillTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillTotal.Radius = 10
        Me.txtBillTotal.SelectedText = ""
        Me.txtBillTotal.Size = New System.Drawing.Size(185, 36)
        Me.txtBillTotal.TabIndex = 168
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel3.Location = New System.Drawing.Point(37, 110)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(52, 19)
        Me.GunaLabel3.TabIndex = 167
        Me.GunaLabel3.Text = "Bill_ID"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel1.Location = New System.Drawing.Point(557, 110)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(60, 19)
        Me.GunaLabel1.TabIndex = 166
        Me.GunaLabel1.Text = "Quantity"
        '
        'dgvBilling
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvBilling.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBilling.BackgroundColor = System.Drawing.Color.White
        Me.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBilling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBilling.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBilling.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBilling.EnableHeadersVisualStyles = False
        Me.dgvBilling.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBilling.Location = New System.Drawing.Point(41, 273)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.RowHeadersVisible = False
        Me.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBilling.Size = New System.Drawing.Size(566, 297)
        Me.dgvBilling.TabIndex = 165
        Me.dgvBilling.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvBilling.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBilling.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBilling.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBilling.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBilling.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBilling.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvBilling.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBilling.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvBilling.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBilling.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBilling.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvBilling.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBilling.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvBilling.ThemeStyle.ReadOnly = False
        Me.dgvBilling.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBilling.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBilling.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBilling.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvBilling.ThemeStyle.RowsStyle.Height = 22
        Me.dgvBilling.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.dgvBilling.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnClearBilling
        '
        Me.btnClearBilling.BorderColor = System.Drawing.Color.White
        Me.btnClearBilling.BorderRadius = 20
        Me.btnClearBilling.CheckedState.Parent = Me.btnClearBilling
        Me.btnClearBilling.CustomBorderColor = System.Drawing.Color.White
        Me.btnClearBilling.CustomImages.Parent = Me.btnClearBilling
        Me.btnClearBilling.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearBilling.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBilling.ForeColor = System.Drawing.Color.White
        Me.btnClearBilling.HoverState.Parent = Me.btnClearBilling
        Me.btnClearBilling.Location = New System.Drawing.Point(557, 216)
        Me.btnClearBilling.Name = "btnClearBilling"
        Me.btnClearBilling.ShadowDecoration.Parent = Me.btnClearBilling
        Me.btnClearBilling.Size = New System.Drawing.Size(90, 34)
        Me.btnClearBilling.TabIndex = 164
        Me.btnClearBilling.Text = "Clear"
        '
        'btnDelBilling
        '
        Me.btnDelBilling.BorderColor = System.Drawing.Color.White
        Me.btnDelBilling.BorderRadius = 20
        Me.btnDelBilling.CheckedState.Parent = Me.btnDelBilling
        Me.btnDelBilling.CustomBorderColor = System.Drawing.Color.White
        Me.btnDelBilling.CustomImages.Parent = Me.btnDelBilling
        Me.btnDelBilling.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelBilling.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelBilling.ForeColor = System.Drawing.Color.White
        Me.btnDelBilling.HoverState.Parent = Me.btnDelBilling
        Me.btnDelBilling.Location = New System.Drawing.Point(441, 216)
        Me.btnDelBilling.Name = "btnDelBilling"
        Me.btnDelBilling.ShadowDecoration.Parent = Me.btnDelBilling
        Me.btnDelBilling.Size = New System.Drawing.Size(90, 34)
        Me.btnDelBilling.TabIndex = 163
        Me.btnDelBilling.Text = "Delete"
        '
        'btnEditBilling
        '
        Me.btnEditBilling.BorderColor = System.Drawing.Color.White
        Me.btnEditBilling.BorderRadius = 20
        Me.btnEditBilling.CheckedState.Parent = Me.btnEditBilling
        Me.btnEditBilling.CustomBorderColor = System.Drawing.Color.White
        Me.btnEditBilling.CustomImages.Parent = Me.btnEditBilling
        Me.btnEditBilling.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditBilling.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBilling.ForeColor = System.Drawing.Color.White
        Me.btnEditBilling.HoverState.Parent = Me.btnEditBilling
        Me.btnEditBilling.Location = New System.Drawing.Point(326, 217)
        Me.btnEditBilling.Name = "btnEditBilling"
        Me.btnEditBilling.ShadowDecoration.Parent = Me.btnEditBilling
        Me.btnEditBilling.Size = New System.Drawing.Size(90, 34)
        Me.btnEditBilling.TabIndex = 162
        Me.btnEditBilling.Text = "Edit"
        '
        'btnAddBilling
        '
        Me.btnAddBilling.BorderColor = System.Drawing.Color.White
        Me.btnAddBilling.BorderRadius = 20
        Me.btnAddBilling.CheckedState.Parent = Me.btnAddBilling
        Me.btnAddBilling.CustomBorderColor = System.Drawing.Color.White
        Me.btnAddBilling.CustomImages.Parent = Me.btnAddBilling
        Me.btnAddBilling.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddBilling.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBilling.ForeColor = System.Drawing.Color.White
        Me.btnAddBilling.HoverState.Parent = Me.btnAddBilling
        Me.btnAddBilling.Location = New System.Drawing.Point(208, 216)
        Me.btnAddBilling.Name = "btnAddBilling"
        Me.btnAddBilling.ShadowDecoration.Parent = Me.btnAddBilling
        Me.btnAddBilling.Size = New System.Drawing.Size(90, 34)
        Me.btnAddBilling.TabIndex = 161
        Me.btnAddBilling.Text = "Add"
        '
        'txtBillingName
        '
        Me.txtBillingName.BackColor = System.Drawing.Color.Transparent
        Me.txtBillingName.BaseColor = System.Drawing.Color.White
        Me.txtBillingName.BorderColor = System.Drawing.Color.Silver
        Me.txtBillingName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillingName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillingName.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillingName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillingName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillingName.Location = New System.Drawing.Point(353, 108)
        Me.txtBillingName.Name = "txtBillingName"
        Me.txtBillingName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillingName.Radius = 10
        Me.txtBillingName.SelectedText = ""
        Me.txtBillingName.Size = New System.Drawing.Size(185, 26)
        Me.txtBillingName.TabIndex = 160
        '
        'txtBillID
        '
        Me.txtBillID.BackColor = System.Drawing.Color.Transparent
        Me.txtBillID.BaseColor = System.Drawing.Color.White
        Me.txtBillID.BorderColor = System.Drawing.Color.Silver
        Me.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBillID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBillID.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtBillID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBillID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillID.Location = New System.Drawing.Point(103, 108)
        Me.txtBillID.Name = "txtBillID"
        Me.txtBillID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBillID.Radius = 10
        Me.txtBillID.SelectedText = ""
        Me.txtBillID.Size = New System.Drawing.Size(124, 26)
        Me.txtBillID.TabIndex = 159
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemPrice.Location = New System.Drawing.Point(690, 317)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(39, 19)
        Me.lblItemPrice.TabIndex = 158
        Me.lblItemPrice.Text = "Total"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemName.Location = New System.Drawing.Point(268, 110)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(77, 19)
        Me.lblItemName.TabIndex = 157
        Me.lblItemName.Text = "Item Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(392, 39)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(67, 24)
        Me.GunaLabel2.TabIndex = 156
        Me.GunaLabel2.Text = "Billing"
        '
        'Billing_Statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 608)
        Me.Controls.Add(Me.btnBillPrint)
        Me.Controls.Add(Me.txtBillingPrice)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.txtBillDiscount)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.gdatetime)
        Me.Controls.Add(Me.txtBillingQnty)
        Me.Controls.Add(Me.txtBillTotal)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.btnClearBilling)
        Me.Controls.Add(Me.btnDelBilling)
        Me.Controls.Add(Me.btnEditBilling)
        Me.Controls.Add(Me.btnAddBilling)
        Me.Controls.Add(Me.txtBillingName)
        Me.Controls.Add(Me.txtBillID)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing_Statement"
        Me.Text = "Billing_Statement"
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnBillPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBillingPrice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtBillDiscount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gdatetime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtBillingQnty As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtBillTotal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvBilling As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBillingName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtBillID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblItemPrice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblItemName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
