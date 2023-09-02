<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Order
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvManageOrder = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClearOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCusName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtOrderID = New Guna.UI.WinForms.GunaTextBox()
        Me.lblItemName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.lblItemPrice = New Guna.UI.WinForms.GunaLabel()
        Me.txtAdvancePay = New Guna.UI.WinForms.GunaTextBox()
        Me.gdatetime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        CType(Me.dgvManageOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel3.Location = New System.Drawing.Point(29, 83)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(70, 19)
        Me.GunaLabel3.TabIndex = 130
        Me.GunaLabel3.Text = "Order_ID"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel1.Location = New System.Drawing.Point(554, 83)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(81, 19)
        Me.GunaLabel1.TabIndex = 129
        Me.GunaLabel1.Text = "Item_Name"
        '
        'dgvManageOrder
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvManageOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvManageOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvManageOrder.BackgroundColor = System.Drawing.Color.White
        Me.dgvManageOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvManageOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvManageOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManageOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvManageOrder.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManageOrder.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvManageOrder.EnableHeadersVisualStyles = False
        Me.dgvManageOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageOrder.Location = New System.Drawing.Point(51, 246)
        Me.dgvManageOrder.Name = "dgvManageOrder"
        Me.dgvManageOrder.RowHeadersVisible = False
        Me.dgvManageOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvManageOrder.Size = New System.Drawing.Size(734, 297)
        Me.dgvManageOrder.TabIndex = 128
        Me.dgvManageOrder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvManageOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageOrder.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvManageOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvManageOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvManageOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvManageOrder.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvManageOrder.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvManageOrder.ThemeStyle.ReadOnly = False
        Me.dgvManageOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvManageOrder.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvManageOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvManageOrder.ThemeStyle.RowsStyle.Height = 22
        Me.dgvManageOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.dgvManageOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnClearOrder
        '
        Me.btnClearOrder.BorderColor = System.Drawing.Color.White
        Me.btnClearOrder.BorderRadius = 20
        Me.btnClearOrder.CheckedState.Parent = Me.btnClearOrder
        Me.btnClearOrder.CustomBorderColor = System.Drawing.Color.White
        Me.btnClearOrder.CustomImages.Parent = Me.btnClearOrder
        Me.btnClearOrder.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearOrder.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearOrder.ForeColor = System.Drawing.Color.White
        Me.btnClearOrder.HoverState.Parent = Me.btnClearOrder
        Me.btnClearOrder.Location = New System.Drawing.Point(554, 189)
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.ShadowDecoration.Parent = Me.btnClearOrder
        Me.btnClearOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnClearOrder.TabIndex = 127
        Me.btnClearOrder.Text = "Clear"
        '
        'btnDelOrder
        '
        Me.btnDelOrder.BorderColor = System.Drawing.Color.White
        Me.btnDelOrder.BorderRadius = 20
        Me.btnDelOrder.CheckedState.Parent = Me.btnDelOrder
        Me.btnDelOrder.CustomBorderColor = System.Drawing.Color.White
        Me.btnDelOrder.CustomImages.Parent = Me.btnDelOrder
        Me.btnDelOrder.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelOrder.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelOrder.ForeColor = System.Drawing.Color.White
        Me.btnDelOrder.HoverState.Parent = Me.btnDelOrder
        Me.btnDelOrder.Location = New System.Drawing.Point(438, 189)
        Me.btnDelOrder.Name = "btnDelOrder"
        Me.btnDelOrder.ShadowDecoration.Parent = Me.btnDelOrder
        Me.btnDelOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnDelOrder.TabIndex = 126
        Me.btnDelOrder.Text = "Delete"
        '
        'btnEditOrder
        '
        Me.btnEditOrder.BorderColor = System.Drawing.Color.White
        Me.btnEditOrder.BorderRadius = 20
        Me.btnEditOrder.CheckedState.Parent = Me.btnEditOrder
        Me.btnEditOrder.CustomBorderColor = System.Drawing.Color.White
        Me.btnEditOrder.CustomImages.Parent = Me.btnEditOrder
        Me.btnEditOrder.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditOrder.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditOrder.ForeColor = System.Drawing.Color.White
        Me.btnEditOrder.HoverState.Parent = Me.btnEditOrder
        Me.btnEditOrder.Location = New System.Drawing.Point(323, 190)
        Me.btnEditOrder.Name = "btnEditOrder"
        Me.btnEditOrder.ShadowDecoration.Parent = Me.btnEditOrder
        Me.btnEditOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnEditOrder.TabIndex = 125
        Me.btnEditOrder.Text = "Edit"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BorderColor = System.Drawing.Color.White
        Me.btnAddOrder.BorderRadius = 20
        Me.btnAddOrder.CheckedState.Parent = Me.btnAddOrder
        Me.btnAddOrder.CustomBorderColor = System.Drawing.Color.White
        Me.btnAddOrder.CustomImages.Parent = Me.btnAddOrder
        Me.btnAddOrder.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddOrder.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.HoverState.Parent = Me.btnAddOrder
        Me.btnAddOrder.Location = New System.Drawing.Point(205, 189)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.ShadowDecoration.Parent = Me.btnAddOrder
        Me.btnAddOrder.Size = New System.Drawing.Size(90, 34)
        Me.btnAddOrder.TabIndex = 124
        Me.btnAddOrder.Text = "Add"
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.Transparent
        Me.txtCusName.BaseColor = System.Drawing.Color.White
        Me.txtCusName.BorderColor = System.Drawing.Color.Silver
        Me.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCusName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCusName.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtCusName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCusName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCusName.Location = New System.Drawing.Point(357, 81)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCusName.Radius = 10
        Me.txtCusName.SelectedText = ""
        Me.txtCusName.Size = New System.Drawing.Size(185, 26)
        Me.txtCusName.TabIndex = 123
        '
        'txtOrderID
        '
        Me.txtOrderID.BackColor = System.Drawing.Color.Transparent
        Me.txtOrderID.BaseColor = System.Drawing.Color.White
        Me.txtOrderID.BorderColor = System.Drawing.Color.Silver
        Me.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtOrderID.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtOrderID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOrderID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOrderID.Location = New System.Drawing.Point(100, 81)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrderID.Radius = 10
        Me.txtOrderID.SelectedText = ""
        Me.txtOrderID.Size = New System.Drawing.Size(124, 26)
        Me.txtOrderID.TabIndex = 122
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemName.Location = New System.Drawing.Point(243, 83)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(109, 19)
        Me.lblItemName.TabIndex = 120
        Me.lblItemName.Text = "Customer Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(347, 12)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(141, 24)
        Me.GunaLabel2.TabIndex = 119
        Me.GunaLabel2.Text = "Manage Order"
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemPrice.Location = New System.Drawing.Point(137, 140)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(127, 19)
        Me.lblItemPrice.TabIndex = 121
        Me.lblItemPrice.Text = "Advanced Payment"
        '
        'txtAdvancePay
        '
        Me.txtAdvancePay.BackColor = System.Drawing.Color.Transparent
        Me.txtAdvancePay.BaseColor = System.Drawing.Color.White
        Me.txtAdvancePay.BorderColor = System.Drawing.Color.Silver
        Me.txtAdvancePay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdvancePay.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAdvancePay.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtAdvancePay.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAdvancePay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdvancePay.Location = New System.Drawing.Point(271, 134)
        Me.txtAdvancePay.Name = "txtAdvancePay"
        Me.txtAdvancePay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdvancePay.Radius = 10
        Me.txtAdvancePay.SelectedText = ""
        Me.txtAdvancePay.Size = New System.Drawing.Size(185, 26)
        Me.txtAdvancePay.TabIndex = 131
        '
        'gdatetime
        '
        Me.gdatetime.BorderRadius = 6
        Me.gdatetime.CheckedState.Parent = Me.gdatetime
        Me.gdatetime.FillColor = System.Drawing.Color.White
        Me.gdatetime.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.gdatetime.HoverState.Parent = Me.gdatetime
        Me.gdatetime.Location = New System.Drawing.Point(585, 134)
        Me.gdatetime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gdatetime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gdatetime.Name = "gdatetime"
        Me.gdatetime.ShadowDecoration.Parent = Me.gdatetime
        Me.gdatetime.Size = New System.Drawing.Size(200, 36)
        Me.gdatetime.TabIndex = 133
        Me.gdatetime.Value = New Date(2022, 12, 7, 15, 45, 34, 275)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel4.Location = New System.Drawing.Point(489, 140)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(94, 19)
        Me.GunaLabel4.TabIndex = 134
        Me.GunaLabel4.Text = "Payment Date"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Table", "Chair", "Desk", "Mailbox", "Book Shelves", "Picture Frame"})
        Me.cmbCategory.Location = New System.Drawing.Point(641, 81)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(175, 21)
        Me.cmbCategory.TabIndex = 135
        '
        'Manage_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 608)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.gdatetime)
        Me.Controls.Add(Me.txtAdvancePay)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgvManageOrder)
        Me.Controls.Add(Me.btnClearOrder)
        Me.Controls.Add(Me.btnDelOrder)
        Me.Controls.Add(Me.btnEditOrder)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manage_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        CType(Me.dgvManageOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvManageOrder As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCusName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtOrderID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblItemName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gdatetime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtAdvancePay As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblItemPrice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
End Class
