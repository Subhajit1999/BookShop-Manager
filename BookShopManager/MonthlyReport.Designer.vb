<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyReport))
        Me.monthlyreport_title = New System.Windows.Forms.Label()
        Me.titlebar_addbook = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.expense_amount_number = New System.Windows.Forms.Label()
        Me.sale_amount_number = New System.Windows.Forms.Label()
        Me.expense_amount = New System.Windows.Forms.Label()
        Me.sale_amout = New System.Windows.Forms.Label()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.DateTimePicker_to = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.Label()
        Me.dateFrom = New System.Windows.Forms.Label()
        Me.DateTimePicker_from = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.titlebar_addbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monthlyreport_title
        '
        Me.monthlyreport_title.AutoSize = True
        Me.monthlyreport_title.BackColor = System.Drawing.Color.Olive
        Me.monthlyreport_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthlyreport_title.ForeColor = System.Drawing.SystemColors.Control
        Me.monthlyreport_title.Location = New System.Drawing.Point(28, 22)
        Me.monthlyreport_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.monthlyreport_title.Name = "monthlyreport_title"
        Me.monthlyreport_title.Size = New System.Drawing.Size(247, 39)
        Me.monthlyreport_title.TabIndex = 5
        Me.monthlyreport_title.Text = "Monthly Report"
        '
        'titlebar_addbook
        '
        Me.titlebar_addbook.BackColor = System.Drawing.Color.Olive
        Me.titlebar_addbook.Location = New System.Drawing.Point(8, 6)
        Me.titlebar_addbook.Margin = New System.Windows.Forms.Padding(4)
        Me.titlebar_addbook.Name = "titlebar_addbook"
        Me.titlebar_addbook.Size = New System.Drawing.Size(749, 69)
        Me.titlebar_addbook.TabIndex = 4
        Me.titlebar_addbook.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.expense_amount_number)
        Me.GroupBox1.Controls.Add(Me.sale_amount_number)
        Me.GroupBox1.Controls.Add(Me.expense_amount)
        Me.GroupBox1.Controls.Add(Me.sale_amout)
        Me.GroupBox1.Controls.Add(Me.bt_search)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_to)
        Me.GroupBox1.Controls.Add(Me.dateTo)
        Me.GroupBox1.Controls.Add(Me.dateFrom)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_from)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(749, 308)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'expense_amount_number
        '
        Me.expense_amount_number.AutoSize = True
        Me.expense_amount_number.BackColor = System.Drawing.Color.Chocolate
        Me.expense_amount_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expense_amount_number.ForeColor = System.Drawing.SystemColors.Control
        Me.expense_amount_number.Location = New System.Drawing.Point(329, 239)
        Me.expense_amount_number.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.expense_amount_number.Name = "expense_amount_number"
        Me.expense_amount_number.Size = New System.Drawing.Size(96, 29)
        Me.expense_amount_number.TabIndex = 8
        Me.expense_amount_number.Text = "15,000"
        Me.expense_amount_number.Visible = False
        '
        'sale_amount_number
        '
        Me.sale_amount_number.AutoSize = True
        Me.sale_amount_number.BackColor = System.Drawing.Color.Chocolate
        Me.sale_amount_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sale_amount_number.ForeColor = System.Drawing.SystemColors.Control
        Me.sale_amount_number.Location = New System.Drawing.Point(329, 166)
        Me.sale_amount_number.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sale_amount_number.Name = "sale_amount_number"
        Me.sale_amount_number.Size = New System.Drawing.Size(96, 29)
        Me.sale_amount_number.TabIndex = 7
        Me.sale_amount_number.Text = "15,000"
        Me.sale_amount_number.Visible = False
        '
        'expense_amount
        '
        Me.expense_amount.AutoSize = True
        Me.expense_amount.BackColor = System.Drawing.Color.Chocolate
        Me.expense_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expense_amount.Location = New System.Drawing.Point(19, 242)
        Me.expense_amount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.expense_amount.Name = "expense_amount"
        Me.expense_amount.Size = New System.Drawing.Size(252, 25)
        Me.expense_amount.TabIndex = 6
        Me.expense_amount.Text = "Monthly Expenses Amount:"
        '
        'sale_amout
        '
        Me.sale_amout.AutoSize = True
        Me.sale_amout.BackColor = System.Drawing.Color.Chocolate
        Me.sale_amout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sale_amout.Location = New System.Drawing.Point(19, 169)
        Me.sale_amout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sale_amout.Name = "sale_amout"
        Me.sale_amout.Size = New System.Drawing.Size(215, 25)
        Me.sale_amout.TabIndex = 5
        Me.sale_amout.Text = "Monthly Sales Amount:"
        '
        'bt_search
        '
        Me.bt_search.BackColor = System.Drawing.Color.Khaki
        Me.bt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search.Location = New System.Drawing.Point(307, 81)
        Me.bt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(132, 43)
        Me.bt_search.TabIndex = 4
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = False
        '
        'DateTimePicker_to
        '
        Me.DateTimePicker_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_to.Location = New System.Drawing.Point(520, 17)
        Me.DateTimePicker_to.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_to.Name = "DateTimePicker_to"
        Me.DateTimePicker_to.Size = New System.Drawing.Size(216, 30)
        Me.DateTimePicker_to.TabIndex = 3
        '
        'dateTo
        '
        Me.dateTo.AutoSize = True
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Location = New System.Drawing.Point(476, 20)
        Me.dateTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(42, 25)
        Me.dateTo.TabIndex = 2
        Me.dateTo.Text = "To:"
        '
        'dateFrom
        '
        Me.dateFrom.AutoSize = True
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Location = New System.Drawing.Point(8, 20)
        Me.dateFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(176, 25)
        Me.dateFrom.TabIndex = 1
        Me.dateFrom.Text = "Choose Date from:"
        '
        'DateTimePicker_from
        '
        Me.DateTimePicker_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_from.Location = New System.Drawing.Point(207, 17)
        Me.DateTimePicker_from.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_from.Name = "DateTimePicker_from"
        Me.DateTimePicker_from.Size = New System.Drawing.Size(216, 30)
        Me.DateTimePicker_from.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Chocolate
        Me.PictureBox1.Location = New System.Drawing.Point(13, 156)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(724, 126)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(765, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.monthlyreport_title)
        Me.Controls.Add(Me.titlebar_addbook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MonthlyReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonthlyReport"
        Me.TopMost = True
        CType(Me.titlebar_addbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents monthlyreport_title As Label
    Friend WithEvents titlebar_addbook As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bt_search As Button
    Friend WithEvents DateTimePicker_to As DateTimePicker
    Friend WithEvents dateTo As Label
    Friend WithEvents dateFrom As Label
    Friend WithEvents DateTimePicker_from As DateTimePicker
    Friend WithEvents expense_amount_number As Label
    Friend WithEvents sale_amount_number As Label
    Friend WithEvents expense_amount As Label
    Friend WithEvents sale_amout As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
