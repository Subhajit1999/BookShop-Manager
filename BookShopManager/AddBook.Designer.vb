<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBook))
        Me.addbook_title = New System.Windows.Forms.Label()
        Me.titlebar_addbook = New System.Windows.Forms.PictureBox()
        Me.GroupBox_addbook = New System.Windows.Forms.GroupBox()
        Me.tb_book_id = New System.Windows.Forms.TextBox()
        Me.book_id = New System.Windows.Forms.Label()
        Me.tb_copy_price = New System.Windows.Forms.TextBox()
        Me.copy_price = New System.Windows.Forms.Label()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bt_add_stock = New System.Windows.Forms.Button()
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
        CType(Me.titlebar_addbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_addbook.SuspendLayout()
        Me.SuspendLayout()
        '
        'addbook_title
        '
        Me.addbook_title.AutoSize = True
        Me.addbook_title.BackColor = System.Drawing.Color.Olive
        Me.addbook_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbook_title.ForeColor = System.Drawing.SystemColors.Control
        Me.addbook_title.Location = New System.Drawing.Point(29, 25)
        Me.addbook_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addbook_title.Name = "addbook_title"
        Me.addbook_title.Size = New System.Drawing.Size(260, 39)
        Me.addbook_title.TabIndex = 3
        Me.addbook_title.Text = "Add New Books"
        '
        'titlebar_addbook
        '
        Me.titlebar_addbook.BackColor = System.Drawing.Color.Olive
        Me.titlebar_addbook.Location = New System.Drawing.Point(9, 9)
        Me.titlebar_addbook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.titlebar_addbook.Name = "titlebar_addbook"
        Me.titlebar_addbook.Size = New System.Drawing.Size(607, 69)
        Me.titlebar_addbook.TabIndex = 2
        Me.titlebar_addbook.TabStop = False
        '
        'GroupBox_addbook
        '
        Me.GroupBox_addbook.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox_addbook.Controls.Add(Me.tb_book_id)
        Me.GroupBox_addbook.Controls.Add(Me.book_id)
        Me.GroupBox_addbook.Controls.Add(Me.tb_copy_price)
        Me.GroupBox_addbook.Controls.Add(Me.copy_price)
        Me.GroupBox_addbook.Controls.Add(Me.bt_close)
        Me.GroupBox_addbook.Controls.Add(Me.bt_add_stock)
        Me.GroupBox_addbook.Controls.Add(Me.tb_rack_no)
        Me.GroupBox_addbook.Controls.Add(Me.rack_no)
        Me.GroupBox_addbook.Controls.Add(Me.ComboBox_category)
        Me.GroupBox_addbook.Controls.Add(Me.category)
        Me.GroupBox_addbook.Controls.Add(Me.tb_publisher_name)
        Me.GroupBox_addbook.Controls.Add(Me.tb_publish_year)
        Me.GroupBox_addbook.Controls.Add(Me.publisher_name)
        Me.GroupBox_addbook.Controls.Add(Me.publish_year)
        Me.GroupBox_addbook.Controls.Add(Me.tb_author_name)
        Me.GroupBox_addbook.Controls.Add(Me.author_name)
        Me.GroupBox_addbook.Controls.Add(Me.tb_book_title)
        Me.GroupBox_addbook.Controls.Add(Me.book_title)
        Me.GroupBox_addbook.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox_addbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_addbook.Name = "GroupBox_addbook"
        Me.GroupBox_addbook.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_addbook.Size = New System.Drawing.Size(608, 507)
        Me.GroupBox_addbook.TabIndex = 4
        Me.GroupBox_addbook.TabStop = False
        '
        'tb_book_id
        '
        Me.tb_book_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_id.Location = New System.Drawing.Point(241, 44)
        Me.tb_book_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_book_id.Name = "tb_book_id"
        Me.tb_book_id.Size = New System.Drawing.Size(321, 30)
        Me.tb_book_id.TabIndex = 21
        '
        'book_id
        '
        Me.book_id.AutoSize = True
        Me.book_id.BackColor = System.Drawing.Color.Transparent
        Me.book_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.book_id.Location = New System.Drawing.Point(55, 48)
        Me.book_id.Name = "book_id"
        Me.book_id.Size = New System.Drawing.Size(87, 25)
        Me.book_id.TabIndex = 20
        Me.book_id.Text = "Book ID:"
        '
        'tb_copy_price
        '
        Me.tb_copy_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_copy_price.Location = New System.Drawing.Point(241, 356)
        Me.tb_copy_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_copy_price.Name = "tb_copy_price"
        Me.tb_copy_price.Size = New System.Drawing.Size(321, 30)
        Me.tb_copy_price.TabIndex = 19
        '
        'copy_price
        '
        Me.copy_price.AutoSize = True
        Me.copy_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copy_price.Location = New System.Drawing.Point(55, 357)
        Me.copy_price.Name = "copy_price"
        Me.copy_price.Size = New System.Drawing.Size(142, 25)
        Me.copy_price.TabIndex = 18
        Me.copy_price.Text = "Price per copy:"
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Khaki
        Me.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.Location = New System.Drawing.Point(351, 441)
        Me.bt_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(213, 52)
        Me.bt_close.TabIndex = 15
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt_add_stock
        '
        Me.bt_add_stock.BackColor = System.Drawing.Color.Khaki
        Me.bt_add_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add_stock.Location = New System.Drawing.Point(61, 441)
        Me.bt_add_stock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_add_stock.Name = "bt_add_stock"
        Me.bt_add_stock.Size = New System.Drawing.Size(255, 52)
        Me.bt_add_stock.TabIndex = 14
        Me.bt_add_stock.Text = "Add New Book"
        Me.bt_add_stock.UseVisualStyleBackColor = False
        '
        'tb_rack_no
        '
        Me.tb_rack_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rack_no.Location = New System.Drawing.Point(241, 313)
        Me.tb_rack_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_rack_no.Name = "tb_rack_no"
        Me.tb_rack_no.Size = New System.Drawing.Size(321, 30)
        Me.tb_rack_no.TabIndex = 11
        '
        'rack_no
        '
        Me.rack_no.AutoSize = True
        Me.rack_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rack_no.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rack_no.Location = New System.Drawing.Point(56, 314)
        Me.rack_no.Name = "rack_no"
        Me.rack_no.Size = New System.Drawing.Size(97, 25)
        Me.rack_no.TabIndex = 10
        Me.rack_no.Text = "Rack No.:"
        '
        'ComboBox_category
        '
        Me.ComboBox_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_category.FormattingEnabled = True
        Me.ComboBox_category.Items.AddRange(New Object() {"Science", "Arts", "Commerce", "Engineering", "Medical", "History", "Geography", "Mathematics", "Psychology"})
        Me.ComboBox_category.Location = New System.Drawing.Point(241, 267)
        Me.ComboBox_category.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_category.Name = "ComboBox_category"
        Me.ComboBox_category.Size = New System.Drawing.Size(321, 33)
        Me.ComboBox_category.TabIndex = 9
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.ForeColor = System.Drawing.SystemColors.ControlText
        Me.category.Location = New System.Drawing.Point(55, 271)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(98, 25)
        Me.category.TabIndex = 8
        Me.category.Text = "Category:"
        '
        'tb_publisher_name
        '
        Me.tb_publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_publisher_name.Location = New System.Drawing.Point(241, 223)
        Me.tb_publisher_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_publisher_name.Name = "tb_publisher_name"
        Me.tb_publisher_name.Size = New System.Drawing.Size(321, 30)
        Me.tb_publisher_name.TabIndex = 7
        '
        'tb_publish_year
        '
        Me.tb_publish_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_publish_year.Location = New System.Drawing.Point(241, 178)
        Me.tb_publish_year.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_publish_year.Name = "tb_publish_year"
        Me.tb_publish_year.Size = New System.Drawing.Size(321, 30)
        Me.tb_publish_year.TabIndex = 6
        '
        'publisher_name
        '
        Me.publisher_name.AutoSize = True
        Me.publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_name.ForeColor = System.Drawing.SystemColors.ControlText
        Me.publisher_name.Location = New System.Drawing.Point(55, 223)
        Me.publisher_name.Name = "publisher_name"
        Me.publisher_name.Size = New System.Drawing.Size(156, 25)
        Me.publisher_name.TabIndex = 5
        Me.publisher_name.Text = "Publisher Name:"
        '
        'publish_year
        '
        Me.publish_year.AutoSize = True
        Me.publish_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publish_year.ForeColor = System.Drawing.SystemColors.ControlText
        Me.publish_year.Location = New System.Drawing.Point(55, 180)
        Me.publish_year.Name = "publish_year"
        Me.publish_year.Size = New System.Drawing.Size(159, 25)
        Me.publish_year.TabIndex = 4
        Me.publish_year.Text = "Publication Year:"
        '
        'tb_author_name
        '
        Me.tb_author_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_author_name.Location = New System.Drawing.Point(241, 134)
        Me.tb_author_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_author_name.Name = "tb_author_name"
        Me.tb_author_name.Size = New System.Drawing.Size(321, 30)
        Me.tb_author_name.TabIndex = 3
        '
        'author_name
        '
        Me.author_name.AutoSize = True
        Me.author_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_name.ForeColor = System.Drawing.SystemColors.ControlText
        Me.author_name.Location = New System.Drawing.Point(55, 134)
        Me.author_name.Name = "author_name"
        Me.author_name.Size = New System.Drawing.Size(133, 25)
        Me.author_name.TabIndex = 2
        Me.author_name.Text = "Author Name:"
        '
        'tb_book_title
        '
        Me.tb_book_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_title.Location = New System.Drawing.Point(241, 90)
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
        Me.book_title.ForeColor = System.Drawing.SystemColors.ControlText
        Me.book_title.Location = New System.Drawing.Point(55, 92)
        Me.book_title.Name = "book_title"
        Me.book_title.Size = New System.Drawing.Size(105, 25)
        Me.book_title.TabIndex = 0
        Me.book_title.Text = "Book Title:"
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.bt_close
        Me.ClientSize = New System.Drawing.Size(624, 598)
        Me.Controls.Add(Me.GroupBox_addbook)
        Me.Controls.Add(Me.addbook_title)
        Me.Controls.Add(Me.titlebar_addbook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "AddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddBook"
        CType(Me.titlebar_addbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_addbook.ResumeLayout(False)
        Me.GroupBox_addbook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addbook_title As Label
    Friend WithEvents titlebar_addbook As PictureBox
    Friend WithEvents GroupBox_addbook As GroupBox
    Friend WithEvents bt_add_stock As Button
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
    Friend WithEvents bt_close As Button
    Friend WithEvents tb_copy_price As TextBox
    Friend WithEvents copy_price As Label
    Friend WithEvents tb_book_id As TextBox
    Friend WithEvents book_id As Label
End Class
