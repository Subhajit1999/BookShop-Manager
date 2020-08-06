Imports System.Data.OleDb

Public Class MonthlyReport
    Private Sub bt_search_Click(sender As Object, e As EventArgs) Handles bt_search.Click
        Dim dataConnection As OleDbConnection = New OleDbConnection
        Dim provider As String
        Dim dataFile As String
        Dim conString As String
        Dim str As String
        Dim TotalSale As Integer = 0
        Dim TotalPurchase As Integer = 0

        provider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dataFile = "Data Source = F:\Visual Studio\Project\BookShopManager\BooksDatabase.mdb"
        conString = provider & dataFile
        dataConnection.ConnectionString = conString

        Dim dtFrom As DateTime = DateTime.Parse(DateTimePicker_from.Text)
        Dim dtTo As DateTime = DateTime.Parse(DateTimePicker_to.Text)


        Try                   'for monthly total sale
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            Dim cmd As New OleDbCommand("SELECT * FROM [SalesReport] WHERE [SaleDate] Between ? And ?", dataConnection)
            cmd.Parameters.AddWithValue("?", DateTimePicker_from.Value.ToString)
            cmd.Parameters.AddWithValue("?", DateTimePicker_to.Value.ToString)

            da = New OleDbDataAdapter(cmd)
            da.Fill(dt)
            Dim n As Integer = 0
            While n < dt.Rows.Count
                TotalSale = TotalSale + Int(dt.Rows(n).Item(8))
                n = n + 1
            End While
            sale_amount_number.Visible = True
            sale_amount_number.Text = "Rs. " & TotalSale
            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try

        Try                        'for monthly total expense
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            Dim cmd As New OleDbCommand("SELECT * FROM [PurchaseReport] WHERE [PurchaseDate] Between ? And ?", dataConnection)
            cmd.Parameters.AddWithValue("?", DateTimePicker_from.Value.ToString)
            cmd.Parameters.AddWithValue("?", DateTimePicker_to.Value.ToString)

            da = New OleDbDataAdapter(cmd)
            da.Fill(dt)
            Dim n As Integer = 0
            While n < dt.Rows.Count
                TotalPurchase = TotalPurchase + Int(dt.Rows(n).Item(5))
                n = n + 1
            End While
            expense_amount_number.Visible = True
            expense_amount_number.Text = "Rs. " & TotalPurchase
            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class