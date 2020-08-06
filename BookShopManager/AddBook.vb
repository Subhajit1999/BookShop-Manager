Imports System.Data.OleDb

Public Class AddBook
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim bookId As Integer
    Dim str As String

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bt_add_stock_Click(sender As Object, e As EventArgs) Handles bt_add_stock.Click
        Try
            dataConnection.Open()
            Str = "Insert into Bookdetails([BookID],[BookTitle],[AuthorName],[PublishYear],[PublisherName],[Category],[RackNo],[PricePerCopy]) Values(?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            cmd.Parameters.Add(New OleDbParameter("BookID", CType(tb_book_id.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("BookTitle", CType(tb_book_title.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("AuthorName", CType(tb_author_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PublishYear", CType(tb_publish_year.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("PublisherName", CType(tb_publisher_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Category", CType(ComboBox_category.SelectedItem, String)))
            cmd.Parameters.Add(New OleDbParameter("RackNo", CType(tb_rack_no.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("PricePerCopy", CType(tb_copy_price.Text, Integer)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            bookId = Val(tb_book_id.Text)
            MsgBox("Record of Id: " & bookId & " is successfully added to the DataBase.")
            tb_book_id.Clear()
            tb_book_title.Clear()
            tb_author_name.Clear()
            tb_publish_year.Clear()
            tb_publisher_name.Clear()
            tb_rack_no.Clear()
            tb_copy_price.Clear()
            ComboBox_category.Text = ""
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub
End Class