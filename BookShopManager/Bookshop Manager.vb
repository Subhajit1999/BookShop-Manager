Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub bt_add_book_Click(sender As Object, e As EventArgs) Handles bt_add_book.Click
        Dim addBook As New AddBook   'Access to addBook form
        addBook.Show()
        addBook.TopMost = True
    End Sub

    Private Sub bt_manage_book_Click(sender As Object, e As EventArgs) Handles bt_manage_book.Click
        Dim manageBook As New ManageBooks    'Access to manageBook form
        manageBook.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_date.Text = Date.Now.ToString("dd MMM yyyy, dddd")  'Shows current date
        label_time.Text = DateTime.Now.ToString("hh:mm:ss tt")    'Shows current time in am/pm format using timer control
    End Sub

    Private Sub bt_search_book_Click(sender As Object, e As EventArgs) Handles bt_search_book.Click
        Dim searcBooks As New SearchBook
        SearchBook.Show()
    End Sub

    Private Sub bt_manage_sales_Click(sender As Object, e As EventArgs) Handles bt_manage_sales.Click
        Dim manageSale As New ManageSales
        manageSale.Show()
    End Sub

    Private Sub bt_sales_history_Click(sender As Object, e As EventArgs) Handles bt_sales_history.Click
        Dim saleHistory As New SalesHistory
        saleHistory.Show()
    End Sub

    Private Sub bt_manage_stock_Click(sender As Object, e As EventArgs) Handles bt_manage_stock.Click
        Dim manageStock As New Manage_stock
        manageStock.Show()
    End Sub

    Private Sub bt_search_stock_Click(sender As Object, e As EventArgs) Handles bt_search_stock.Click
        Dim searchStock As New SearchStock
        searchStock.Show()
    End Sub

    Private Sub bt_manage_imports_Click(sender As Object, e As EventArgs) Handles bt_manage_imports.Click
        Dim manage_imports As New manageImports
        manage_imports.Show()
    End Sub

    Private Sub bt_monthly_report_Click(sender As Object, e As EventArgs) Handles bt_monthly_report.Click
        Dim monthlyReport As New MonthlyReport
        monthlyReport.Show()
    End Sub

    Private Sub bt_calculator_Click(sender As Object, e As EventArgs) Handles bt_calculator.Click
        Dim cal As New calculator
        cal.Show()
    End Sub
End Class
