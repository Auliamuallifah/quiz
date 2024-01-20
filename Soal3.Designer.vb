<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soal3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtidentitas = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.cmbjeniskamar = New System.Windows.Forms.ComboBox
        Me.cmblayanan = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Proses = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.Keluar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtlayanan = New System.Windows.Forms.TextBox
        Me.txtbiaya = New System.Windows.Forms.TextBox
        Me.txtlama = New System.Windows.Forms.TextBox
        Me.txttotalbayar = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservasi Kamar Hotel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Identitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Hp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipe Layanan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lama Menginap"
        '
        'txtidentitas
        '
        Me.txtidentitas.Location = New System.Drawing.Point(138, 48)
        Me.txtidentitas.Name = "txtidentitas"
        Me.txtidentitas.Size = New System.Drawing.Size(164, 20)
        Me.txtidentitas.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(138, 75)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(164, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(138, 105)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(164, 20)
        Me.txtnohp.TabIndex = 9
        '
        'cmbjeniskamar
        '
        Me.cmbjeniskamar.FormattingEnabled = True
        Me.cmbjeniskamar.Items.AddRange(New Object() {"Standard Room", "Superior Room", "Deluxe Room", "Suite Room"})
        Me.cmbjeniskamar.Location = New System.Drawing.Point(138, 132)
        Me.cmbjeniskamar.Name = "cmbjeniskamar"
        Me.cmbjeniskamar.Size = New System.Drawing.Size(164, 21)
        Me.cmbjeniskamar.TabIndex = 11
        '
        'cmblayanan
        '
        Me.cmblayanan.FormattingEnabled = True
        Me.cmblayanan.Items.AddRange(New Object() {"Tanpa Breakfast", "Dengan Breakfast"})
        Me.cmblayanan.Location = New System.Drawing.Point(138, 162)
        Me.cmblayanan.Name = "cmblayanan"
        Me.cmblayanan.Size = New System.Drawing.Size(164, 21)
        Me.cmblayanan.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Biaya Kamar"
        '
        'Proses
        '
        Me.Proses.Location = New System.Drawing.Point(138, 293)
        Me.Proses.Name = "Proses"
        Me.Proses.Size = New System.Drawing.Size(75, 40)
        Me.Proses.TabIndex = 15
        Me.Proses.Text = "Proses"
        Me.Proses.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(433, 78)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 16
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Keluar
        '
        Me.Keluar.Location = New System.Drawing.Point(522, 78)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Keluar.TabIndex = 17
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Bayar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Biaya Layanan"
        '
        'txtlayanan
        '
        Me.txtlayanan.Location = New System.Drawing.Point(138, 224)
        Me.txtlayanan.Name = "txtlayanan"
        Me.txtlayanan.Size = New System.Drawing.Size(164, 20)
        Me.txtlayanan.TabIndex = 21
        '
        'txtbiaya
        '
        Me.txtbiaya.Location = New System.Drawing.Point(138, 193)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(164, 20)
        Me.txtbiaya.TabIndex = 22
        '
        'txtlama
        '
        Me.txtlama.Location = New System.Drawing.Point(138, 255)
        Me.txtlama.Name = "txtlama"
        Me.txtlama.Size = New System.Drawing.Size(164, 20)
        Me.txtlama.TabIndex = 23
        '
        'txttotalbayar
        '
        Me.txttotalbayar.Location = New System.Drawing.Point(433, 48)
        Me.txttotalbayar.Name = "txttotalbayar"
        Me.txttotalbayar.Size = New System.Drawing.Size(164, 20)
        Me.txttotalbayar.TabIndex = 24
        '
        'Soal3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 340)
        Me.Controls.Add(Me.txttotalbayar)
        Me.Controls.Add(Me.txtlama)
        Me.Controls.Add(Me.txtbiaya)
        Me.Controls.Add(Me.txtlayanan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Proses)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmblayanan)
        Me.Controls.Add(Me.cmbjeniskamar)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtidentitas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Soal3"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtidentitas As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents cmbjeniskamar As System.Windows.Forms.ComboBox
    Friend WithEvents cmblayanan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Proses As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtlayanan As System.Windows.Forms.TextBox
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents txtlama As System.Windows.Forms.TextBox
    Friend WithEvents txttotalbayar As System.Windows.Forms.TextBox
End Class
