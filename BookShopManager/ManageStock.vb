Imports System.Data.OleDb

Public Class Manage_stock
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim BookId, BookName, str, message As String
    Dim check As Boolean = False

    Private Sub Manage_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dataFile = "Data Source = F:\Visual Studio\Project\BookShopManager\BooksDatabase.mdb"
        conString = provider & dataFile
        dataConnection.ConnectionString = conString
    End Sub

    Private Sub bt_search_Click(sender As Object, e As EventArgs) Handles bt_search.Click
        searchBookTitle()
        Try
            dataConnection.Open()
            str = "Select * from StockDetails"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read()
                If reader("BookID") = tb_enter_id.Text Then
                    BookId = tb_enter_id.Text
                    check = False
                    MsgBox("BookID: " & BookId & " of Book Name: " & reader("BookTitle") & " found in the Book Stocks.")
                    Exit While
                ElseIf reader("BookID") <> tb_enter_id.Text Then
                    check = True
                End If
            End While
            If check = True Then
                MsgBox("Book ID not found in the Book Stocks.")
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
    End Sub

    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        str = "Update [StockDetails] set [StocksAvailable]='" & Int(tb_no_of_copies.Text) & "'Where [BookID]=" & Int(tb_enter_id.Text) & ""
        message = "Record of Id: " & tb_enter_id.Text & " is successfully updated to the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        str = "Delete from [StockDetails] Where [BookID]=" & Val(tb_enter_id.Text) & ""
        message = "Record of Id: " & tb_enter_id.Text & " is successfully deleted from the Database."
        dataOPeration(str, message)
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        searchBookTitle()
        Try
            dataConnection.Open()
            Dim str As String
            BookId = tb_enter_id.Text
            str = "Insert into StockDetails([BookID],[BookTitle],[StocksAvailable],[LastUpdated]) Values(?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            cmd.Parameters.Add(New OleDbParameter("BookID", CType(BookId, Integer)))
            cmd.Parameters.Add(New OleDbParameter("BookTitle", CType(BookName, String)))
            cmd.Parameters.Add(New OleDbParameter("StocksAvailable", CType(tb_no_of_copies.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("LastUpdated", CType(Date.Now.ToString("dd-MM-yyyy"), String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields
            tb_enter_id.Clear()
            tb_no_of_copies.Clear()
            MsgBox("Stock Record of Id: " & BookId & " is successfully added to the DataBase.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub searchBookTitle()
        Try
            dataConnection.Open()
            str = "Select BookTitle from BookDetails Where BookID=" & Int(tb_enter_id.Text) & ""
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            reader.Read()
            BookName = reader("BookTitle")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()
        Catch ex As Exception
            dataConnection.Close()
        End Try
    End Sub

    Public Sub dataOPeration(str As String, message As String)   'common function of update & delete
        Try
            dataConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(str, dataConnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataConnection.Close()   'clears the fields

            MsgBox(message)
            tb_enter_id.Clear()
            tb_no_of_copies.Clear()
        Catch ex As Exception
            dataConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class