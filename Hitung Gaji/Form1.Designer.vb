<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.listKeluaran = New System.Windows.Forms.ListBox()
        Me.tombolHitungGaji = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listKeluaran
        '
        Me.listKeluaran.FormattingEnabled = True
        Me.listKeluaran.Location = New System.Drawing.Point(13, 13)
        Me.listKeluaran.Name = "listKeluaran"
        Me.listKeluaran.Size = New System.Drawing.Size(294, 186)
        Me.listKeluaran.TabIndex = 0
        '
        'tombolHitungGaji
        '
        Me.tombolHitungGaji.Location = New System.Drawing.Point(13, 215)
        Me.tombolHitungGaji.Name = "tombolHitungGaji"
        Me.tombolHitungGaji.Size = New System.Drawing.Size(101, 35)
        Me.tombolHitungGaji.TabIndex = 1
        Me.tombolHitungGaji.Text = "Hitung Gaji"
        Me.tombolHitungGaji.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(206, 215)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(101, 35)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 262)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolHitungGaji)
        Me.Controls.Add(Me.listKeluaran)
        Me.Name = "Form1"
        Me.Text = "Hitung Gaji"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listKeluaran As System.Windows.Forms.ListBox
    Friend WithEvents tombolHitungGaji As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
