Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Form1
    Dim conn As New koneksiDatabase
    Sub tampil()
        Dim mycom As New MySqlCommand
        Dim myadap As New MySqlDataAdapter
        Dim mydata As New DataTable
        Dim sql As String

        If txtfind.Text <> "" Then
            sql = "SELECT * FROM students_view WHERE `student Name` LIKE '%" & txtfind.Text & "%'"
        Else
            sql = "SELECT * FROM students_view"
        End If
        Try
            mycom.Connection = conn.koneksi
            mycom.CommandText = sql
            myadap.SelectCommand = mycom
            myadap.Fill(mydata)
            DataGridView1.DataSource = mydata
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        Catch ex As Exception

        End Try
        mycom.Dispose()
        conn.koneksi.Close()
    End Sub
    Sub bersih()
        txtID.Text = ""
        txtname.Text = ""
        txtaddress.Text = ""
        txtcontact.Text = ""
        cbchoice.Text = ""
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim mycom As New MySqlCommand
        Dim sql As String
        Dim level As String
        Dim hasil As Integer
        sql = "INSERT INTO tablestudent (ID,name,address,contact,level,course)values (@ID, @name, @address, @contact, @level, @course)"
        Try
            If rblow.Checked Then
                level = rblow.Text
            ElseIf rbmedium.Checked Then
                level = rbmedium.Text
            Else
                level = rbhigh.Text
            End If

            mycom.Connection = conn.koneksi
            mycom.CommandText = sql
            mycom.Parameters.Add("@ID", MySqlDbType.String, 9).Value = txtID.Text
            mycom.Parameters.Add("@name", MySqlDbType.String, 50).Value = txtname.Text
            mycom.Parameters.Add("@address", MySqlDbType.String, 60).Value = txtaddress.Text
            mycom.Parameters.Add("@contact", MySqlDbType.String, 12).Value = txtcontact.Text
            mycom.Parameters.Add("@level", MySqlDbType.String, 20).Value = level
            mycom.Parameters.Add("@course", MySqlDbType.String, 30).Value = cbchoice.Text

            If MessageBox.Show("Yakin data ditambahkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                hasil = mycom.ExecuteNonQuery()
            Else
                hasil = 0
            End If


            If hasil > 0 Then
                MessageBox.Show("Data berhasil ditambahkan", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call tampil()
                Call bersih()
            End If
        Catch ex As Exception
        Finally
            mycom.Dispose()
            conn.koneksi.Close()
        End Try
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim mycom_cari As New MySqlCommand
        Dim cari As MySqlDataReader
        Dim query, level As String


        query = "SELECT ID, name,address,contact,level,course FROM tablestudent where ID='" & txtID.Text & "'"
        Try
            mycom_cari.Connection = conn.koneksi
            mycom_cari.CommandText = query
            cari = mycom_cari.ExecuteReader
            If cari.Read() Then
                txtname.Text = cari.GetString(1)
                txtaddress.Text = cari.GetString(2)
                txtcontact.Text = cari.GetString(3)
                level = cari.GetString(4)
                If level = rblow.Text Then
                    rblow.Checked = True
                ElseIf level = rbmedium.Text Then
                    rbmedium.Checked = True
                Else
                    rbhigh.Checked = True
                End If
                cbchoice.Text = cari.GetString(5)
            End If
            cari.Close()
        Catch ex As Exception

        End Try
        mycom_cari.Dispose()


    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim mycom As New MySqlCommand
        Dim query As String
        Dim hasil As Integer
        Dim level As String
        query = "UPDATE tablestudent SET ID= @ID, name=@name, address=@address,contact=@contact, level=@level, course=@course WHERE ID='" & txtID.Text & "'"
        Try
            If rblow.Checked Then
                level = rblow.Text
            ElseIf rbmedium.Checked Then
                level = rbmedium.Text
            Else
                level = rbhigh.Text
            End If

            mycom.Connection = conn.koneksi
            mycom.CommandText = query
            mycom.Parameters.Add("@ID", MySqlDbType.String, 9).Value = txtID.Text
            mycom.Parameters.Add("@name", MySqlDbType.String, 50).Value = txtname.Text
            mycom.Parameters.Add("@address", MySqlDbType.String, 60).Value = txtaddress.Text
            mycom.Parameters.Add("@contact", MySqlDbType.String, 12).Value = txtcontact.Text
            mycom.Parameters.Add("@level", MySqlDbType.String, 20).Value = level
            mycom.Parameters.Add("@course", MySqlDbType.String, 30).Value = cbchoice.Text
            If MessageBox.Show("Yakin data diupdate?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                hasil = mycom.ExecuteNonQuery()
            Else
                hasil = 0
            End If

            If hasil > 0 Then
                MessageBox.Show("Data berhasil diupdate", "update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtID.Text = ""
                txtname.Text = ""
                txtaddress.Text = ""
                txtcontact.Text = ""
                rblevel.Text = ""
                cbchoice.Text = ""
                Call tampil()
            End If
        Catch ex As Exception
        Finally
            mycom.Dispose()
            conn.koneksi.Close()
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim mycom As New MySqlCommand
        Dim sql As String
        Dim hasil As Integer
        sql = "DELETE FROM tablestudent WHERE ID='" & txtID.Text & "'"
        Try
            mycom.Connection = conn.koneksi
            mycom.CommandText = sql
            If MessageBox.Show("Yakin data dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                hasil = mycom.ExecuteNonQuery()
            Else
                hasil = 0
            End If

            If hasil > 0 Then
                MessageBox.Show("data berhasil dihapus", "hapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtID.Text = ""
                txtname.Text = ""
                txtaddress.Text = ""
                txtcontact.Text = ""
                Call tampil()
            End If
        Catch ex As Exception
        Finally
            mycom.Dispose()
            conn.koneksi.close()
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub

    Private Sub txtfind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfind.TextChanged
        Call tampil()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        FormLaporan.ShowDialog()
    End Sub
End Class


