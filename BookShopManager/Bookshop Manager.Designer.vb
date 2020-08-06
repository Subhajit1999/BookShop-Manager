<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.titleBar = New System.Windows.Forms.PictureBox()
        Me.program_title = New System.Windows.Forms.Label()
        Me.version_code = New System.Windows.Forms.Label()
        Me.image_home = New System.Windows.Forms.PictureBox()
        Me.bt_add_book = New System.Windows.Forms.Button()
        Me.bt_manage_book = New System.Windows.Forms.Button()
        Me.bt_search_book = New System.Windows.Forms.Button()
        Me.bt_manage_sales = New System.Windows.Forms.Button()
        Me.bt_manage_stock = New System.Windows.Forms.Button()
        Me.bt_search_stock = New System.Windows.Forms.Button()
        Me.bt_sales_history = New System.Windows.Forms.Button()
        Me.menu_home = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bt_manage_imports = New System.Windows.Forms.Button()
        Me.bt_monthly_report = New System.Windows.Forms.Button()
        Me.bt_calculator = New System.Windows.Forms.Button()
        Me.label_time = New System.Windows.Forms.Label()
        Me.label_date = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.titleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_home.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.Olive
        Me.titleBar.Location = New System.Drawing.Point(16, 34)
        Me.titleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(1249, 110)
        Me.titleBar.TabIndex = 0
        Me.titleBar.TabStop = False
        '
        'program_title
        '
        Me.program_title.AutoSize = True
        Me.program_title.BackColor = System.Drawing.Color.Olive
        Me.program_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.program_title.ForeColor = System.Drawing.SystemColors.Control
        Me.program_title.Location = New System.Drawing.Point(35, 64)
        Me.program_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.program_title.Name = "program_title"
        Me.program_title.Size = New System.Drawing.Size(380, 48)
        Me.program_title.TabIndex = 1
        Me.program_title.Text = "Bookshop Manager"
        '
        'version_code
        '
        Me.version_code.AutoSize = True
        Me.version_code.BackColor = System.Drawing.Color.Olive
        Me.version_code.Location = New System.Drawing.Point(424, 112)
        Me.version_code.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.version_code.Name = "version_code"
        Me.version_code.Size = New System.Drawing.Size(39, 17)
        Me.version_code.TabIndex = 2
        Me.version_code.Text = "v 1.0"
        '
        'image_home
        '
        Me.image_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.image_home.Image = CType(resources.GetObject("image_home.Image"), System.Drawing.Image)
        Me.image_home.InitialImage = CType(resources.GetObject("image_home.InitialImage"), System.Drawing.Image)
        Me.image_home.Location = New System.Drawing.Point(16, 153)
        Me.image_home.Margin = New System.Windows.Forms.Padding(4)
        Me.image_home.Name = "image_home"
        Me.image_home.Size = New System.Drawing.Size(987, 582)
        Me.image_home.TabIndex = 3
        Me.image_home.TabStop = False
        Me.image_home.WaitOnLoad = True
        '
        'bt_add_book
        '
        Me.bt_add_book.BackColor = System.Drawing.Color.Khaki
        Me.bt_add_book.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add_book.Location = New System.Drawing.Point(1011, 151)
        Me.bt_add_book.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_add_book.Name = "bt_add_book"
        Me.bt_add_book.Size = New System.Drawing.Size(255, 52)
        Me.bt_add_book.TabIndex = 4
        Me.bt_add_book.Text = "Add New Books"
        Me.bt_add_book.UseVisualStyleBackColor = False
        '
        'bt_manage_book
        '
        Me.bt_manage_book.BackColor = System.Drawing.Color.Khaki
        Me.bt_manage_book.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_manage_book.Location = New System.Drawing.Point(1011, 210)
        Me.bt_manage_book.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_manage_book.Name = "bt_manage_book"
        Me.bt_manage_book.Size = New System.Drawing.Size(255, 52)
        Me.bt_manage_book.TabIndex = 5
        Me.bt_manage_book.Text = "Manage Books"
        Me.bt_manage_book.UseVisualStyleBackColor = False
        '
        'bt_search_book
        '
        Me.bt_search_book.BackColor = System.Drawing.Color.Khaki
        Me.bt_search_book.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search_book.Location = New System.Drawing.Point(1011, 270)
        Me.bt_search_book.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_search_book.Name = "bt_search_book"
        Me.bt_search_book.Size = New System.Drawing.Size(255, 52)
        Me.bt_search_book.TabIndex = 6
        Me.bt_search_book.Text = "Search Books"
        Me.bt_search_book.UseVisualStyleBackColor = False
        '
        'bt_manage_sales
        '
        Me.bt_manage_sales.BackColor = System.Drawing.Color.Khaki
        Me.bt_manage_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_manage_sales.Location = New System.Drawing.Point(1011, 329)
        Me.bt_manage_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_manage_sales.Name = "bt_manage_sales"
        Me.bt_manage_sales.Size = New System.Drawing.Size(255, 52)
        Me.bt_manage_sales.TabIndex = 7
        Me.bt_manage_sales.Text = "Manage Sales"
        Me.bt_manage_sales.UseVisualStyleBackColor = False
        '
        'bt_manage_stock
        '
        Me.bt_manage_stock.BackColor = System.Drawing.Color.Khaki
        Me.bt_manage_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_manage_stock.Location = New System.Drawing.Point(1011, 447)
        Me.bt_manage_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_manage_stock.Name = "bt_manage_stock"
        Me.bt_manage_stock.Size = New System.Drawing.Size(255, 52)
        Me.bt_manage_stock.TabIndex = 8
        Me.bt_manage_stock.Text = "Manage Stock"
        Me.bt_manage_stock.UseVisualStyleBackColor = False
        '
        'bt_search_stock
        '
        Me.bt_search_stock.BackColor = System.Drawing.Color.Khaki
        Me.bt_search_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search_stock.Location = New System.Drawing.Point(1011, 506)
        Me.bt_search_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_search_stock.Name = "bt_search_stock"
        Me.bt_search_stock.Size = New System.Drawing.Size(255, 52)
        Me.bt_search_stock.TabIndex = 9
        Me.bt_search_stock.Text = "Search Stock"
        Me.bt_search_stock.UseVisualStyleBackColor = False
        '
        'bt_sales_history
        '
        Me.bt_sales_history.BackColor = System.Drawing.Color.Khaki
        Me.bt_sales_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sales_history.Location = New System.Drawing.Point(1011, 388)
        Me.bt_sales_history.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_sales_history.Name = "bt_sales_history"
        Me.bt_sales_history.Size = New System.Drawing.Size(255, 52)
        Me.bt_sales_history.TabIndex = 10
        Me.bt_sales_history.Text = "Sales History"
        Me.bt_sales_history.UseVisualStyleBackColor = False
        '
        'menu_home
        '
        Me.menu_home.BackColor = System.Drawing.Color.Khaki
        Me.menu_home.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu_home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menu_home.Location = New System.Drawing.Point(0, 0)
        Me.menu_home.Name = "menu_home"
        Me.menu_home.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menu_home.Size = New System.Drawing.Size(1281, 24)
        Me.menu_home.TabIndex = 11
        Me.menu_home.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'bt_manage_imports
        '
        Me.bt_manage_imports.BackColor = System.Drawing.Color.Khaki
        Me.bt_manage_imports.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_manage_imports.Location = New System.Drawing.Point(1011, 565)
        Me.bt_manage_imports.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_manage_imports.Name = "bt_manage_imports"
        Me.bt_manage_imports.Size = New System.Drawing.Size(255, 52)
        Me.bt_manage_imports.TabIndex = 12
        Me.bt_manage_imports.Text = "Manage Book Imports"
        Me.bt_manage_imports.UseVisualStyleBackColor = False
        '
        'bt_monthly_report
        '
        Me.bt_monthly_report.BackColor = System.Drawing.Color.Khaki
        Me.bt_monthly_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_monthly_report.Location = New System.Drawing.Point(1011, 624)
        Me.bt_monthly_report.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_monthly_report.Name = "bt_monthly_report"
        Me.bt_monthly_report.Size = New System.Drawing.Size(255, 52)
        Me.bt_monthly_report.TabIndex = 13
        Me.bt_monthly_report.Text = "Monthly Report"
        Me.bt_monthly_report.UseVisualStyleBackColor = False
        '
        'bt_calculator
        '
        Me.bt_calculator.BackColor = System.Drawing.Color.Khaki
        Me.bt_calculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_calculator.Location = New System.Drawing.Point(1011, 683)
        Me.bt_calculator.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_calculator.Name = "bt_calculator"
        Me.bt_calculator.Size = New System.Drawing.Size(255, 52)
        Me.bt_calculator.TabIndex = 14
        Me.bt_calculator.Text = "Digital Calculator"
        Me.bt_calculator.UseVisualStyleBackColor = False
        '
        'label_time
        '
        Me.label_time.AutoSize = True
        Me.label_time.BackColor = System.Drawing.Color.Olive
        Me.label_time.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_time.ForeColor = System.Drawing.Color.Khaki
        Me.label_time.Location = New System.Drawing.Point(937, 103)
        Me.label_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_time.Name = "label_time"
        Me.label_time.Size = New System.Drawing.Size(125, 24)
        Me.label_time.TabIndex = 15
        Me.label_time.Text = "12:00:00 AM"
        '
        'label_date
        '
        Me.label_date.AutoSize = True
        Me.label_date.BackColor = System.Drawing.Color.Olive
        Me.label_date.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_date.ForeColor = System.Drawing.Color.Khaki
        Me.label_date.Location = New System.Drawing.Point(936, 65)
        Me.label_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(255, 26)
        Me.label_date.TabIndex = 16
        Me.label_date.Text = "1 May 2019, Wednesday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(869, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Olive
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(867, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Time:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1281, 748)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_date)
        Me.Controls.Add(Me.label_time)
        Me.Controls.Add(Me.bt_calculator)
        Me.Controls.Add(Me.bt_monthly_report)
        Me.Controls.Add(Me.bt_manage_imports)
        Me.Controls.Add(Me.bt_sales_history)
        Me.Controls.Add(Me.bt_search_stock)
        Me.Controls.Add(Me.bt_manage_stock)
        Me.Controls.Add(Me.bt_manage_sales)
        Me.Controls.Add(Me.bt_search_book)
        Me.Controls.Add(Me.bt_manage_book)
        Me.Controls.Add(Me.bt_add_book)
        Me.Controls.Add(Me.image_home)
        Me.Controls.Add(Me.version_code)
        Me.Controls.Add(Me.program_title)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.menu_home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menu_home
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookShop Manager"
        CType(Me.titleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_home.ResumeLayout(False)
        Me.menu_home.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleBar As PictureBox
    Friend WithEvents program_title As Label
    Friend WithEvents version_code As Label
    Friend WithEvents image_home As PictureBox
    Friend WithEvents bt_add_book As Button
    Friend WithEvents bt_manage_book As Button
    Friend WithEvents bt_search_book As Button
    Friend WithEvents bt_manage_sales As Button
    Friend WithEvents bt_manage_stock As Button
    Friend WithEvents bt_search_stock As Button
    Friend WithEvents bt_sales_history As Button
    Friend WithEvents menu_home As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bt_manage_imports As Button
    Friend WithEvents bt_monthly_report As Button
    Friend WithEvents bt_calculator As Button
    Friend WithEvents label_time As Label
    Friend WithEvents label_date As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
