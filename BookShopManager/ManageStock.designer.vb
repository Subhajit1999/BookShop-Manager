<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manage_stock))
        Me.tb_enter_id = New System.Windows.Forms.TextBox()
        Me.enter_id = New System.Windows.Forms.Label()
        Me.no_of_copies = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.tb_no_of_copies = New System.Windows.Forms.TextBox()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.managebook_title = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_enter_id
        '
        Me.tb_enter_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_enter_id.Location = New System.Drawing.Point(156, 36)
        Me.tb_enter_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_enter_id.Multiline = True
        Me.tb_enter_id.Name = "tb_enter_id"
        Me.tb_enter_id.Size = New System.Drawing.Size(221, 34)
        Me.tb_enter_id.TabIndex = 4
        '
        'enter_id
        '
        Me.enter_id.AutoSize = True
        Me.enter_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enter_id.Location = New System.Drawing.Point(5, 39)
        Me.enter_id.Name = "enter_id"
        Me.enter_id.Size = New System.Drawing.Size(138, 25)
        Me.enter_id.TabIndex = 5
        Me.enter_id.Text = "Enter Book ID:"
        '
        'no_of_copies
        '
        Me.no_of_copies.AutoSize = True
        Me.no_of_copies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_of_copies.Location = New System.Drawing.Point(8, 164)
        Me.no_of_copies.Name = "no_of_copies"
        Me.no_of_copies.Size = New System.Drawing.Size(136, 25)
        Me.no_of_copies.TabIndex = 8
        Me.no_of_copies.Text = "No. of Copies:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Olive
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.bt_close)
        Me.GroupBox1.Controls.Add(Me.bt_delete)
        Me.GroupBox1.Controls.Add(Me.bt_update)
        Me.GroupBox1.Controls.Add(Me.bt_add)
        Me.GroupBox1.Controls.Add(Me.tb_no_of_copies)
        Me.GroupBox1.Controls.Add(Me.bt_search)
        Me.GroupBox1.Controls.Add(Me.no_of_copies)
        Me.GroupBox1.Controls.Add(Me.enter_id)
        Me.GroupBox1.Controls.Add(Me.tb_enter_id)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 71)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(459, 283)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Khaki
        Me.bt_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.Location = New System.Drawing.Point(344, 214)
        Me.bt_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(104, 52)
        Me.bt_close.TabIndex = 20
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt_delete
        '
        Me.bt_delete.BackColor = System.Drawing.Color.Khaki
        Me.bt_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_delete.Location = New System.Drawing.Point(235, 214)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(104, 52)
        Me.bt_delete.TabIndex = 19
        Me.bt_delete.Text = "Delete"
        Me.bt_delete.UseVisualStyleBackColor = False
        '
        'bt_update
        '
        Me.bt_update.BackColor = System.Drawing.Color.Khaki
        Me.bt_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_update.Location = New System.Drawing.Point(123, 214)
        Me.bt_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(104, 52)
        Me.bt_update.TabIndex = 18
        Me.bt_update.Text = "Update"
        Me.bt_update.UseVisualStyleBackColor = False
        '
        'bt_add
        '
        Me.bt_add.BackColor = System.Drawing.Color.Khaki
        Me.bt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.Location = New System.Drawing.Point(13, 214)
        Me.bt_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(104, 52)
        Me.bt_add.TabIndex = 17
        Me.bt_add.Text = "Add"
        Me.bt_add.UseVisualStyleBackColor = False
        '
        'tb_no_of_copies
        '
        Me.tb_no_of_copies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_of_copies.Location = New System.Drawing.Point(159, 160)
        Me.tb_no_of_copies.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_no_of_copies.Multiline = True
        Me.tb_no_of_copies.Name = "tb_no_of_copies"
        Me.tb_no_of_copies.Size = New System.Drawing.Size(221, 34)
        Me.tb_no_of_copies.TabIndex = 16
        '
        'bt_search
        '
        Me.bt_search.BackColor = System.Drawing.Color.Khaki
        Me.bt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search.Location = New System.Drawing.Point(156, 75)
        Me.bt_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(104, 52)
        Me.bt_search.TabIndex = 15
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = False
        '
        'managebook_title
        '
        Me.managebook_title.AutoSize = True
        Me.managebook_title.BackColor = System.Drawing.Color.Olive
        Me.managebook_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managebook_title.ForeColor = System.Drawing.SystemColors.Control
        Me.managebook_title.Location = New System.Drawing.Point(13, 18)
        Me.managebook_title.Name = "managebook_title"
        Me.managebook_title.Size = New System.Drawing.Size(234, 39)
        Me.managebook_title.TabIndex = 21
        Me.managebook_title.Text = "Manage Stock"
        '
        'Manage_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(475, 362)
        Me.Controls.Add(Me.managebook_title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Manage_stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Stock"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_enter_id As System.Windows.Forms.TextBox
    Friend WithEvents enter_id As System.Windows.Forms.Label
    Friend WithEvents no_of_copies As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_search As Button
    Friend WithEvents bt_close As Button
    Friend WithEvents bt_delete As Button
    Friend WithEvents bt_update As Button
    Friend WithEvents bt_add As Button
    Friend WithEvents tb_no_of_copies As TextBox
    Friend WithEvents managebook_title As Label
End Class
