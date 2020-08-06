<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageBooks))
        Me.managebook_title = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_book_id = New System.Windows.Forms.TextBox()
        Me.book_id = New System.Windows.Forms.Label()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.tb_copy_price = New System.Windows.Forms.TextBox()
        Me.copy_price = New System.Windows.Forms.Label()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.tb_rack_no = New System.Windows.Forms.TextBox()
        Me.rack_no = New System.Windows.Forms.Label()
        Me.ComboBox_category = New System.Windows.Forms.ComboBox()
        Me.category = New System.Windows.Forms.Label()
        Me.tb_publisher_name = New System.Windows.Forms.TextBox()
        Me.tb_publish_year = New System.Windows.Forms.TextBox()
        Me.publisher_name = New System.Windows.Forms.Label()
        Me.publish_year = New System.Windows.Forms.Label()
        Me.tb_author_name = New System.Windows.Forms.TextBox()
        Me.author_name = New System.Windows.Forms.Label()
        Me.tb_book_title = New System.Windows.Forms.TextBox()
        Me.book_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'managebook_title
        '
        Me.managebook_title.AutoSize = True
        Me.managebook_title.BackColor = System.Drawing.Color.Olive
        Me.managebook_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managebook_title.ForeColor = System.Drawing.SystemColors.Control
        Me.managebook_title.Location = New System.Drawing.Point(21, 22)
        Me.managebook_title.Name = "managebook_title"
        Me.managebook_title.Size = New System.Drawing.Size(244, 39)
        Me.managebook_title.TabIndex = 18
        Me.managebook_title.Text = "Manage Books"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.tb_book_id)
        Me.GroupBox1.Controls.Add(Me.book_id)
        Me.GroupBox1.Controls.Add(Me.bt_delete)
        Me.GroupBox1.Controls.Add(Me.tb_copy_price)
        Me.GroupBox1.Controls.Add(Me.copy_price)
        Me.GroupBox1.Controls.Add(Me.bt_close)
        Me.GroupBox1.Controls.Add(Me.bt_update)
        Me.GroupBox1.Controls.Add(Me.tb_rack_no)
        Me.GroupBox1.Controls.Add(Me.rack_no)
        Me.GroupBox1.Controls.Add(Me.ComboBox_category)
        Me.GroupBox1.Controls.Add(Me.category)
        Me.GroupBox1.Controls.Add(Me.tb_publisher_name)
        Me.GroupBox1.Controls.Add(Me.tb_publish_year)
        Me.GroupBox1.Controls.Add(Me.publisher_name)
        Me.GroupBox1.Controls.Add(Me.publish_year)
        Me.GroupBox1.Controls.Add(Me.tb_author_name)
        Me.GroupBox1.Controls.Add(Me.author_name)
        Me.GroupBox1.Controls.Add(Me.tb_book_title)
        Me.GroupBox1.Controls.Add(Me.book_title)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(619, 494)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'tb_book_id
        '
        Me.tb_book_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_id.Location = New System.Drawing.Point(263, 42)
        Me.tb_book_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_book_id.Name = "tb_book_id"
        Me.tb_book_id.Size = New System.Drawing.Size(321, 30)
        Me.tb_book_id.TabIndex = 23
        '
        'book_id
        '
        Me.book_id.AutoSize = True
        Me.book_id.BackColor = System.Drawing.Color.Transparent
        Me.book_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.book_id.Location = New System.Drawing.Point(47, 46)
        Me.book_id.Name = "book_id"
        Me.book_id.Size = New System.Drawing.Size(87, 25)
        Me.book_id.TabIndex = 22
        Me.book_id.Text = "Book ID:"
        '
        'bt_delete
        '
        Me.bt_delete.BackColor = System.Drawing.Color.Khaki
        Me.bt_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_delete.Location = New System.Drawing.Point(224, 423)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(181, 52)
        Me.bt_delete.TabIndex = 18
        Me.bt_delete.Text = "Delete"
        Me.bt_delete.UseVisualStyleBackColor = False
        '
        'tb_copy_price
        '
        Me.tb_copy_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_copy_price.Location = New System.Drawing.Point(263, 347)
        Me.tb_copy_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_copy_price.Name = "tb_copy_price"
        Me.tb_copy_price.Size = New System.Drawing.Size(321, 30)
        Me.tb_copy_price.TabIndex = 17
        '
        'copy_price
        '
        Me.copy_price.AutoSize = True
        Me.copy_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copy_price.Location = New System.Drawing.Point(47, 348)
        Me.copy_price.Name = "copy_price"
        Me.copy_price.Size = New System.Drawing.Size(142, 25)
        Me.copy_price.TabIndex = 16
        Me.copy_price.Text = "Price per copy:"
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Khaki
        Me.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.Location = New System.Drawing.Point(411, 423)
        Me.bt_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(181, 52)
        Me.bt_close.TabIndex = 15
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt_update
        '
        Me.bt_update.BackColor = System.Drawing.Color.Khaki
        Me.bt_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_update.Location = New System.Drawing.Point(37, 423)
        Me.bt_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(181, 52)
        Me.bt_update.TabIndex = 14
        Me.bt_update.Text = "Update"
        Me.bt_update.UseVisualStyleBackColor = False
        '
        'tb_rack_no
        '
        Me.tb_rack_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rack_no.Location = New System.Drawing.Point(263, 304)
        Me.tb_rack_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_rack_no.Name = "tb_rack_no"
        Me.tb_rack_no.Size = New System.Drawing.Size(321, 30)
        Me.tb_rack_no.TabIndex = 11
        '
        'rack_no
        '
        Me.rack_no.AutoSize = True
        Me.rack_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rack_no.Location = New System.Drawing.Point(48, 306)
        Me.rack_no.Name = "rack_no"
        Me.rack_no.Size = New System.Drawing.Size(97, 25)
        Me.rack_no.TabIndex = 10
        Me.rack_no.Text = "Rack No.:"
        '
        'ComboBox_category
        '
        Me.ComboBox_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_category.FormattingEnabled = True
        Me.ComboBox_category.Location = New System.Drawing.Point(263, 258)
        Me.ComboBox_category.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_category.Name = "ComboBox_category"
        Me.ComboBox_category.Size = New System.Drawing.Size(321, 33)
        Me.ComboBox_category.TabIndex = 9
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.Location = New System.Drawing.Point(47, 260)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(98, 25)
        Me.category.TabIndex = 8
        Me.category.Text = "Category:"
        '
        'tb_publisher_name
        '
        Me.tb_publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_publisher_name.Location = New System.Drawing.Point(263, 214)
        Me.tb_publisher_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_publisher_name.Name = "tb_publisher_name"
        Me.tb_publisher_name.Size = New System.Drawing.Size(321, 30)
        Me.tb_publisher_name.TabIndex = 7
        '
        'tb_publish_year
        '
        Me.tb_publish_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_publish_year.Location = New System.Drawing.Point(263, 170)
        Me.tb_publish_year.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_publish_year.Name = "tb_publish_year"
        Me.tb_publish_year.Size = New System.Drawing.Size(321, 30)
        Me.tb_publish_year.TabIndex = 6
        '
        'publisher_name
        '
        Me.publisher_name.AutoSize = True
        Me.publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_name.Location = New System.Drawing.Point(47, 214)
        Me.publisher_name.Name = "publisher_name"
        Me.publisher_name.Size = New System.Drawing.Size(156, 25)
        Me.publisher_name.TabIndex = 5
        Me.publisher_name.Text = "Publisher Name:"
        '
        'publish_year
        '
        Me.publish_year.AutoSize = True
        Me.publish_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publish_year.Location = New System.Drawing.Point(47, 171)
        Me.publish_year.Name = "publish_year"
        Me.publish_year.Size = New System.Drawing.Size(159, 25)
        Me.publish_year.TabIndex = 4
        Me.publish_year.Text = "Publication Year:"
        '
        'tb_author_name
        '
        Me.tb_author_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_author_name.Location = New System.Drawing.Point(263, 126)
        Me.tb_author_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_author_name.Name = "tb_author_name"
        Me.tb_author_name.Size = New System.Drawing.Size(321, 30)
        Me.tb_author_name.TabIndex = 3
        '
        'author_name
        '
        Me.author_name.AutoSize = True
        Me.author_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_name.Location = New System.Drawing.Point(47, 126)
        Me.author_name.Name = "author_name"
        Me.author_name.Size = New System.Drawing.Size(133, 25)
        Me.author_name.TabIndex = 2
        Me.author_name.Text = "Author Name:"
        '
        'tb_book_title
        '
        Me.tb_book_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_title.Location = New System.Drawing.Point(263, 82)
        Me.tb_book_title.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_book_title.Name = "tb_book_title"
        Me.tb_book_title.Size = New System.Drawing.Size(321, 30)
        Me.tb_book_title.TabIndex = 1
        '
        'book_title
        '
        Me.book_title.AutoSize = True
        Me.book_title.BackColor = System.Drawing.Color.Transparent
        Me.book_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_title.Location = New System.Drawing.Point(47, 84)
        Me.book_title.Name = "book_title"
        Me.book_title.Size = New System.Drawing.Size(105, 25)
        Me.book_title.TabIndex = 0
        Me.book_title.Text = "Book Title:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Olive
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(619, 69)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(636, 578)
        Me.Controls.Add(Me.managebook_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ManageBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageBooks"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents managebook_title As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_copy_price As TextBox
    Friend WithEvents copy_price As Label
    Friend WithEvents bt_close As Button
    Friend WithEvents bt_update As Button
    Friend WithEvents tb_rack_no As TextBox
    Friend WithEvents rack_no As Label
    Friend WithEvents ComboBox_category As ComboBox
    Friend WithEvents category As Label
    Friend WithEvents tb_publisher_name As TextBox
    Friend WithEvents tb_publish_year As TextBox
    Friend WithEvents publisher_name As Label
    Friend WithEvents publish_year As Label
    Friend WithEvents tb_author_name As TextBox
    Friend WithEvents author_name As Label
    Friend WithEvents tb_book_title As TextBox
    Friend WithEvents book_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_delete As Button
    Friend WithEvents tb_book_id As TextBox
    Friend WithEvents book_id As Label
End Class
