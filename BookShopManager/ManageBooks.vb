Imports System.Data.OleDb

Public Class ManageBooks
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim bookID As Integer
    Dim str, message As String

    Private Sub ManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        str = "Update [BookDetails] set [BookTitle]='" & tb_book_title.Text & "',[AuthorName]='" & tb_author_name.Text & "',[PublishYear]='" & tb_publish_year.Text & "',[PublisherName]='" & tb_publisher_name.Text & "',[Category]='" & ComboBox_category.Text & "',[RackNo]='" & tb_rack_no.Text & "',[PricePerCopy]='" & tb_copy_price.Text & "' Where [BookID]=" & Val(tb_book_id.Text) & ""
        bookID = Val(tb_book_id.Text)
        message = "Record of Id: " & bookID & " is successfully updated to the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        str = "Delete from [BookDetails] Where [BookID]=" & Val(tb_book_id.Text) & ""
        bookID = Val(tb_book_id.Text)
        message = "Record of Id: " & bookID & " is successfully deleted from the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub tb_book_id_TextChanged(sender As Object, e As EventArgs) Handles tb_book_id.TextChanged
        Try
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            str = "Select * from BookDetails Where BookID=" & Int(tb_book_id.Text) & ""
            da = New OleDbDataAdapter(str, dataConnection)
            da.Fill(dt)

            tb_book_title.Text = dt.Rows(0).Item(1)
            tb_author_name.Text = dt.Rows(0).Item(2)
            tb_publish_year.Text = dt.Rows(0).Item(3)
            tb_publisher_name.Text = dt.Rows(0).Item(4)
            ComboBox_category.Text = dt.Rows(0).Item(5)
            tb_rack_no.Text = dt.Rows(0).Item(6)
            tb_copy_price.Text = dt.Rows(0).Item(7)

            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
        If tb_book_id.Text = "" Then
            tb_book_title.Clear()
            tb_author_name.Clear()
            tb_publish_year.Clear()
            tb_publisher_name.Clear()
            tb_rack_no.Clear()
            tb_copy_price.Clear()
            ComboBox_category.Text = ""
        End If
    End Sub

    Public Sub dataOPeration(str As String, message As String)   'common function of update & delete
        Try
            dataConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields

            MsgBox(message)
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
End Class