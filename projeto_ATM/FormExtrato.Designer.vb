<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExtrato
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExtrato))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_saldo_atual = New System.Windows.Forms.Label()
        Me.dgv_extrato = New System.Windows.Forms.DataGridView()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_extrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(0, 46)
        Me.Label1.TabIndex = 0
        '
        'lbl_saldo_atual
        '
        Me.lbl_saldo_atual.AutoSize = True
        Me.lbl_saldo_atual.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo_atual.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbl_saldo_atual.Location = New System.Drawing.Point(83, 452)
        Me.lbl_saldo_atual.Name = "lbl_saldo_atual"
        Me.lbl_saldo_atual.Size = New System.Drawing.Size(435, 76)
        Me.lbl_saldo_atual.TabIndex = 1
        Me.lbl_saldo_atual.Text = "DISPONIVEL"
        '
        'dgv_extrato
        '
        Me.dgv_extrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_extrato.Location = New System.Drawing.Point(71, 161)
        Me.dgv_extrato.Name = "dgv_extrato"
        Me.dgv_extrato.Size = New System.Drawing.Size(364, 566)
        Me.dgv_extrato.TabIndex = 2
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(201, 599)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(265, 113)
        Me.btn_voltar.TabIndex = 3
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.lbl_saldo_atual)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1243, 802)
        Me.Panel3.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(26, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(699, 76)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "SALDO DISPONÍVEL:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dgv_extrato)
        Me.Panel2.Location = New System.Drawing.Point(713, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 796)
        Me.Panel2.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Digite o quanto você quer depositar para proseguir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(80, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 40)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Extrato"
        Me.Label6.UseMnemonic = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(440, 265)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(3, 779)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Desenvolvido por"
        '
        'FormExtrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 841)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormExtrato"
        Me.Text = "FormExtrato"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_extrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_saldo_atual As Label
    Friend WithEvents dgv_extrato As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
