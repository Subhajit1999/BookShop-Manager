﻿Imports System.Data.OleDb

Public Class SalesHistory
    Dim dataConnection As OleDbConnection = New OleDbConnection
    Dim provider As String
    Dim dataFile As String
    Dim conString As String


    Private Sub SalesHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dataFile = "Data Source = F:\Visual Studio\Project\BookShopManager\BooksDatabase.mdb"
        conString = provider & dataFile
        dataConnection.ConnectionString = conString

        Try
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            Dim cmd As String
            cmd = "select * from SalesReport"
            da = New OleDbDataAdapter(cmd, dataConnection)
            da.Fill(dt)
            table_searched_data.DataSource = dt.DefaultView
            dataConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            dataConnection.Close()
        End Try
    End Sub

    Private Sub bt_search_Click(sender As Object, e As EventArgs) Handles bt_search.Click
        Try
            dataConnection.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            Dim cmd As String
            If tb_search_by_id.Text <> "" Then
                cmd = "select * from SalesReport Where InvoiceId=" & Int(tb_search_by_id.Text) & ""
            ElseIf tb_search_customer.Text <> "" Then
                cmd = "select * from SalesReport Where CustomerName like '%" & tb_search_customer.Text & "%'"
            ElseIf DateTimePicker_searchSales.Value.ToShortDateString <> "" Then
                cmd = "select * from SalesReport Where SaleDate like '%" & DateTimePicker_searchSales.Value.ToShortDateString & "%'"
            Else

            End If
            da = New OleDbDataAdapter(cmd, dataConnection)
            da.Fill(dt)
            table_searched_data.DataSource = dt.DefaultView
            MsgBox("Data found from the Database.")

            dataConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            dataConnection.Close()
        End Try
    End Sub
End Class