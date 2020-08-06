<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchStock))
        Me.searchstock_title = New System.Windows.Forms.Label()
        Me.table_searched_data = New System.Windows.Forms.DataGridView()
        Me.titleBar_manageSales = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_search_by_name = New System.Windows.Forms.TextBox()
        Me.search_by_name = New System.Windows.Forms.Label()
        Me.tb_search_by_id = New System.Windows.Forms.TextBox()
        Me.search_by_id = New System.Windows.Forms.Label()
        CType(Me.table_searched_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchstock_title
        '
        Me.searchstock_title.AutoSize = True
        Me.searchstock_title.BackColor = System.Drawing.Color.Olive
        Me.searchstock_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchstock_title.ForeColor = System.Drawing.SystemColors.Control
        Me.searchstock_title.Location = New System.Drawing.Point(36, 17)
        Me.searchstock_title.Name = "searchstock_title"
        Me.searchstock_title.Size = New System.Drawing.Size(241, 42)
        Me.searchstock_title.TabIndex = 21
        Me.searchstock_title.Text = "Search Stock"
        '
        'table_searched_data
        '
        Me.table_searched_data.BackgroundColor = System.Drawing.Color.Chocolate
        Me.table_searched_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_searched_data.Location = New System.Drawing.Point(8, 231)
        Me.table_searched_data.Margin = New System.Windows.Forms.Padding(4)
        Me.table_searched_data.Name = "table_searched_data"
        Me.table_searched_data.Size = New System.Drawing.Size(584, 273)
        Me.table_searched_data.TabIndex = 22
        '
        'titleBar_manageSales
        '
        Me.titleBar_manageSales.BackColor = System.Drawing.Color.Olive
        Me.titleBar_manageSales.Location = New System.Drawing.Point(8, 4)
        Me.titleBar_manageSales.Margin = New System.Windows.Forms.Padding(4)
        Me.titleBar_manageSales.Name = "titleBar_manageSales"
        Me.titleBar_manageSales.Size = New System.Drawing.Size(584, 69)
        Me.titleBar_manageSales.TabIndex = 23
        Me.titleBar_manageSales.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.bt_search)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_search_by_name)
        Me.GroupBox1.Controls.Add(Me.search_by_name)
        Me.GroupBox1.Controls.Add(Me.tb_search_by_id)
        Me.GroupBox1.Controls.Add(Me.search_by_id)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(584, 146)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'bt_search
        '
        Me.bt_search.BackColor = System.Drawing.Color.Khaki
        Me.bt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search.Location = New System.Drawing.Point(435, 47)
        Me.bt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(133, 52)
        Me.bt_search.TabIndex = 5
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(83, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "or"
        '
        'tb_search_by_name
        '
        Me.tb_search_by_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search_by_name.Location = New System.Drawing.Point(233, 89)
        Me.tb_search_by_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search_by_name.Name = "tb_search_by_name"
        Me.tb_search_by_name.Size = New System.Drawing.Size(192, 30)
        Me.tb_search_by_name.TabIndex = 3
        '
        'search_by_name
        '
        Me.search_by_name.AutoSize = True
        Me.search_by_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_by_name.Location = New System.Drawing.Point(7, 92)
        Me.search_by_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.search_by_name.Name = "search_by_name"
        Me.search_by_name.Size = New System.Drawing.Size(211, 25)
        Me.search_by_name.TabIndex = 2
        Me.search_by_name.Text = "Search by Book name:"
        '
        'tb_search_by_id
        '
        Me.tb_search_by_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search_by_id.Location = New System.Drawing.Point(233, 26)
        Me.tb_search_by_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search_by_id.Name = "tb_search_by_id"
        Me.tb_search_by_id.Size = New System.Drawing.Size(192, 30)
        Me.tb_search_by_id.TabIndex = 1
        '
        'search_by_id
        '
        Me.search_by_id.AutoSize = True
        Me.search_by_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_by_id.Location = New System.Drawing.Point(7, 30)
        Me.search_by_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.search_by_id.Name = "search_by_id"
        Me.search_by_id.Size = New System.Drawing.Size(181, 25)
        Me.search_by_id.TabIndex = 0
        Me.search_by_id.Text = "Search by Book ID:"
        '
        'SearchStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.table_searched_data)
        Me.Controls.Add(Me.searchstock_title)
        Me.Controls.Add(Me.titleBar_manageSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SearchStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchStock"
        Me.TopMost = True
        CType(Me.table_searched_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.titleBar_manageSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchstock_title As Label
    Friend WithEvents table_searched_data As DataGridView
    Friend WithEvents titleBar_manageSales As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents search_by_id As Label
    Friend WithEvents tb_search_by_name As TextBox
    Friend WithEvents search_by_name As Label
    Friend WithEvents tb_search_by_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_search As Button
End Class
