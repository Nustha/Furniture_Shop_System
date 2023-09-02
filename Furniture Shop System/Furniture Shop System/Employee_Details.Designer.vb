<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Details
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
        Me.txtEmpPosition = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvEmpDetail = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClearEmp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelEmp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditEmp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddEmp = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmpName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtEmpID = New Guna.UI.WinForms.GunaTextBox()
        Me.lblItemPrice = New Guna.UI.WinForms.GunaLabel()
        Me.lblItemName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtEmpPhoneno = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtEmpDescribe = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.dgvEmpDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtEmpPosition
        '
        Me.txtEmpPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpPosition.BaseColor = System.Drawing.Color.White
        Me.txtEmpPosition.BorderColor = System.Drawing.Color.Silver
        Me.txtEmpPosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpPosition.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmpPosition.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtEmpPosition.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpPosition.Location = New System.Drawing.Point(171, 154)
        Me.txtEmpPosition.Name = "txtEmpPosition"
        Me.txtEmpPosition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpPosition.Radius = 10
        Me.txtEmpPosition.SelectedText = ""
        Me.txtEmpPosition.Size = New System.Drawing.Size(185, 26)
        Me.txtEmpPosition.TabIndex = 115
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel3.Location = New System.Drawing.Point(34, 103)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(65, 19)
        Me.GunaLabel3.TabIndex = 114
        Me.GunaLabel3.Text = "EMP_ID"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel1.Location = New System.Drawing.Point(559, 103)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(71, 19)
        Me.GunaLabel1.TabIndex = 112
        Me.GunaLabel1.Text = "Phone No"
        '
        'dgvEmpDetail
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvEmpDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmpDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmpDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEmpDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpDetail.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpDetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpDetail.EnableHeadersVisualStyles = False
        Me.dgvEmpDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmpDetail.Location = New System.Drawing.Point(64, 279)
        Me.dgvEmpDetail.Name = "dgvEmpDetail"
        Me.dgvEmpDetail.RowHeadersVisible = False
        Me.dgvEmpDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpDetail.Size = New System.Drawing.Size(706, 297)
        Me.dgvEmpDetail.TabIndex = 111
        Me.dgvEmpDetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvEmpDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEmpDetail.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEmpDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvEmpDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvEmpDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvEmpDetail.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvEmpDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvEmpDetail.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvEmpDetail.ThemeStyle.ReadOnly = False
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.Height = 22
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.dgvEmpDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnClearEmp
        '
        Me.btnClearEmp.BorderColor = System.Drawing.Color.White
        Me.btnClearEmp.BorderRadius = 20
        Me.btnClearEmp.CheckedState.Parent = Me.btnClearEmp
        Me.btnClearEmp.CustomBorderColor = System.Drawing.Color.White
        Me.btnClearEmp.CustomImages.Parent = Me.btnClearEmp
        Me.btnClearEmp.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearEmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEmp.ForeColor = System.Drawing.Color.White
        Me.btnClearEmp.HoverState.Parent = Me.btnClearEmp
        Me.btnClearEmp.Location = New System.Drawing.Point(559, 209)
        Me.btnClearEmp.Name = "btnClearEmp"
        Me.btnClearEmp.ShadowDecoration.Parent = Me.btnClearEmp
        Me.btnClearEmp.Size = New System.Drawing.Size(90, 34)
        Me.btnClearEmp.TabIndex = 110
        Me.btnClearEmp.Text = "Clear"
        '
        'btnDelEmp
        '
        Me.btnDelEmp.BorderColor = System.Drawing.Color.White
        Me.btnDelEmp.BorderRadius = 20
        Me.btnDelEmp.CheckedState.Parent = Me.btnDelEmp
        Me.btnDelEmp.CustomBorderColor = System.Drawing.Color.White
        Me.btnDelEmp.CustomImages.Parent = Me.btnDelEmp
        Me.btnDelEmp.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelEmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.ForeColor = System.Drawing.Color.White
        Me.btnDelEmp.HoverState.Parent = Me.btnDelEmp
        Me.btnDelEmp.Location = New System.Drawing.Point(443, 209)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.ShadowDecoration.Parent = Me.btnDelEmp
        Me.btnDelEmp.Size = New System.Drawing.Size(90, 34)
        Me.btnDelEmp.TabIndex = 109
        Me.btnDelEmp.Text = "Delete"
        '
        'btnEditEmp
        '
        Me.btnEditEmp.BorderColor = System.Drawing.Color.White
        Me.btnEditEmp.BorderRadius = 20
        Me.btnEditEmp.CheckedState.Parent = Me.btnEditEmp
        Me.btnEditEmp.CustomBorderColor = System.Drawing.Color.White
        Me.btnEditEmp.CustomImages.Parent = Me.btnEditEmp
        Me.btnEditEmp.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditEmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEmp.ForeColor = System.Drawing.Color.White
        Me.btnEditEmp.HoverState.Parent = Me.btnEditEmp
        Me.btnEditEmp.Location = New System.Drawing.Point(328, 210)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.ShadowDecoration.Parent = Me.btnEditEmp
        Me.btnEditEmp.Size = New System.Drawing.Size(90, 34)
        Me.btnEditEmp.TabIndex = 108
        Me.btnEditEmp.Text = "Edit"
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BorderColor = System.Drawing.Color.White
        Me.btnAddEmp.BorderRadius = 20
        Me.btnAddEmp.CheckedState.Parent = Me.btnAddEmp
        Me.btnAddEmp.CustomBorderColor = System.Drawing.Color.White
        Me.btnAddEmp.CustomImages.Parent = Me.btnAddEmp
        Me.btnAddEmp.FillColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddEmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.White
        Me.btnAddEmp.HoverState.Parent = Me.btnAddEmp
        Me.btnAddEmp.Location = New System.Drawing.Point(210, 209)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.ShadowDecoration.Parent = Me.btnAddEmp
        Me.btnAddEmp.Size = New System.Drawing.Size(90, 34)
        Me.btnAddEmp.TabIndex = 107
        Me.btnAddEmp.Text = "Add"
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpName.BaseColor = System.Drawing.Color.White
        Me.txtEmpName.BorderColor = System.Drawing.Color.Silver
        Me.txtEmpName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmpName.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtEmpName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpName.Location = New System.Drawing.Point(362, 101)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpName.Radius = 10
        Me.txtEmpName.SelectedText = ""
        Me.txtEmpName.Size = New System.Drawing.Size(185, 26)
        Me.txtEmpName.TabIndex = 106
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpID.BaseColor = System.Drawing.Color.White
        Me.txtEmpID.BorderColor = System.Drawing.Color.Silver
        Me.txtEmpID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmpID.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtEmpID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpID.Location = New System.Drawing.Point(105, 101)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpID.Radius = 10
        Me.txtEmpID.SelectedText = ""
        Me.txtEmpID.Size = New System.Drawing.Size(124, 26)
        Me.txtEmpID.TabIndex = 105
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemPrice.Location = New System.Drawing.Point(105, 160)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(57, 19)
        Me.lblItemPrice.TabIndex = 104
        Me.lblItemPrice.Text = "Position"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblItemName.Location = New System.Drawing.Point(248, 103)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(110, 19)
        Me.lblItemName.TabIndex = 103
        Me.lblItemName.Text = "Employee Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(352, 32)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(164, 24)
        Me.GunaLabel2.TabIndex = 102
        Me.GunaLabel2.Text = "Employee Details"
        '
        'txtEmpPhoneno
        '
        Me.txtEmpPhoneno.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpPhoneno.BaseColor = System.Drawing.Color.White
        Me.txtEmpPhoneno.BorderColor = System.Drawing.Color.Silver
        Me.txtEmpPhoneno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpPhoneno.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmpPhoneno.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtEmpPhoneno.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpPhoneno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpPhoneno.Location = New System.Drawing.Point(637, 103)
        Me.txtEmpPhoneno.Name = "txtEmpPhoneno"
        Me.txtEmpPhoneno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpPhoneno.Radius = 10
        Me.txtEmpPhoneno.SelectedText = ""
        Me.txtEmpPhoneno.Size = New System.Drawing.Size(167, 26)
        Me.txtEmpPhoneno.TabIndex = 116
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GunaLabel4.Location = New System.Drawing.Point(396, 160)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(78, 19)
        Me.GunaLabel4.TabIndex = 117
        Me.GunaLabel4.Text = "Description"
        '
        'txtEmpDescribe
        '
        Me.txtEmpDescribe.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpDescribe.BaseColor = System.Drawing.Color.White
        Me.txtEmpDescribe.BorderColor = System.Drawing.Color.Silver
        Me.txtEmpDescribe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpDescribe.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmpDescribe.FocusedBorderColor = System.Drawing.Color.LightSeaGreen
        Me.txtEmpDescribe.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpDescribe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpDescribe.Location = New System.Drawing.Point(492, 154)
        Me.txtEmpDescribe.Name = "txtEmpDescribe"
        Me.txtEmpDescribe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpDescribe.Radius = 10
        Me.txtEmpDescribe.SelectedText = ""
        Me.txtEmpDescribe.Size = New System.Drawing.Size(265, 26)
        Me.txtEmpDescribe.TabIndex = 118
        '
        'Employee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 608)
        Me.Controls.Add(Me.txtEmpDescribe)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtEmpPhoneno)
        Me.Controls.Add(Me.txtEmpPosition)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgvEmpDetail)
        Me.Controls.Add(Me.btnClearEmp)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnEditEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Details"
        CType(Me.dgvEmpDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtEmpPosition As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvEmpDetail As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClearEmp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelEmp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditEmp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddEmp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmpName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEmpID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblItemPrice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblItemName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtEmpPhoneno As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEmpDescribe As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
