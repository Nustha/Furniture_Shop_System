<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock_Details
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvStockDet = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClearItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddItem = New Guna.UI2.WinForms.Guna2Button()
        Me.txtItemQnty = New Guna.UI.WinForms.GunaTextBox()
        Me.txtItemName = New Guna.UI.WinForms.GunaTextBox()
        Me.lblItemPrice = New Guna.UI.WinForms.GunaLabel()
        Me.lblItemName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtStockID = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.dgvStockDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Table", "Chair", "Desk", "Mailbox", "Book Shelves", "Picture Frame"})
        Me.cmbCategory.Location = New System.Drawing.Point(589, 81)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(187, 21)
        Me.cmbCategory.TabIndex = 99
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel1.Location = New System.Drawing.Point(512, 83)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 19)
        Me.GunaLabel1.TabIndex = 98
        Me.GunaLabel1.Text = "Category"
        '
        'dgvStockDet
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStockDet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockDet.BackgroundColor = System.Drawing.Color.White
        Me.dgvStockDet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockDet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockDet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockDet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockDet.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockDet.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockDet.EnableHeadersVisualStyles = False
        Me.dgvStockDet.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStockDet.Location = New System.Drawing.Point(56, 251)
        Me.dgvStockDet.Name = "dgvStockDet"
        Me.dgvStockDet.RowHeadersVisible = False
        Me.dgvStockDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockDet.Size = New System.Drawing.Size(720, 312)
        Me.dgvStockDet.TabIndex = 97
        Me.dgvStockDet.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvStockDet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockDet.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStockDet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStockDet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStockDet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStockDet.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockDet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStockDet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvStockDet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStockDet.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockDet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockDet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvStockDet.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvStockDet.ThemeStyle.ReadOnly = False
        Me.dgvStockDet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockDet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockDet.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockDet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStockDet.ThemeStyle.RowsStyle.Height = 22
        Me.dgvStockDet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.dgvStockDet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnClearItem
        '
        Me.btnClearItem.BorderColor = System.Drawing.Color.White
        Me.btnClearItem.BorderRadius = 20
        Me.btnClearItem.CheckedState.Parent = Me.btnClearItem
        Me.btnClearItem.CustomBorderColor = System.Drawing.Color.White
        Me.btnClearItem.CustomImages.Parent = Me.btnClearItem
        Me.btnClearItem.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearItem.ForeColor = System.Drawing.Color.White
        Me.btnClearItem.HoverState.Parent = Me.btnClearItem
        Me.btnClearItem.Location = New System.Drawing.Point(551, 187)
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.ShadowDecoration.Parent = Me.btnClearItem
        Me.btnClearItem.Size = New System.Drawing.Size(90, 34)
        Me.btnClearItem.TabIndex = 96
        Me.btnClearItem.Text = "Clear"
        '
        'btnDelItem
        '
        Me.btnDelItem.BorderColor = System.Drawing.Color.White
        Me.btnDelItem.BorderRadius = 20
        Me.btnDelItem.CheckedState.Parent = Me.btnDelItem
        Me.btnDelItem.CustomBorderColor = System.Drawing.Color.White
        Me.btnDelItem.CustomImages.Parent = Me.btnDelItem
        Me.btnDelItem.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelItem.ForeColor = System.Drawing.Color.White
        Me.btnDelItem.HoverState.Parent = Me.btnDelItem
        Me.btnDelItem.Location = New System.Drawing.Point(435, 187)
        Me.btnDelItem.Name = "btnDelItem"
        Me.btnDelItem.ShadowDecoration.Parent = Me.btnDelItem
        Me.btnDelItem.Size = New System.Drawing.Size(90, 34)
        Me.btnDelItem.TabIndex = 95
        Me.btnDelItem.Text = "Delete"
        '
        'btnEditItem
        '
        Me.btnEditItem.BorderColor = System.Drawing.Color.White
        Me.btnEditItem.BorderRadius = 20
        Me.btnEditItem.CheckedState.Parent = Me.btnEditItem
        Me.btnEditItem.CustomBorderColor = System.Drawing.Color.White
        Me.btnEditItem.CustomImages.Parent = Me.btnEditItem
        Me.btnEditItem.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditItem.ForeColor = System.Drawing.Color.White
        Me.btnEditItem.HoverState.Parent = Me.btnEditItem
        Me.btnEditItem.Location = New System.Drawing.Point(320, 188)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.ShadowDecoration.Parent = Me.btnEditItem
        Me.btnEditItem.Size = New System.Drawing.Size(90, 34)
        Me.btnEditItem.TabIndex = 94
        Me.btnEditItem.Text = "Edit"
        '
        'btnAddItem
        '
        Me.btnAddItem.BorderColor = System.Drawing.Color.White
        Me.btnAddItem.BorderRadius = 20
        Me.btnAddItem.CheckedState.Parent = Me.btnAddItem
        Me.btnAddItem.CustomBorderColor = System.Drawing.Color.White
        Me.btnAddItem.CustomImages.Parent = Me.btnAddItem
        Me.btnAddItem.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.HoverState.Parent = Me.btnAddItem
        Me.btnAddItem.Location = New System.Drawing.Point(202, 187)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.ShadowDecoration.Parent = Me.btnAddItem
        Me.btnAddItem.Size = New System.Drawing.Size(90, 34)
        Me.btnAddItem.TabIndex = 93
        Me.btnAddItem.Text = "Add"
        '
        'txtItemQnty
        '
        Me.txtItemQnty.BackColor = System.Drawing.Color.Transparent
        Me.txtItemQnty.BaseColor = System.Drawing.Color.White
        Me.txtItemQnty.BorderColor = System.Drawing.Color.Silver
        Me.txtItemQnty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemQnty.FocusedBaseColor = System.Drawing.Color.White
        Me.txtItemQnty.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtItemQnty.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemQnty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemQnty.Location = New System.Drawing.Point(354, 81)
        Me.txtItemQnty.Name = "txtItemQnty"
        Me.txtItemQnty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemQnty.Radius = 10
        Me.txtItemQnty.SelectedText = ""
        Me.txtItemQnty.Size = New System.Drawing.Size(142, 26)
        Me.txtItemQnty.TabIndex = 92
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.Transparent
        Me.txtItemName.BaseColor = System.Drawing.Color.White
        Me.txtItemName.BorderColor = System.Drawing.Color.Silver
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtItemName.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemName.Location = New System.Drawing.Point(102, 81)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.Radius = 10
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(185, 26)
        Me.txtItemName.TabIndex = 91
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemPrice.Location = New System.Drawing.Point(293, 88)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(60, 19)
        Me.lblItemPrice.TabIndex = 90
        Me.lblItemPrice.Text = "Quantity"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemName.Location = New System.Drawing.Point(52, 88)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(46, 19)
        Me.lblItemName.TabIndex = 89
        Me.lblItemName.Text = "Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(363, 12)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(127, 24)
        Me.GunaLabel2.TabIndex = 88
        Me.GunaLabel2.Text = "Stock Details"
        '
        'txtStockID
        '
        Me.txtStockID.BackColor = System.Drawing.Color.Transparent
        Me.txtStockID.BaseColor = System.Drawing.Color.White
        Me.txtStockID.BorderColor = System.Drawing.Color.Silver
        Me.txtStockID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStockID.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtStockID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStockID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStockID.Location = New System.Drawing.Point(354, 134)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStockID.Radius = 10
        Me.txtStockID.SelectedText = ""
        Me.txtStockID.Size = New System.Drawing.Size(185, 26)
        Me.txtStockID.TabIndex = 101
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel3.Location = New System.Drawing.Point(290, 141)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(60, 19)
        Me.GunaLabel3.TabIndex = 100
        Me.GunaLabel3.Text = "Item_ID"
        '
        'Stock_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 608)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgvStockDet)
        Me.Controls.Add(Me.btnClearItem)
        Me.Controls.Add(Me.btnDelItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtItemQnty)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stock_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock_Details"
        CType(Me.dgvStockDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvStockDet As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtItemQnty As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtItemName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblItemPrice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblItemName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtStockID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
