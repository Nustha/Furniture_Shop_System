<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnAdmin = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnSeller = New Guna.UI.WinForms.GunaGradientButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnLogExit = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(328, -1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(369, 504)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(133, 73)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(81, 29)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Login"
        '
        'btnAdmin
        '
        Me.btnAdmin.AnimationHoverSpeed = 0.07!
        Me.btnAdmin.AnimationSpeed = 0.03!
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdmin.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdmin.BorderColor = System.Drawing.Color.Black
        Me.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdmin.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdmin.Location = New System.Drawing.Point(72, 154)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAdmin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdmin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdmin.OnHoverImage = Nothing
        Me.btnAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdmin.Radius = 10
        Me.btnAdmin.Size = New System.Drawing.Size(188, 39)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Admin"
        '
        'btnSeller
        '
        Me.btnSeller.AnimationHoverSpeed = 0.07!
        Me.btnSeller.AnimationSpeed = 0.03!
        Me.btnSeller.BackColor = System.Drawing.Color.Transparent
        Me.btnSeller.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSeller.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSeller.BorderColor = System.Drawing.Color.Black
        Me.btnSeller.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSeller.FocusedColor = System.Drawing.Color.Empty
        Me.btnSeller.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeller.ForeColor = System.Drawing.Color.White
        Me.btnSeller.Image = CType(resources.GetObject("btnSeller.Image"), System.Drawing.Image)
        Me.btnSeller.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSeller.Location = New System.Drawing.Point(72, 237)
        Me.btnSeller.Name = "btnSeller"
        Me.btnSeller.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSeller.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSeller.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSeller.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSeller.OnHoverImage = Nothing
        Me.btnSeller.OnPressedColor = System.Drawing.Color.Black
        Me.btnSeller.Radius = 10
        Me.btnSeller.Size = New System.Drawing.Size(188, 39)
        Me.btnSeller.TabIndex = 3
        Me.btnSeller.Text = "Seller"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnLogExit
        '
        Me.btnLogExit.CheckedState.Parent = Me.btnLogExit
        Me.btnLogExit.CustomImages.Parent = Me.btnLogExit
        Me.btnLogExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogExit.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogExit.ForeColor = System.Drawing.Color.White
        Me.btnLogExit.HoverState.Parent = Me.btnLogExit
        Me.btnLogExit.Location = New System.Drawing.Point(62, 440)
        Me.btnLogExit.Name = "btnLogExit"
        Me.btnLogExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnLogExit.ShadowDecoration.Parent = Me.btnLogExit
        Me.btnLogExit.Size = New System.Drawing.Size(198, 33)
        Me.btnLogExit.TabIndex = 4
        Me.btnLogExit.Text = "Exit"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 501)
        Me.Controls.Add(Me.btnLogExit)
        Me.Controls.Add(Me.btnSeller)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnAdmin As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnSeller As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnLogExit As Guna.UI2.WinForms.Guna2CircleButton
End Class
