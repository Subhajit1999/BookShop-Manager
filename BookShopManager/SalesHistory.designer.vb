<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesHistory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_searchSales = New System.Windows.Forms.DateTimePicker()
        Me.tb_search_customer = New System.Windows.Forms.TextBox()
        Me.search_by_customer = New System.Windows.Forms.Label()
        Me.search_by_date = New System.Windows.Forms.Label()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.tb_search_by_id = New System.Windows.Forms.TextBox()
        Me.search_by_id = New System.Windows.Forms.Label()
        Me.table_searched_data = New System.Windows.Forms.DataGridView()
        Me.saleshistory_title = New System.Windows.Forms.Label()
        Me.titleBar_manageSales = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.table_searched_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_searchSales)
        Me.GroupBox1.Controls.Add(Me.tb_search_customer)
        Me.GroupBox1.Controls.Add(Me.search_by_customer)
        Me.GroupBox1.Controls.Add(Me.search_by_date)
        Me.GroupBox1.Controls.Add(Me.bt_search)
        Me.GroupBox1.Controls.Add(Me.tb_search_by_id)
        Me.GroupBox1.Controls.Add(Me.search_by_id)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(991, 126)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker_searchSales
        '
        Me.DateTimePicker_searchSales.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_searchSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_searchSales.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_searchSales.Location = New System.Drawing.Point(227, 75)
        Me.DateTimePicker_searchSales.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_searchSales.Name = "DateTimePicker_searchSales"
        Me.DateTimePicker_searchSales.Size = New System.Drawing.Size(273, 30)
        Me.DateTimePicker_searchSales.TabIndex = 9
        '
        'tb_search_customer
        '
        Me.tb_search_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search_customer.Location = New System.Drawing.Point(680, 25)
        Me.tb_search_customer.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search_customer.Name = "tb_search_customer"
        Me.tb_search_customer.Size = New System.Drawing.Size(293, 30)
        Me.tb_search_customer.TabIndex = 8
        '
        'search_by_customer
        '
        Me.search_by_customer.AutoSize = True
        Me.search_by_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_by_customer.Location = New System.Drawing.Point(463, 28)
        Me.search_by_customer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.search_by_customer.Name = "search_by_customer"
        Me.search_by_customer.Size = New System.Drawing.Size(197, 25)
        Me.search_by_customer.TabIndex = 7
        Me.search_by_customer.Text = "Search by Customer:"
        '
        'search_by_date
        '
        Me.search_by_date.AutoSize = True
        Me.search_by_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_by_date.Location = New System.Drawing.Point(7, 78)
        Me.search_by_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.search_by_date.Name = "search_by_date"
        Me.search_by_date.Size = New System.Drawing.Size(153, 25)
        Me.search_by_date.TabIndex = 6
        Me.search_by_date.Text = "Search by Date:"
        '
        'bt_search
        '
        Me.bt_search.BackColor = System.Drawing.Color.Khaki
        Me.bt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search.Location = New System.Drawing.Point(841, 64)
        Me.bt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(133, 52)
        Me.bt_search.TabIndex = 5
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = False
        '
        'tb_search_by_id
        '
        Me.tb_search_by_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search_by_id.Location = New System.Drawing.Point(251, 25)
        Me.tb_search_by_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search_by_id.Name = "tb_search_by_id"
        Me.tb_search_by_id.Size = New System.Drawing.Size(181, 30)
        Me.tb_search_by_id.TabIndex = 1
        '
        'search_by_id
        '
        Me.search_by_id.AutoSize = True
        Me.search_by_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_by_id.Location = New System.Drawing.Point(8, 27)
        Me.search_by_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.search_by_id.Name = "search_by_id"
        Me.search_by_id.Size = New System.Drawing.Size(198, 25)
        Me.search_by_id.TabIndex = 0
        Me.search_by_id.Text = "Search by Invoice ID:"
        '
        'table_searched_data
        '
        Me.table_searched_data.BackgroundColor = System.Drawing.Color.Chocolate
        Me.table_searched_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_searched_data.Location = New System.Drawing.Point(8, 222)
        Me.table_searched_data.Margin = New System.Windows.Forms.Padding(4)
        Me.table_searched_data.Name = "table_searched_data"
        Me.table_searched_data.Size = New System.Drawing.Size(991, 327)
        Me.table_searched_data.TabIndex = 26
        '
        'saleshistory_title
        '
        Me.saleshistory_title.AutoSize = True
        Me.saleshistory_title.BackColor = System.Drawing.Color.Olive
        Me.saleshistory_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleshistory_title.ForeColor = System.Drawing.SystemColors.Control
        Me.saleshistory_title.Location = New System.Drawing.Point(25, 22)
        Me.saleshistory_title.Name = "saleshistory_title"
        Me.saleshistory_title.Size = New System.Drawing.Size(238, 42)
        Me.saleshistory_title.TabIndex = 25
        Me.saleshistory_title.Text = "Sales History"
        '
        'titleBar_manageSales
        '
        Me.titleBar_manageSales.BackColor = System.Drawing.Color.Olive
        Me.titleBar_manageSales.Location = New System.Drawing.Point(8, 7)
        Me.titleBar_manageSales.Margin = New System.Windows.Forms.Padding(4)
        Me.titleBar_manageSales.Name = "titleBar_manageSales"
        Me.titleBar_manageSales.Size = New System.Drawing.Size(991, 78)
        Me.titleBar_manageSales.TabIndex = 27
        Me.titleBar_manageSales.TabStop = False
        '
        'SalesHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1005, 555)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.table_searched_data)
        Me.Controls.Add(Me.saleshistory_title)
        Me.Controls.Add(Me.titleBar_manageSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SalesHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesHistory"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.table_searched_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_searchSales As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_search_customer As System.Windows.Forms.TextBox
    Friend WithEvents search_by_customer As System.Windows.Forms.Label
    Friend WithEvents search_by_date As System.Windows.Forms.Label
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents tb_search_by_id As System.Windows.Forms.TextBox
    Friend WithEvents search_by_id As System.Windows.Forms.Label
    Friend WithEvents table_searched_data As System.Windows.Forms.DataGridView
    Friend WithEvents saleshistory_title As System.Windows.Forms.Label
    Friend WithEvents titleBar_manageSales As System.Windows.Forms.PictureBox
End Class
