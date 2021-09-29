Imports System.Data.OleDb
Module vt
    Function Baglan() As OleDbConnection
        Dim baglanti = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "/ogrDatabase.mdb")
        baglanti.Open()
        Return baglanti
    End Function

    Function dtGetir(ByVal sql As String) As DataTable
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd = New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp = New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim dt As New DataTable
        adp.Fill(dt)
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        adp.Dispose()

        Return dt
    End Function
    Function sqlCalistir(ByVal sql As String) As Boolean
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd = New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function
    Function kayitSayisi(ByVal sql As String) As Integer

        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd = New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp = New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim dt As New DataTable
        adp.Fill(dt)
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        adp.Dispose()
        Return dt.Rows.Count
    End Function
End Module
