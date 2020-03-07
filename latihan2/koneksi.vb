Imports MySql.Data.MySqlClient
Imports System.Data
Public Class koneksiDatabase
    Private conn As MySqlConnection = Nothing
    Public Function koneksi() As MySqlConnection
        Dim connString As String
        connString = ";server=localhost" & ";user=root" & ";password=''" & ";database=dbase_kelasc3"
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error..", "Gagal konek..", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
        Return conn
    End Function
End Class




