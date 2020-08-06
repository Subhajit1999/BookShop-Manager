<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageImports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageImports))
        Me.managebook_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_manageSale = New System.Windows.Forms.GroupBox()
        Me.tb_transact_id = New System.Windows.Forms.TextBox()
        Me.transaction_id = New System.Windows.Forms.Label()
        Me.ComboBox_category = New System.Windows.Forms.ComboBox()
        Me.tb_book_title = New System.Windows.Forms.TextBox()
        Me.book_title = New System.Windows.Forms.Label()
        Me.DateTimePicker_purchase = New System.Windows.Forms.DateTimePicker()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_delete_purchase = New System.Windows.Forms.Button()
        Me.bt_update_purchase = New System.Windows.Forms.Button()
        Me.bt_add_purchase = New System.Windows.Forms.Button()
        Me.tb_total_price = New System.Windows.Forms.TextBox()
        Me.tb_no_copies = New System.Windows.Forms.TextBox()
        Me.tb_publisher_name = New System.Windows.Forms.TextBox()
        Me.purchase_date = New System.Windows.Forms.Label()
        Me.book_total_price = New System.Windows.Forms.Label()
        Me.mobile_no = New System.Windows.Forms.Label()
        Me.category = New System.Windows.Forms.Label()
        Me.publisher_name = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_manageSale.SuspendLayout()
        Me.SuspendLayout()
        '
        'managebook_title
        '
        Me.managebook_title.AutoSize = True
        Me.managebook_title.BackColor = System.Drawing.Color.Olive
        Me.managebook_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managebook_title.ForeColor = System.Drawing.SystemColors.Control
        Me.managebook_title.Location = New System.Drawing.Point(23, 22)
        Me.managebook_title.Name = "managebook_title"
        Me.managebook_title.Size = New System.Drawing.Size(262, 39)
        Me.managebook_title.TabIndex = 20
        Me.managebook_title.Text = "Manage Imports"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Olive
        Me.PictureBox1.Location = New System.Drawing.Point(9, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 69)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'GroupBox_manageSale
        '
        Me.GroupBox_manageSale.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox_manageSale.Controls.Add(Me.tb_transact_id)
        Me.GroupBox_manageSale.Controls.Add(Me.transaction_id)
        Me.GroupBox_manageSale.Controls.Add(Me.ComboBox_category)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_book_title)
        Me.GroupBox_manageSale.Controls.Add(Me.book_title)
        Me.GroupBox_manageSale.Controls.Add(Me.DateTimePicker_purchase)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_cancel)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_delete_purchase)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_update_purchase)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_add_purchase)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_total_price)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_no_copies)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_publisher_name)
        Me.GroupBox_manageSale.Controls.Add(Me.purchase_date)
        Me.GroupBox_manageSale.Controls.Add(Me.book_total_price)
        Me.GroupBox_manageSale.Controls.Add(Me.mobile_no)
        Me.GroupBox_manageSale.Controls.Add(Me.category)
        Me.GroupBox_manageSale.Controls.Add(Me.publisher_name)
        Me.GroupBox_manageSale.Location = New System.Drawing.Point(9, 84)
        Me.GroupBox_manageSale.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_manageSale.Name = "GroupBox_manageSale"
        Me.GroupBox_manageSale.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_manageSale.Size = New System.Drawing.Size(617, 428)
        Me.GroupBox_manageSale.TabIndex = 22
        Me.GroupBox_manageSale.TabStop = False
        '
        'tb_transact_id
        '
        Me.tb_transact_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_transact_id.Location = New System.Drawing.Point(237, 34)
        Me.tb_transact_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_transact_id.Multiline = True
        Me.tb_transact_id.Name = "tb_transact_id"
        Me.tb_transact_id.Size = New System.Drawing.Size(321, 34)
        Me.tb_transact_id.TabIndex = 36
        '
        'transaction_id
        '
        Me.transaction_id.AutoSize = True
        Me.transaction_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transaction_id.Location = New System.Drawing.Point(57, 39)
        Me.transaction_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transaction_id.Name = "transaction_id"
        Me.transaction_id.Size = New System.Drawing.Size(145, 25)
        Me.transaction_id.TabIndex = 34
        Me.transaction_id.Text = "Transaction ID:"
        '
        'ComboBox_category
        '
        Me.ComboBox_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_category.FormattingEnabled = True
        Me.ComboBox_category.Location = New System.Drawing.Point(237, 198)
        Me.ComboBox_category.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_category.Name = "ComboBox_category"
        Me.ComboBox_category.Size = New System.Drawing.Size(321, 33)
        Me.ComboBox_category.TabIndex = 33
        '
        'tb_book_title
        '
        Me.tb_book_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_title.Location = New System.Drawing.Point(237, 76)
        Me.tb_book_title.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_book_title.Multiline = True
        Me.tb_book_title.Name = "tb_book_title"
        Me.tb_book_title.Size = New System.Drawing.Size(321, 34)
        Me.tb_book_title.TabIndex = 32
        '
        'book_title
        '
        Me.book_title.AutoSize = True
        Me.book_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_title.Location = New System.Drawing.Point(57, 81)
        Me.book_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.book_title.Name = "book_title"
        Me.book_title.Size = New System.Drawing.Size(120, 25)
        Me.book_title.TabIndex = 31
        Me.book_title.Text = "Book Name:"
        '
        'DateTimePicker_purchase
        '
        Me.DateTimePicker_purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_purchase.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_purchase.Location = New System.Drawing.Point(237, 117)
        Me.DateTimePicker_purchase.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_purchase.Name = "DateTimePicker_purchase"
        Me.DateTimePicker_purchase.Size = New System.Drawing.Size(321, 30)
        Me.DateTimePicker_purchase.TabIndex = 30
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.Khaki
        Me.bt_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancel.Location = New System.Drawing.Point(439, 359)
        Me.bt_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(157, 52)
        Me.bt_cancel.TabIndex = 24
        Me.bt_cancel.Text = "Cancel"
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'bt_delete_purchase
        '
        Me.bt_delete_purchase.BackColor = System.Drawing.Color.Khaki
        Me.bt_delete_purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_delete_purchase.Location = New System.Drawing.Point(297, 359)
        Me.bt_delete_purchase.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_delete_purchase.Name = "bt_delete_purchase"
        Me.bt_delete_purchase.Size = New System.Drawing.Size(136, 52)
        Me.bt_delete_purchase.TabIndex = 23
        Me.bt_delete_purchase.Text = "Delete"
        Me.bt_delete_purchase.UseVisualStyleBackColor = False
        '
        'bt_update_purchase
        '
        Me.bt_update_purchase.BackColor = System.Drawing.Color.Khaki
        Me.bt_update_purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_update_purchase.Location = New System.Drawing.Point(159, 359)
        Me.bt_update_purchase.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_update_purchase.Name = "bt_update_purchase"
        Me.bt_update_purchase.Size = New System.Drawing.Size(131, 52)
        Me.bt_update_purchase.TabIndex = 22
        Me.bt_update_purchase.Text = "Update"
        Me.bt_update_purchase.UseVisualStyleBackColor = False
        '
        'bt_add_purchase
        '
        Me.bt_add_purchase.BackColor = System.Drawing.Color.Khaki
        Me.bt_add_purchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add_purchase.Location = New System.Drawing.Point(20, 359)
        Me.bt_add_purchase.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_add_purchase.Name = "bt_add_purchase"
        Me.bt_add_purchase.Size = New System.Drawing.Size(131, 52)
        Me.bt_add_purchase.TabIndex = 5
        Me.bt_add_purchase.Text = "Add New"
        Me.bt_add_purchase.UseVisualStyleBackColor = False
        '
        'tb_total_price
        '
        Me.tb_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_price.Location = New System.Drawing.Point(237, 283)
        Me.tb_total_price.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_total_price.Multiline = True
        Me.tb_total_price.Name = "tb_total_price"
        Me.tb_total_price.Size = New System.Drawing.Size(321, 34)
        Me.tb_total_price.TabIndex = 17
        '
        'tb_no_copies
        '
        Me.tb_no_copies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_copies.Location = New System.Drawing.Point(237, 241)
        Me.tb_no_copies.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_no_copies.Multiline = True
        Me.tb_no_copies.Name = "tb_no_copies"
        Me.tb_no_copies.Size = New System.Drawing.Size(321, 34)
        Me.tb_no_copies.TabIndex = 16
        '
        'tb_publisher_name
        '
        Me.tb_publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_publisher_name.Location = New System.Drawing.Point(237, 156)
        Me.tb_publisher_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_publisher_name.Multiline = True
        Me.tb_publisher_name.Name = "tb_publisher_name"
        Me.tb_publisher_name.Size = New System.Drawing.Size(321, 34)
        Me.tb_publisher_name.TabIndex = 14
        '
        'purchase_date
        '
        Me.purchase_date.AutoSize = True
        Me.purchase_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_date.Location = New System.Drawing.Point(57, 122)
        Me.purchase_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.purchase_date.Name = "purchase_date"
        Me.purchase_date.Size = New System.Drawing.Size(152, 25)
        Me.purchase_date.TabIndex = 13
        Me.purchase_date.Text = "Purchase Date :"
        '
        'book_total_price
        '
        Me.book_total_price.AutoSize = True
        Me.book_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_total_price.Location = New System.Drawing.Point(57, 287)
        Me.book_total_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.book_total_price.Name = "book_total_price"
        Me.book_total_price.Size = New System.Drawing.Size(140, 25)
        Me.book_total_price.TabIndex = 9
        Me.book_total_price.Text = "Total Amount :"
        '
        'mobile_no
        '
        Me.mobile_no.AutoSize = True
        Me.mobile_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile_no.Location = New System.Drawing.Point(57, 244)
        Me.mobile_no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mobile_no.Name = "mobile_no"
        Me.mobile_no.Size = New System.Drawing.Size(136, 25)
        Me.mobile_no.TabIndex = 8
        Me.mobile_no.Text = "No. of Copies:"
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.Location = New System.Drawing.Point(57, 202)
        Me.category.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(153, 25)
        Me.category.TabIndex = 7
        Me.category.Text = "Book Category :"
        '
        'publisher_name
        '
        Me.publisher_name.AutoSize = True
        Me.publisher_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_name.Location = New System.Drawing.Point(57, 161)
        Me.publisher_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.publisher_name.Name = "publisher_name"
        Me.publisher_name.Size = New System.Drawing.Size(161, 25)
        Me.publisher_name.TabIndex = 6
        Me.publisher_name.Text = "Publisher Name :"
        '
        'manageImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(636, 517)
        Me.Controls.Add(Me.GroupBox_manageSale)
        Me.Controls.Add(Me.managebook_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "manageImports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Imports"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_manageSale.ResumeLayout(False)
        Me.GroupBox_manageSale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents managebook_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox_manageSale As GroupBox
    Friend WithEvents tb_book_title As TextBox
    Friend WithEvents book_title As Label
    Friend WithEvents DateTimePicker_purchase As DateTimePicker
    Friend WithEvents bt_cancel As Button
    Friend WithEvents bt_delete_purchase As Button
    Friend WithEvents bt_update_purchase As Button
    Friend WithEvents bt_add_purchase As Button
    Friend WithEvents tb_total_price As TextBox
    Friend WithEvents tb_no_copies As TextBox
    Friend WithEvents tb_publisher_name As TextBox
    Friend WithEvents purchase_date As Label
    Friend WithEvents book_total_price As Label
    Friend WithEvents mobile_no As Label
    Friend WithEvents category As Label
    Friend WithEvents publisher_name As Label
    Friend WithEvents ComboBox_category As ComboBox
    Friend WithEvents transaction_id As Label
    Friend WithEvents tb_transact_id As TextBox
End Class
