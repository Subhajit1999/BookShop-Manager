Imports System.Data.OleDb

Public Class ManageSales
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim paid As String = "No"
    Dim invoiceId As Integer
    Dim str, message As String

    Private Sub ManageSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rd_no.Checked = True                          ' Paid by default checked to No
        provider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dataFile = "Data Source = F:\Visual Studio\Project\BookShopManager\BooksDatabase.mdb"
        conString = provider & dataFile
        dataConnection.ConnectionString = conString


    End Sub

    Private Sub bt_add_sale_Click(sender As Object, e As EventArgs) Handles bt_add_sale.Click
        Try
            dataConnection.Open()
            Str = "Insert into SalesReport([InvoiceId],[SaleDate],[CustomerName],[Address],[MobileNo],[BookTitle],[Quantity],[Discount],[TotalPrice],[AmountPaid]) Values(?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            cmd.Parameters.Add(New OleDbParameter("InvoiceId", CType(tb_sales_id.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("SaleDate", CType(DateTimePicker_sales.Value.ToShortDateString, String)))
            cmd.Parameters.Add(New OleDbParameter("CustomerName", CType(tb_customer_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(tb_address.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("MobileNo", CType(tb_mobile_no.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BookTitle", CType(tb_book_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Quantity", CType(tb_quantity.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Discount", CType(tb_discount.Text, Double)))
            cmd.Parameters.Add(New OleDbParameter("TotalPrice", CType(tb_total_price.Text, Double)))
            cmd.Parameters.Add(New OleDbParameter("AmountPaid", CType(paid, String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            invoiceId = Val(tb_sales_id.Text)
            tb_sales_id.Clear()
            DateTimePicker_sales.ResetText()
            tb_customer_name.Clear()
            tb_address.Clear()
            tb_mobile_no.Clear()
            tb_book_name.Clear()
            tb_quantity.Clear()
            tb_discount.Clear()
            tb_total_price.Clear()
            rd_yes.Checked = False
            rd_no.Checked = False
            MsgBox("Record of Invoice Id: " & invoiceId & " is successfully added to the Database.")
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bt_update_sale_Click(sender As Object, e As EventArgs) Handles bt_update_sale.Click
        str = "Update [SalesReport] set [SaleDate]='" & DateTimePicker_sales.Value.ToShortDateString & "',[CustomerName]='" & tb_customer_name.Text & "',[Address]='" & tb_address.Text & "',[MobileNo]='" & tb_mobile_no.Text & "',[BookTitle]='" & tb_book_name.Text & "',[Quantity]='" & tb_quantity.Text & "',[Discount]='" & tb_discount.Text & "',[TotalPrice]='" & tb_total_price.Text & "',[AmountPaid]='" & paid & "' Where [InvoiceId]=" & Val(tb_sales_id.Text) & ""
        invoiceId = Val(tb_sales_id.Text)
        message = "Record of Invoice Id: " & invoiceId & " is successfully daleted from the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_delete_sale_Click(sender As Object, e As EventArgs) Handles bt_delete_sale.Click
        str = "Delete from [SalesReport] Where [InvoiceId]=" & Val(tb_sales_id.Text) & ""
        invoiceId = Val(tb_sales_id.Text)
        message = "Record of Invoice Id: " & invoiceId & " is successfully daleted from the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub

    Private Sub rd_yes_CheckedChanged(sender As Object, e As EventArgs) Handles rd_yes.CheckedChanged
        If rd_yes.Checked = True Then
            rd_no.Checked = False
            paid = "Yes"
        End If
    End Sub

    Private Sub rd_no_CheckedChanged(sender As Object, e As EventArgs) Handles rd_no.CheckedChanged
        If rd_no.Checked = True Then
            rd_yes.Checked = False
            paid = "No"
        End If
    End Sub

    Private Sub tb_sales_id_TextChanged(sender As Object, e As EventArgs) Handles tb_sales_id.TextChanged
        Try
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            str = "Select * from SalesReport Where InvoiceId=" & Int(tb_sales_id.Text) & ""
            da = New OleDbDataAdapter(Str, dataConnection)
            da.Fill(dt)

            DateTimePicker_sales.Text = dt.Rows(0).Item(1)
            tb_customer_name.Text = dt.Rows(0).Item(2)
            tb_address.Text = dt.Rows(0).Item(3)
            tb_mobile_no.Text = dt.Rows(0).Item(4)
            tb_book_name.Text = dt.Rows(0).Item(5)
            tb_quantity.Text = dt.Rows(0).Item(6)
            tb_discount.Text = dt.Rows(0).Item(7)
            tb_total_price.Text = dt.Rows(0).Item(8)
            If dt.Rows(0).Item(9) = "Yes" Then
                rd_yes.Checked = True
            Else
                rd_no.Checked = False
            End If

            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
        If tb_sales_id.Text = "" Then
            DateTimePicker_sales.ResetText()
            tb_customer_name.Clear()
            tb_address.Clear()
            tb_mobile_no.Clear()
            tb_book_name.Clear()
            tb_quantity.Clear()
            tb_discount.Clear()
            tb_total_price.Clear()
            rd_yes.Checked = False
            rd_no.Checked = False
        End If
    End Sub
    Public Sub dataOPeration(str As String, message As String)
        Try
            dataConnection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            MsgBox(message)
            tb_sales_id.Clear()
            DateTimePicker_sales.ResetText()
            tb_customer_name.Clear()
            tb_address.Clear()
            tb_mobile_no.Clear()
            tb_book_name.Clear()
            tb_quantity.Clear()
            tb_discount.Clear()
            tb_total_price.Clear()
            rd_yes.Checked = False
            rd_no.Checked = False
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class