<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_registro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_cartao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_agencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(150, 390)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker1.TabIndex = 29
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(144, 280)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(262, 20)
        Me.txt_nome.TabIndex = 26
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(144, 239)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(262, 20)
        Me.txt_senha.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Data de nascimento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nome Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Usuario "
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_salvar.Location = New System.Drawing.Point(42, 472)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(146, 68)
        Me.btn_salvar.TabIndex = 30
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(346, 472)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(146, 67)
        Me.btn_sair.TabIndex = 31
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(144, 200)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(262, 20)
        Me.txt_cpf.TabIndex = 34
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(40, 200)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(27, 13)
        Me.label.TabIndex = 33
        Me.label.Text = "CPF"
        '
        'txt_cartao
        '
        Me.txt_cartao.Location = New System.Drawing.Point(144, 161)
        Me.txt_cartao.Name = "txt_cartao"
        Me.txt_cartao.Size = New System.Drawing.Size(262, 20)
        Me.txt_cartao.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Cartâo"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(144, 127)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(262, 20)
        Me.txt_usuario.TabIndex = 37
        '
        'txt_agencia
        '
        Me.txt_agencia.Location = New System.Drawing.Point(146, 316)
        Me.txt_agencia.Name = "txt_agencia"
        Me.txt_agencia.Size = New System.Drawing.Size(260, 20)
        Me.txt_agencia.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Agencia "
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(194, 472)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(146, 67)
        Me.btn_update.TabIndex = 41
        Me.btn_update.Text = "ATUALIZAR"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(152, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 46)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "REGISTRO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.txt_cc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_bloquear)
        Me.Panel1.Controls.Add(Me.btn_excluir)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.txt_agencia)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_usuario)
        Me.Panel1.Controls.Add(Me.txt_cartao)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_cpf)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(238, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 641)
        Me.Panel1.TabIndex = 43
        '
        'btn_bloquear
        '
        Me.btn_bloquear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_bloquear.Location = New System.Drawing.Point(194, 545)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(146, 67)
        Me.btn_bloquear.TabIndex = 44
        Me.btn_bloquear.Text = "BLOQUEAR"
        Me.btn_bloquear.UseVisualStyleBackColor = False
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_excluir.Location = New System.Drawing.Point(42, 546)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(146, 67)
        Me.btn_excluir.TabIndex = 43
        Me.btn_excluir.Text = "EXCLUIR"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 207)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(351, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(769, 647)
        Me.Panel2.TabIndex = 49
        '
        'txt_cc
        '
        Me.txt_cc.Location = New System.Drawing.Point(146, 348)
        Me.txt_cc.Name = "txt_cc"
        Me.txt_cc.Size = New System.Drawing.Size(260, 20)
        Me.txt_cc.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Conta corrente"
        '
        'frm_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 832)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_registro"
        Me.Text = "Registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents label As Label
    Friend WithEvents txt_cartao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_agencia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_bloquear As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents txt_cc As TextBox
    Friend WithEvents Label5 As Label
End Class
