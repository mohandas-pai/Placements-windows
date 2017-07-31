<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerpage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderPlacedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeeProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdersToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderStatusToolStripMenuItem, Me.OrderPlacedToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'OrderStatusToolStripMenuItem
        '
        Me.OrderStatusToolStripMenuItem.Name = "OrderStatusToolStripMenuItem"
        Me.OrderStatusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderStatusToolStripMenuItem.Text = "Order Status"
        '
        'OrderPlacedToolStripMenuItem
        '
        Me.OrderPlacedToolStripMenuItem.Name = "OrderPlacedToolStripMenuItem"
        Me.OrderPlacedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderPlacedToolStripMenuItem.Text = "Order Placed"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeeProfileToolStripMenuItem, Me.EditProfileToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'SeeProfileToolStripMenuItem
        '
        Me.SeeProfileToolStripMenuItem.Name = "SeeProfileToolStripMenuItem"
        Me.SeeProfileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SeeProfileToolStripMenuItem.Text = "See Profile"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'customerpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.shopping_cart_ecommerce_keyboard_ss_1920
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 524)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "customerpage"
        Me.Text = "customerpage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderPlacedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeeProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
