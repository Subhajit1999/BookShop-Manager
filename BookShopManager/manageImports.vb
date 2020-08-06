Imports System.Data.OleDb

Public Class manageImports
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim str, message As String
    Dim transactId As Integer

    Private Sub manageImports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dataFile = "Data Source = F:\Visual Studio\Project\BookShopManager\BooksDatabase.mdb"
        conString = provider & dataFile
        dataConnection.ConnectionString = conString

        Try                                 'for adding categories dynamically from the database
            dataConnection.Open()
            str = "Select categories from Categories"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read()
                ComboBox_category.Items.Add(reader("categories"))
            End While
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub

    'Problem in adding purchase record
    Private Sub bt_add_purchase_Click(sender As Object, e As EventArgs) Handles bt_add_purchase.Click
        Try
            dataConnection.Open()
            Dim str As String
            str = "Insert into PurchaseReport([TransactID],[BookName],[PublisherName],[Category],[NoOfcopies],[TotalPrice],[PurchaseDate]) Values(?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            cmd.Parameters.Add(New OleDbParameter("TransactID", CType(tb_transact_id.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("BookName", CType(tb_book_title.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PublisherName", CType(tb_publisher_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Category", CType(ComboBox_category.SelectedItem.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("NoOfcopies", CType(tb_no_copies.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("TotalPrice", CType(tb_total_price.Text, Double)))
            cmd.Parameters.Add(New OleDbParameter("PurchaseDate", CType(DateTimePicker_purchase.Value.ToShortDateString, String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            MsgBox("Record of Transaction ID: " & tb_transact_id.Text & "successfully added to the Database.")
            tb_book_title.Clear()
            DateTimePicker_purchase.ResetText()
            tb_publisher_name.Clear()
            ComboBox_category.Text = ""
            tb_no_copies.Clear()
            tb_total_price.Clear()
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bt_update_purchase_Click(sender As Object, e As EventArgs) Handles bt_update_purchase.Click
        str = "Update [PurchaseReport] set [BookName]='" & tb_book_title.Text & "',[PublisherName]='" & tb_publisher_name.Text & "',[Category]='" & ComboBox_category.SelectedItem & "',[NoOfcopies]='" & tb_no_copies.Text & "',[TotalPrice]='" & tb_total_price.Text & "',[PurchaseDate]='" & DateTimePicker_purchase.Value.ToShortDateString & "' Where [TransactID]=" & Val(tb_transact_id.Text) & ""
        message = "Record of Transaction ID: " & tb_transact_id.Text & "successfully updated to the Database."
        dataOperation(str, message)
    End Sub

    Private Sub bt_delete_purchase_Click(sender As Object, e As EventArgs) Handles bt_delete_purchase.Click
        str = "Delete from [PurchaseReport] Where [TransactID]=" & Val(tb_transact_id.Text) & ""
        message = "Record of Transaction ID: " & tb_transact_id.Text & "successfully deleted from the Database."
        dataOperation(str, message)
    End Sub

    Private Sub tb_transact_id_TextChanged(sender As Object, e As EventArgs) Handles tb_transact_id.TextChanged
        Try
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            str = "Select * from PurchaseReport Where TransactID=" & Int(tb_transact_id.Text) & ""
            da = New OleDbDataAdapter(str, dataConnection)
            da.Fill(dt)

            tb_book_title.Text = dt.Rows(0).Item(1)
            tb_publisher_name.Text = dt.Rows(0).Item(2)
            ComboBox_category.Text = dt.Rows(0).Item(3)
            tb_no_copies.Text = dt.Rows(0).Item(4)
            tb_total_price.Text = dt.Rows(0).Item(5)
            DateTimePicker_purchase.Value = dt.Rows(0).Item(6)

            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
        If tb_transact_id.Text = "" Then
            tb_book_title.Clear()
            DateTimePicker_purchase.ResetText()
            tb_publisher_name.Clear()
            ComboBox_category.Text = ""
            tb_no_copies.Clear()
            tb_total_price.Clear()
        End If
    End Sub

    Public Sub dataOperation(str As String, message As String)
        Try
            dataConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            MsgBox(message)
            tb_book_title.Clear()
            DateTimePicker_purchase.ResetText()
            tb_publisher_name.Clear()
            ComboBox_category.Text = ""
            tb_no_copies.Clear()
            tb_total_price.Clear()
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class