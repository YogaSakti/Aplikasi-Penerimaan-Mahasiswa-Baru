Imports System.Data.Odbc
Public Class Form1
    Const DSN = "DSN=pmb"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable

    Sub koneksi()
        conn = New OdbcConnection(DSN)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub tampilkan_data()
        koneksi()
        da = New OdbcDataAdapter("select * from data_pmb", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DVG.DataSource = table
        conn.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
    End Sub
    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles Btn_simpan.Click
        Try
            koneksi()
            cmd = New OdbcCommand("select * from data_pmb where nisn = '" & Tnisn.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then

                koneksi()
                cmd = New OdbcCommand("insert into data_pmb values (?, ?, ?, ?)", conn)
                With cmd
                    .Parameters.AddWithValue("?", Tnisn.Text)
                    .Parameters.AddWithValue("?", Tnama.Text)
                    .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                    .Parameters.AddWithValue("?", TextAlamat.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()

            Else

                koneksi()
                cmd = New OdbcCommand("update mahasiswa set nama=?, jenis_kelamin=?, alamat=? where nim=?", conn)
                With cmd
                    .Parameters.AddWithValue("?", TextNama.Text)
                    .Parameters.AddWithValue("?", TextJenis_Kelamin.Text)
                    .Parameters.AddWithValue("?", TextAlamat.Text)
                    .Parameters.AddWithValue("?", TextNIM.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()

            End If

            tampilkan_data()

            TextNIM.Text = ""
            TextNama.Text = ""
            TextJenis_Kelamin.Text = ""
            TextAlamat.Text = ""
            TextNIM.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
