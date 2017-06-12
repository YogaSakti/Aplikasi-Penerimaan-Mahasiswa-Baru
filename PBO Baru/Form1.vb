Imports System.Data.Odbc
Public Class Form1
    Const DSN = "DSN=pmb"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable

    Sub Bersikan()
        Tnisn.Text = ""
        Tnama.Text = ""
        Ttmplhr.Text = ""
        Dtgllahir.Value = Now
        Cagama.Text = ""
        CJnsKel.Text = ""
        Talmt.Text = ""
        Tnohp.Text = ""
        Temail.Text = ""
        Taslskl.Text = ""
        Cplh1.Text = ""
        Cplh2.Text = ""
        Cjlrpend.Text = ""

    End Sub
    Sub Baru()
        tampilkan_data()
        otomatis()
        Bersikan()
    End Sub

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
    Sub otomatis()
        Dim oto As String = "DFT" + Format(Now, "ddMMyyh")
        Tnopendaftaran.Text = oto
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baru()
    End Sub
    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles Btn_simpan.Click
        If Tnisn.Text = "" Or Tnama.Text = "" Or Ttmplhr.Text = "" Or Dtgllahir.Value = Now Or Cagama.Text = "" Or CJnsKel.Text = "" Or Talmt.Text = "" Or Tnohp.Text = "" Or Temail.Text = "" Or Taslskl.Text = "" Or Cplh1.Text = "" Or Cplh2.Text = "" Or Cjlrpend.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu")
            Tnisn.Focus()
        Else
            koneksi()
            cmd = New OdbcCommand("insert into data_pmb values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
            With cmd
                .Parameters.AddWithValue("?", Tnisn.Text)
                .Parameters.AddWithValue("?", Tnama.Text)
                .Parameters.AddWithValue("?", Ttmplhr.Text)
                .Parameters.AddWithValue("?", Dtgllahir.Value)
                .Parameters.AddWithValue("?", CJnsKel.Text)
                .Parameters.AddWithValue("?", Cagama.Text)
                .Parameters.AddWithValue("?", Talmt.Text)
                .Parameters.AddWithValue("?", Tnohp.Text)
                .Parameters.AddWithValue("?", Temail.Text)
                .Parameters.AddWithValue("?", Taslskl.Text)
                .Parameters.AddWithValue("?", Cplh1.Text)
                .Parameters.AddWithValue("?", Cplh2.Text)
                .Parameters.AddWithValue("?", Cjlrpend.Text)
                .Parameters.AddWithValue("?", Tnopendaftaran.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
            Baru()
        End If
    End Sub

    Private Sub DVG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVG.CellContentClick, DVG.CellContentDoubleClick
        Dim baris As Integer
        baris = DVG.CurrentRow.Index
        koneksi()
        cmd = New OdbcCommand("SELECT * FROM data_pmb WHERE NISN = '" & DVG.Item(0, baris).Value & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            Tnisn.Text = dr(0).ToString
            Tnama.Text = dr(1).ToString
            Ttmplhr.Text = dr(2).ToString
            Dtgllahir.Text = dr(3).ToString
            CJnsKel.Text = dr(4).ToString
            Cagama.Text = dr(5).ToString
            Talmt.Text = dr(6).ToString
            Tnohp.Text = dr(7).ToString
            Temail.Text = dr(8).ToString
            Taslskl.Text = dr(9).ToString
            Tnopendaftaran.Text = dr(13).ToString
            Cplh1.Text = dr(10).ToString
            Cplh2.Text = dr(11).ToString
            Cjlrpend.Text = dr(12).ToString

            Tnisn.Focus()
        End If
        dr.Close()
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub Btn_reset_Click(sender As Object, e As EventArgs) Handles Btn_reset.Click
        Baru()
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If Tnisn.Text = "" Then
            MsgBox("Masukan Nisn")
        ElseIf MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            koneksi()
                cmd = New OdbcCommand("Delete from data_pmb Where NISN = '" & Tnisn.Text & "'", conn)
                cmd.ExecuteNonQuery()
            conn.Close()
        End If
        Baru()
    End Sub

    Private Sub Tfilter_TextChanged(sender As Object, e As EventArgs) Handles Tfilter.TextChanged
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM data_pmb WHERE NISN LIKE '%" + Tfilter.Text + "%'", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_pmb")
        table = ds.Tables("data_pmb")
        DVG.DataSource = table
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Report.Show()
    End Sub
End Class
