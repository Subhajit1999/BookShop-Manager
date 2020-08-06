<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageSales))
        Me.titleBar_manageSales = New System.Windows.Forms.PictureBox()
        Me.managesale_title = New System.Windows.Forms.Label()
        Me.GroupBox_manageSale = New System.Windows.Forms.GroupBox()
        Me.tb_sales_id = New System.Windows.Forms.TextBox()
        Me.sales_id = New System.Windows.Forms.Label()
        Me.DateTimePicker_sales = New System.Windows.Forms.DateTimePicker()
        Me.rd_no = New System.Windows.Forms.RadioButton()
        Me.rd_yes = New System.Windows.Forms.RadioButton()
        Me.amount_paid = New System.Windows.Forms.Label()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_delete_sale = New System.Windows.Forms.Button()
        Me.tb_total_price = New System.Windows.Forms.TextBox()
        Me.bt_update_sale = New System.Windows.Forms.Button()
        Me.tb_discount = New System.Windows.Forms.TextBox()
        Me.bt_add_sale = New System.Windows.Forms.Button()
        Me.tb_quantity = New System.Windows.Forms.TextBox()
        Me.tb_book_name = New System.Windows.Forms.TextBox()
        Me.tb_mobile_no = New System.Windows.Forms.TextBox()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.tb_customer_name = New System.Windows.Forms.TextBox()
        Me.purchase_date = New System.Windows.Forms.Label()
        Me.total_price = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.Label()
        Me.book_name = New System.Windows.Forms.Label()
        Me.mobile_no = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.customer_name = New System.Windows.Forms.Label()
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_manageSale.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleBar_manageSales
        '
        Me.titleBar_manageSales.BackColor = System.Drawing.Color.Olive
        Me.titleBar_manageSales.Location = New System.Drawing.Point(9, 7)
        Me.titleBar_manageSales.Margin = New System.Windows.Forms.Padding(4)
        Me.titleBar_manageSales.Name = "titleBar_manageSales"
        Me.titleBar_manageSales.Size = New System.Drawing.Size(595, 69)
        Me.titleBar_manageSales.TabIndex = 5
        Me.titleBar_manageSales.TabStop = False
        '
        'managesale_title
        '
        Me.managesale_title.AutoSize = True
        Me.managesale_title.BackColor = System.Drawing.Color.Olive
        Me.managesale_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managesale_title.ForeColor = System.Drawing.SystemColors.Control
        Me.managesale_title.Location = New System.Drawing.Point(13, 21)
        Me.managesale_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.managesale_title.Name = "managesale_title"
        Me.managesale_title.Size = New System.Drawing.Size(235, 39)
        Me.managesale_title.TabIndex = 6
        Me.managesale_title.Text = "Manage Sales"
        '
        'GroupBox_manageSale
        '
        Me.GroupBox_manageSale.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox_manageSale.Controls.Add(Me.tb_sales_id)
        Me.GroupBox_manageSale.Controls.Add(Me.sales_id)
        Me.GroupBox_manageSale.Controls.Add(Me.DateTimePicker_sales)
        Me.GroupBox_manageSale.Controls.Add(Me.rd_no)
        Me.GroupBox_manageSale.Controls.Add(Me.rd_yes)
        Me.GroupBox_manageSale.Controls.Add(Me.amount_paid)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_cancel)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_delete_sale)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_total_price)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_update_sale)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_discount)
        Me.GroupBox_manageSale.Controls.Add(Me.bt_add_sale)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_quantity)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_book_name)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_mobile_no)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_address)
        Me.GroupBox_manageSale.Controls.Add(Me.tb_customer_name)
        Me.GroupBox_manageSale.Controls.Add(Me.purchase_date)
        Me.GroupBox_manageSale.Controls.Add(Me.total_price)
        Me.GroupBox_manageSale.Controls.Add(Me.discount)
        Me.GroupBox_manageSale.Controls.Add(Me.quantity)
        Me.GroupBox_manageSale.Controls.Add(Me.book_name)
        Me.GroupBox_manageSale.Controls.Add(Me.mobile_no)
        Me.GroupBox_manageSale.Controls.Add(Me.address)
        Me.GroupBox_manageSale.Controls.Add(Me.customer_name)
        Me.GroupBox_manageSale.Location = New System.Drawing.Point(11, 81)
        Me.GroupBox_manageSale.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_manageSale.Name = "GroupBox_manageSale"
        Me.GroupBox_manageSale.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_manageSale.Size = New System.Drawing.Size(593, 549)
        Me.GroupBox_manageSale.TabIndex = 7
        Me.GroupBox_manageSale.TabStop = False
        '
        'tb_sales_id
        '
        Me.tb_sales_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sales_id.Location = New System.Drawing.Point(223, 36)
        Me.tb_sales_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_sales_id.Multiline = True
        Me.tb_sales_id.Name = "tb_sales_id"
        Me.tb_sales_id.Size = New System.Drawing.Size(321, 34)
        Me.tb_sales_id.TabIndex = 32
        '
        'sales_id
        '
        Me.sales_id.AutoSize = True
        Me.sales_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_id.Location = New System.Drawing.Point(43, 41)
        Me.sales_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sales_id.Name = "sales_id"
        Me.sales_id.Size = New System.Drawing.Size(109, 25)
        Me.sales_id.TabIndex = 31
        Me.sales_id.Text = "Invoice ID :"
        '
        'DateTimePicker_sales
        '
        Me.DateTimePicker_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_sales.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_sales.Location = New System.Drawing.Point(223, 76)
        Me.DateTimePicker_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_sales.Name = "DateTimePicker_sales"
        Me.DateTimePicker_sales.Size = New System.Drawing.Size(321, 30)
        Me.DateTimePicker_sales.TabIndex = 30
        '
        'rd_no
        '
        Me.rd_no.AutoSize = True
        Me.rd_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_no.Location = New System.Drawing.Point(385, 414)
        Me.rd_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rd_no.Name = "rd_no"
        Me.rd_no.Size = New System.Drawing.Size(58, 29)
        Me.rd_no.TabIndex = 29
        Me.rd_no.TabStop = True
        Me.rd_no.Text = "No"
        Me.rd_no.UseVisualStyleBackColor = True
        '
        'rd_yes
        '
        Me.rd_yes.AutoSize = True
        Me.rd_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_yes.Location = New System.Drawing.Point(299, 414)
        Me.rd_yes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rd_yes.Name = "rd_yes"
        Me.rd_yes.Size = New System.Drawing.Size(67, 29)
        Me.rd_yes.TabIndex = 28
        Me.rd_yes.TabStop = True
        Me.rd_yes.Text = "Yes"
        Me.rd_yes.UseVisualStyleBackColor = True
        '
        'amount_paid
        '
        Me.amount_paid.AutoSize = True
        Me.amount_paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_paid.Location = New System.Drawing.Point(41, 414)
        Me.amount_paid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amount_paid.Name = "amount_paid"
        Me.amount_paid.Size = New System.Drawing.Size(130, 25)
        Me.amount_paid.TabIndex = 27
        Me.amount_paid.Text = "Amount Paid:"
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.Khaki
        Me.bt_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancel.Location = New System.Drawing.Point(428, 482)
        Me.bt_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(157, 52)
        Me.bt_cancel.TabIndex = 24
        Me.bt_cancel.Text = "Cancel"
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'bt_delete_sale
        '
        Me.bt_delete_sale.BackColor = System.Drawing.Color.Khaki
        Me.bt_delete_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_delete_sale.Location = New System.Drawing.Point(287, 482)
        Me.bt_delete_sale.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_delete_sale.Name = "bt_delete_sale"
        Me.bt_delete_sale.Size = New System.Drawing.Size(136, 52)
        Me.bt_delete_sale.TabIndex = 23
        Me.bt_delete_sale.Text = "Delete"
        Me.bt_delete_sale.UseVisualStyleBackColor = False
        '
        'tb_total_price
        '
        Me.tb_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_price.Location = New System.Drawing.Point(223, 369)
        Me.tb_total_price.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_total_price.Multiline = True
        Me.tb_total_price.Name = "tb_total_price"
        Me.tb_total_price.Size = New System.Drawing.Size(321, 34)
        Me.tb_total_price.TabIndex = 20
        '
        'bt_update_sale
        '
        Me.bt_update_sale.BackColor = System.Drawing.Color.Khaki
        Me.bt_update_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_update_sale.Location = New System.Drawing.Point(148, 482)
        Me.bt_update_sale.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_update_sale.Name = "bt_update_sale"
        Me.bt_update_sale.Size = New System.Drawing.Size(131, 52)
        Me.bt_update_sale.TabIndex = 22
        Me.bt_update_sale.Text = "Update"
        Me.bt_update_sale.UseVisualStyleBackColor = False
        '
        'tb_discount
        '
        Me.tb_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_discount.Location = New System.Drawing.Point(223, 327)
        Me.tb_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_discount.Multiline = True
        Me.tb_discount.Name = "tb_discount"
        Me.tb_discount.Size = New System.Drawing.Size(321, 34)
        Me.tb_discount.TabIndex = 19
        '
        'bt_add_sale
        '
        Me.bt_add_sale.BackColor = System.Drawing.Color.Khaki
        Me.bt_add_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add_sale.Location = New System.Drawing.Point(9, 482)
        Me.bt_add_sale.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_add_sale.Name = "bt_add_sale"
        Me.bt_add_sale.Size = New System.Drawing.Size(131, 52)
        Me.bt_add_sale.TabIndex = 5
        Me.bt_add_sale.Text = "Add New"
        Me.bt_add_sale.UseVisualStyleBackColor = False
        '
        'tb_quantity
        '
        Me.tb_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_quantity.Location = New System.Drawing.Point(223, 286)
        Me.tb_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_quantity.Multiline = True
        Me.tb_quantity.Name = "tb_quantity"
        Me.tb_quantity.Size = New System.Drawing.Size(321, 34)
        Me.tb_quantity.TabIndex = 18
        '
        'tb_book_name
        '
        Me.tb_book_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_book_name.Location = New System.Drawing.Point(223, 242)
        Me.tb_book_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_book_name.Multiline = True
        Me.tb_book_name.Name = "tb_book_name"
        Me.tb_book_name.Size = New System.Drawing.Size(321, 34)
        Me.tb_book_name.TabIndex = 17
        '
        'tb_mobile_no
        '
        Me.tb_mobile_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mobile_no.Location = New System.Drawing.Point(223, 201)
        Me.tb_mobile_no.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_mobile_no.Multiline = True
        Me.tb_mobile_no.Name = "tb_mobile_no"
        Me.tb_mobile_no.Size = New System.Drawing.Size(321, 34)
        Me.tb_mobile_no.TabIndex = 16
        '
        'tb_address
        '
        Me.tb_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.Location = New System.Drawing.Point(223, 159)
        Me.tb_address.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(321, 34)
        Me.tb_address.TabIndex = 15
        '
        'tb_customer_name
        '
        Me.tb_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_name.Location = New System.Drawing.Point(223, 116)
        Me.tb_customer_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_customer_name.Multiline = True
        Me.tb_customer_name.Name = "tb_customer_name"
        Me.tb_customer_name.Size = New System.Drawing.Size(321, 34)
        Me.tb_customer_name.TabIndex = 14
        '
        'purchase_date
        '
        Me.purchase_date.AutoSize = True
        Me.purchase_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_date.Location = New System.Drawing.Point(43, 81)
        Me.purchase_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.purchase_date.Name = "purchase_date"
        Me.purchase_date.Size = New System.Drawing.Size(64, 25)
        Me.purchase_date.TabIndex = 13
        Me.purchase_date.Text = "Date :"
        '
        'total_price
        '
        Me.total_price.AutoSize = True
        Me.total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_price.Location = New System.Drawing.Point(43, 372)
        Me.total_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.total_price.Name = "total_price"
        Me.total_price.Size = New System.Drawing.Size(116, 25)
        Me.total_price.TabIndex = 12
        Me.total_price.Text = "Total Price :"
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.Location = New System.Drawing.Point(43, 331)
        Me.discount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(99, 25)
        Me.discount.TabIndex = 11
        Me.discount.Text = "Discount :"
        '
        'quantity
        '
        Me.quantity.AutoSize = True
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(43, 287)
        Me.quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(96, 25)
        Me.quantity.TabIndex = 10
        Me.quantity.Text = "Quantity :"
        '
        'book_name
        '
        Me.book_name.AutoSize = True
        Me.book_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_name.Location = New System.Drawing.Point(43, 246)
        Me.book_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.book_name.Name = "book_name"
        Me.book_name.Size = New System.Drawing.Size(125, 25)
        Me.book_name.TabIndex = 9
        Me.book_name.Text = "Book Name :"
        '
        'mobile_no
        '
        Me.mobile_no.AutoSize = True
        Me.mobile_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile_no.Location = New System.Drawing.Point(43, 203)
        Me.mobile_no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mobile_no.Name = "mobile_no"
        Me.mobile_no.Size = New System.Drawing.Size(116, 25)
        Me.mobile_no.TabIndex = 8
        Me.mobile_no.Text = "Mobile No. :"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(43, 161)
        Me.address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(96, 25)
        Me.address.TabIndex = 7
        Me.address.Text = "Address :"
        '
        'customer_name
        '
        Me.customer_name.AutoSize = True
        Me.customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_name.Location = New System.Drawing.Point(43, 121)
        Me.customer_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Size = New System.Drawing.Size(165, 25)
        Me.customer_name.TabIndex = 6
        Me.customer_name.Text = "Customer Name :"
        '
        'ManageSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 636)
        Me.Controls.Add(Me.GroupBox_manageSale)
        Me.Controls.Add(Me.managesale_title)
        Me.Controls.Add(Me.titleBar_manageSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ManageSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Sales"
        Me.TopMost = True
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_manageSale.ResumeLayout(False)
        Me.GroupBox_manageSale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleBar_manageSales As System.Windows.Forms.PictureBox
    Friend WithEvents managesale_title As System.Windows.Forms.Label
    Friend WithEvents GroupBox_manageSale As System.Windows.Forms.GroupBox
    Friend WithEvents tb_total_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_discount As System.Windows.Forms.TextBox
    Friend WithEvents tb_quantity As System.Windows.Forms.TextBox
    Friend WithEvents tb_book_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_mobile_no As System.Windows.Forms.TextBox
    Friend WithEvents tb_address As System.Windows.Forms.TextBox
    Friend WithEvents tb_customer_name As System.Windows.Forms.TextBox
    Friend WithEvents purchase_date As System.Windows.Forms.Label
    Friend WithEvents total_price As System.Windows.Forms.Label
    Friend WithEvents discount As System.Windows.Forms.Label
    Friend WithEvents quantity As System.Windows.Forms.Label
    Friend WithEvents book_name As System.Windows.Forms.Label
    Friend WithEvents mobile_no As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.Label
    Friend WithEvents customer_name As System.Windows.Forms.Label
    Friend WithEvents bt_add_sale As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_delete_sale As System.Windows.Forms.Button
    Friend WithEvents bt_update_sale As System.Windows.Forms.Button
    Friend WithEvents rd_no As RadioButton
    Friend WithEvents rd_yes As RadioButton
    Friend WithEvents amount_paid As Label
    Friend WithEvents DateTimePicker_sales As DateTimePicker
    Friend WithEvents tb_sales_id As TextBox
    Friend WithEvents sales_id As Label
End Class
