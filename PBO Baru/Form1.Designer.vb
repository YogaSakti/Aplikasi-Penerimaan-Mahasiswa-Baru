﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tnisn = New System.Windows.Forms.TextBox()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Ttmplhr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CJnsKel = New System.Windows.Forms.ComboBox()
        Me.Taslskl = New System.Windows.Forms.TextBox()
        Me.Cagama = New System.Windows.Forms.ComboBox()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Dtgllahir = New System.Windows.Forms.DateTimePicker()
        Me.Tnohp = New System.Windows.Forms.TextBox()
        Me.Talmt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cjlrpend = New System.Windows.Forms.ComboBox()
        Me.Cplh2 = New System.Windows.Forms.ComboBox()
        Me.Tnopendaftaran = New System.Windows.Forms.TextBox()
        Me.Cplh1 = New System.Windows.Forms.ComboBox()
        Me.DVG = New System.Windows.Forms.DataGridView()
        Me.Btn_simpan = New System.Windows.Forms.Button()
        Me.Btn_reset = New System.Windows.Forms.Button()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Tfilter = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PmbDataSet1 = New PBO_Baru.pmbDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DVG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat Lengkap"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "No Hp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Asal Sekolah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No Pendaftaran"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Pilihan 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Jalur Pendaftaran"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Pilihan 2"
        '
        'Tnisn
        '
        Me.Tnisn.Location = New System.Drawing.Point(90, 22)
        Me.Tnisn.Name = "Tnisn"
        Me.Tnisn.Size = New System.Drawing.Size(168, 20)
        Me.Tnisn.TabIndex = 14
        '
        'Tnama
        '
        Me.Tnama.Location = New System.Drawing.Point(90, 48)
        Me.Tnama.Name = "Tnama"
        Me.Tnama.Size = New System.Drawing.Size(168, 20)
        Me.Tnama.TabIndex = 15
        '
        'Ttmplhr
        '
        Me.Ttmplhr.Location = New System.Drawing.Point(90, 74)
        Me.Ttmplhr.Name = "Ttmplhr"
        Me.Ttmplhr.Size = New System.Drawing.Size(168, 20)
        Me.Ttmplhr.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CJnsKel)
        Me.GroupBox1.Controls.Add(Me.Taslskl)
        Me.GroupBox1.Controls.Add(Me.Cagama)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Temail)
        Me.GroupBox1.Controls.Add(Me.Dtgllahir)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Tnohp)
        Me.GroupBox1.Controls.Add(Me.Tnisn)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Talmt)
        Me.GroupBox1.Controls.Add(Me.Ttmplhr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tnama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 323)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'CJnsKel
        '
        Me.CJnsKel.FormattingEnabled = True
        Me.CJnsKel.Items.AddRange(New Object() {"Laki Laki", "Perempuan"})
        Me.CJnsKel.Location = New System.Drawing.Point(90, 125)
        Me.CJnsKel.Name = "CJnsKel"
        Me.CJnsKel.Size = New System.Drawing.Size(102, 21)
        Me.CJnsKel.TabIndex = 21
        '
        'Taslskl
        '
        Me.Taslskl.Location = New System.Drawing.Point(90, 289)
        Me.Taslskl.Name = "Taslskl"
        Me.Taslskl.Size = New System.Drawing.Size(168, 20)
        Me.Taslskl.TabIndex = 20
        '
        'Cagama
        '
        Me.Cagama.FormattingEnabled = True
        Me.Cagama.Items.AddRange(New Object() {"ISLAM", "KATOLIK", "KRISTEN", "HINDU", "BUDHA", "KONGHUCHU"})
        Me.Cagama.Location = New System.Drawing.Point(90, 150)
        Me.Cagama.Name = "Cagama"
        Me.Cagama.Size = New System.Drawing.Size(102, 21)
        Me.Cagama.TabIndex = 20
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(90, 263)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(168, 20)
        Me.Temail.TabIndex = 19
        '
        'Dtgllahir
        '
        Me.Dtgllahir.CustomFormat = "dd-MM-yyyy"
        Me.Dtgllahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtgllahir.Location = New System.Drawing.Point(90, 100)
        Me.Dtgllahir.Name = "Dtgllahir"
        Me.Dtgllahir.Size = New System.Drawing.Size(102, 20)
        Me.Dtgllahir.TabIndex = 17
        '
        'Tnohp
        '
        Me.Tnohp.Location = New System.Drawing.Point(90, 237)
        Me.Tnohp.Name = "Tnohp"
        Me.Tnohp.Size = New System.Drawing.Size(168, 20)
        Me.Tnohp.TabIndex = 18
        '
        'Talmt
        '
        Me.Talmt.Location = New System.Drawing.Point(90, 177)
        Me.Talmt.Multiline = True
        Me.Talmt.Name = "Talmt"
        Me.Talmt.Size = New System.Drawing.Size(168, 54)
        Me.Talmt.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cjlrpend)
        Me.GroupBox2.Controls.Add(Me.Cplh2)
        Me.GroupBox2.Controls.Add(Me.Tnopendaftaran)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Cplh1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 143)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pendartaran"
        '
        'Cjlrpend
        '
        Me.Cjlrpend.FormattingEnabled = True
        Me.Cjlrpend.Location = New System.Drawing.Point(107, 102)
        Me.Cjlrpend.Name = "Cjlrpend"
        Me.Cjlrpend.Size = New System.Drawing.Size(121, 21)
        Me.Cjlrpend.TabIndex = 22
        '
        'Cplh2
        '
        Me.Cplh2.FormattingEnabled = True
        Me.Cplh2.Location = New System.Drawing.Point(107, 75)
        Me.Cplh2.Name = "Cplh2"
        Me.Cplh2.Size = New System.Drawing.Size(121, 21)
        Me.Cplh2.TabIndex = 15
        '
        'Tnopendaftaran
        '
        Me.Tnopendaftaran.Location = New System.Drawing.Point(107, 22)
        Me.Tnopendaftaran.Name = "Tnopendaftaran"
        Me.Tnopendaftaran.ReadOnly = True
        Me.Tnopendaftaran.Size = New System.Drawing.Size(121, 20)
        Me.Tnopendaftaran.TabIndex = 21
        '
        'Cplh1
        '
        Me.Cplh1.FormattingEnabled = True
        Me.Cplh1.Location = New System.Drawing.Point(107, 48)
        Me.Cplh1.Name = "Cplh1"
        Me.Cplh1.Size = New System.Drawing.Size(121, 21)
        Me.Cplh1.TabIndex = 14
        '
        'DVG
        '
        Me.DVG.AllowUserToAddRows = False
        Me.DVG.AllowUserToDeleteRows = False
        Me.DVG.AllowUserToOrderColumns = True
        Me.DVG.AllowUserToResizeColumns = False
        Me.DVG.AllowUserToResizeRows = False
        Me.DVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVG.Location = New System.Drawing.Point(12, 342)
        Me.DVG.Name = "DVG"
        Me.DVG.ReadOnly = True
        Me.DVG.Size = New System.Drawing.Size(513, 165)
        Me.DVG.TabIndex = 19
        '
        'Btn_simpan
        '
        Me.Btn_simpan.Location = New System.Drawing.Point(12, 7)
        Me.Btn_simpan.Name = "Btn_simpan"
        Me.Btn_simpan.Size = New System.Drawing.Size(96, 52)
        Me.Btn_simpan.TabIndex = 20
        Me.Btn_simpan.Text = "Simpan "
        Me.Btn_simpan.UseVisualStyleBackColor = True
        '
        'Btn_reset
        '
        Me.Btn_reset.Location = New System.Drawing.Point(114, 7)
        Me.Btn_reset.Name = "Btn_reset"
        Me.Btn_reset.Size = New System.Drawing.Size(109, 23)
        Me.Btn_reset.TabIndex = 21
        Me.Btn_reset.Text = "Reset"
        Me.Btn_reset.UseVisualStyleBackColor = True
        '
        'Btn_delete
        '
        Me.Btn_delete.Location = New System.Drawing.Point(114, 36)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(109, 23)
        Me.Btn_delete.TabIndex = 23
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = True
        '
        'Tfilter
        '
        Me.Tfilter.Location = New System.Drawing.Point(289, 298)
        Me.Tfilter.Name = "Tfilter"
        Me.Tfilter.Size = New System.Drawing.Size(62, 20)
        Me.Tfilter.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(286, 278)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Filter: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PmbDataSet1
        '
        Me.PmbDataSet1.DataSetName = "pmbDataSet"
        Me.PmbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_delete)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btn_simpan)
        Me.Panel1.Controls.Add(Me.Btn_reset)
        Me.Panel1.Location = New System.Drawing.Point(289, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 95)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Tfilter)
        Me.Controls.Add(Me.DVG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pendaftaran Mahasiswa Baru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DVG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Tnisn As TextBox
    Friend WithEvents Tnama As TextBox
    Friend WithEvents Ttmplhr As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Taslskl As TextBox
    Friend WithEvents Cagama As ComboBox
    Friend WithEvents Temail As TextBox
    Friend WithEvents Dtgllahir As DateTimePicker
    Friend WithEvents Tnohp As TextBox
    Friend WithEvents Talmt As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cjlrpend As ComboBox
    Friend WithEvents Cplh2 As ComboBox
    Friend WithEvents Tnopendaftaran As TextBox
    Friend WithEvents Cplh1 As ComboBox
    Friend WithEvents DVG As DataGridView
    Friend WithEvents Btn_simpan As Button
    Friend WithEvents Btn_reset As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Tfilter As TextBox
    Friend WithEvents CJnsKel As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PmbDataSet1 As pmbDataSet
    Friend WithEvents Panel1 As Panel
End Class
