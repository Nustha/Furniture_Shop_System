<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnAdminLogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManageorder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStockdetail = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEmployeeDetails = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBillingStatement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnItementry = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.gpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel2)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminLogOut)
        Me.Guna2Panel1.Controls.Add(Me.btnManageorder)
        Me.Guna2Panel1.Controls.Add(Me.btnStockdetail)
        Me.Guna2Panel1.Controls.Add(Me.btnEmployeeDetails)
        Me.Guna2Panel1.Controls.Add(Me.btnBillingStatement)
        Me.Guna2Panel1.Controls.Add(Me.btnItementry)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(228, 625)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(30, 82)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(180, 22)
        Me.GunaLabel2.TabIndex = 49
        Me.GunaLabel2.Text = "FURNITURE SHOP"
        '
        'btnAdminLogOut
        '
        Me.btnAdminLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminLogOut.BorderRadius = 22
        Me.btnAdminLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAdminLogOut.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnAdminLogOut.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnAdminLogOut.CheckedState.Parent = Me.btnAdminLogOut
        Me.btnAdminLogOut.CustomImages.Parent = Me.btnAdminLogOut
        Me.btnAdminLogOut.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnAdminLogOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogOut.ForeColor = System.Drawing.Color.White
        Me.btnAdminLogOut.HoverState.Parent = Me.btnAdminLogOut
        Me.btnAdminLogOut.Image = CType(resources.GetObject("btnAdminLogOut.Image"), System.Drawing.Image)
        Me.btnAdminLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminLogOut.Location = New System.Drawing.Point(14, 527)
        Me.btnAdminLogOut.Name = "btnAdminLogOut"
        Me.btnAdminLogOut.ShadowDecoration.Parent = Me.btnAdminLogOut
        Me.btnAdminLogOut.Size = New System.Drawing.Size(195, 43)
        Me.btnAdminLogOut.TabIndex = 9
        Me.btnAdminLogOut.Text = "Log Out"
        Me.btnAdminLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminLogOut.UseTransparentBackground = True
        '
        'btnManageorder
        '
        Me.btnManageorder.BackColor = System.Drawing.Color.Transparent
        Me.btnManageorder.BorderRadius = 22
        Me.btnManageorder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnManageorder.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnManageorder.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnManageorder.CheckedState.Parent = Me.btnManageorder
        Me.btnManageorder.CustomImages.Parent = Me.btnManageorder
        Me.btnManageorder.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnManageorder.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageorder.ForeColor = System.Drawing.Color.White
        Me.btnManageorder.HoverState.Parent = Me.btnManageorder
        Me.btnManageorder.Image = CType(resources.GetObject("btnManageorder.Image"), System.Drawing.Image)
        Me.btnManageorder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManageorder.Location = New System.Drawing.Point(15, 456)
        Me.btnManageorder.Name = "btnManageorder"
        Me.btnManageorder.ShadowDecoration.Parent = Me.btnManageorder
        Me.btnManageorder.Size = New System.Drawing.Size(195, 43)
        Me.btnManageorder.TabIndex = 8
        Me.btnManageorder.Text = "Manage Order"
        Me.btnManageorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManageorder.UseTransparentBackground = True
        '
        'btnStockdetail
        '
        Me.btnStockdetail.BackColor = System.Drawing.Color.Transparent
        Me.btnStockdetail.BorderRadius = 22
        Me.btnStockdetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnStockdetail.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnStockdetail.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnStockdetail.CheckedState.Parent = Me.btnStockdetail
        Me.btnStockdetail.CustomImages.Parent = Me.btnStockdetail
        Me.btnStockdetail.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnStockdetail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockdetail.ForeColor = System.Drawing.Color.White
        Me.btnStockdetail.HoverState.Parent = Me.btnStockdetail
        Me.btnStockdetail.Image = CType(resources.GetObject("btnStockdetail.Image"), System.Drawing.Image)
        Me.btnStockdetail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStockdetail.Location = New System.Drawing.Point(13, 383)
        Me.btnStockdetail.Name = "btnStockdetail"
        Me.btnStockdetail.ShadowDecoration.Parent = Me.btnStockdetail
        Me.btnStockdetail.Size = New System.Drawing.Size(195, 43)
        Me.btnStockdetail.TabIndex = 7
        Me.btnStockdetail.Text = "Stock Details"
        Me.btnStockdetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStockdetail.UseTransparentBackground = True
        '
        'btnEmployeeDetails
        '
        Me.btnEmployeeDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployeeDetails.BorderRadius = 22
        Me.btnEmployeeDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnEmployeeDetails.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnEmployeeDetails.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnEmployeeDetails.CheckedState.Parent = Me.btnEmployeeDetails
        Me.btnEmployeeDetails.CustomImages.Parent = Me.btnEmployeeDetails
        Me.btnEmployeeDetails.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnEmployeeDetails.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDetails.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeDetails.HoverState.Parent = Me.btnEmployeeDetails
        Me.btnEmployeeDetails.Image = CType(resources.GetObject("btnEmployeeDetails.Image"), System.Drawing.Image)
        Me.btnEmployeeDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEmployeeDetails.Location = New System.Drawing.Point(15, 303)
        Me.btnEmployeeDetails.Name = "btnEmployeeDetails"
        Me.btnEmployeeDetails.ShadowDecoration.Parent = Me.btnEmployeeDetails
        Me.btnEmployeeDetails.Size = New System.Drawing.Size(195, 43)
        Me.btnEmployeeDetails.TabIndex = 5
        Me.btnEmployeeDetails.Text = "Employee Details"
        Me.btnEmployeeDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEmployeeDetails.UseTransparentBackground = True
        '
        'btnBillingStatement
        '
        Me.btnBillingStatement.BackColor = System.Drawing.Color.Transparent
        Me.btnBillingStatement.BorderRadius = 22
        Me.btnBillingStatement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnBillingStatement.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnBillingStatement.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnBillingStatement.CheckedState.Parent = Me.btnBillingStatement
        Me.btnBillingStatement.CustomImages.Parent = Me.btnBillingStatement
        Me.btnBillingStatement.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnBillingStatement.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingStatement.ForeColor = System.Drawing.Color.White
        Me.btnBillingStatement.HoverState.Parent = Me.btnBillingStatement
        Me.btnBillingStatement.Image = CType(resources.GetObject("btnBillingStatement.Image"), System.Drawing.Image)
        Me.btnBillingStatement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBillingStatement.Location = New System.Drawing.Point(14, 229)
        Me.btnBillingStatement.Name = "btnBillingStatement"
        Me.btnBillingStatement.ShadowDecoration.Parent = Me.btnBillingStatement
        Me.btnBillingStatement.Size = New System.Drawing.Size(195, 43)
        Me.btnBillingStatement.TabIndex = 3
        Me.btnBillingStatement.Text = "Billing Statement"
        Me.btnBillingStatement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBillingStatement.UseTransparentBackground = True
        '
        'btnItementry
        '
        Me.btnItementry.BackColor = System.Drawing.Color.Transparent
        Me.btnItementry.BorderRadius = 22
        Me.btnItementry.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnItementry.Checked = True
        Me.btnItementry.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnItementry.CheckedState.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btnItementry.CheckedState.Parent = Me.btnItementry
        Me.btnItementry.CustomImages.Parent = Me.btnItementry
        Me.btnItementry.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnItementry.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItementry.ForeColor = System.Drawing.Color.White
        Me.btnItementry.HoverState.Parent = Me.btnItementry
        Me.btnItementry.Image = CType(resources.GetObject("btnItementry.Image"), System.Drawing.Image)
        Me.btnItementry.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnItementry.Location = New System.Drawing.Point(15, 152)
        Me.btnItementry.Name = "btnItementry"
        Me.btnItementry.ShadowDecoration.Parent = Me.btnItementry
        Me.btnItementry.Size = New System.Drawing.Size(195, 43)
        Me.btnItementry.TabIndex = 1
        Me.btnItementry.Text = "Item Entry"
        Me.btnItementry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnItementry.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(80, 23)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(58, 56)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'gpanel
        '
        Me.gpanel.Location = New System.Drawing.Point(219, 8)
        Me.gpanel.Name = "gpanel"
        Me.gpanel.ShadowDecoration.Parent = Me.gpanel
        Me.gpanel.Size = New System.Drawing.Size(844, 608)
        Me.gpanel.TabIndex = 1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        Me.Guna2Elipse2.TargetControl = Me.gpanel
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1072, 625)
        Me.Controls.Add(Me.gpanel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnItementry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnStockdetail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEmployeeDetails As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBillingStatement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManageorder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminLogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
