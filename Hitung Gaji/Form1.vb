Public Class Form1

    Private Sub tombolHitungGaji_Click(sender As Object, e As EventArgs) Handles tombolHitungGaji.Click
        'konstanta-konstanta
        Const decGAJI_PER_JAM As Decimal = 12000D
        Const intSUBSKRIPT_MAKS As Integer = 5

        'array dan variabel-variabel lain
        Dim dblArrayJam(intSUBSKRIPT_MAKS) As Double
        Dim intHitung As Integer = 0   'pencacah loop
        Dim decGajiPekerja As Decimal  'memuat gaji kotor

        'meminta user untuk memasukkan jam kerja tiap pekerja
        MessageBox.Show("Saya meminta Anda untuk memasukkan " &
        "banyaknya jam kerja tiap pekerja.")

        'membaca banyak jam kerja oleh karyawan
        Do While intHitung < dblArrayJam.Length
            Try
                dblArrayJam(intHitung) =
                CDbl(InputBox("Nomor pekerja " &
               (intHitung + 1).ToString()))
                intHitung += 1
            Catch
                'menampilkan pesan error untuk masukan tak valid
                MessageBox.Show("Masukkan jumlah jam kerja " &
                "yang valid untuk pekerja.")
            End Try
        Loop

        'membersihkan kotak list
        listKeluaran.Items.Clear()

        'menghitung dan menampilkan gaji kotor tiap pekerja
        For intHitung = 0 To dblArrayJam.Length - 1
            decGajiPekerja = CDec(dblArrayJam(intHitung) *
            decGAJI_PER_JAM)

            listKeluaran.Items.Add("Pekerja " &
            (intHitung + 1).ToString() &
            " bergaji Rp. " &
            decGajiPekerja.ToString())
        Next
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
