<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario_admin = New System.Windows.Forms.TextBox()
        Me.txt_senha_admin = New System.Windows.Forms.TextBox()
        Me.btn_confirmar_login = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        Me.Label1.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(199, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SENHA"
        Me.Label2.UseMnemonic = False
        '
        'txt_usuario_admin
        '
        Me.txt_usuario_admin.Location = New System.Drawing.Point(100, 183)
        Me.txt_usuario_admin.Name = "txt_usuario_admin"
        Me.txt_usuario_admin.Size = New System.Drawing.Size(317, 20)
        Me.txt_usuario_admin.TabIndex = 2
        '
        'txt_senha_admin
        '
        Me.txt_senha_admin.Location = New System.Drawing.Point(100, 341)
        Me.txt_senha_admin.Name = "txt_senha_admin"
        Me.txt_senha_admin.Size = New System.Drawing.Size(317, 20)
        Me.txt_senha_admin.TabIndex = 3
        '
        'btn_confirmar_login
        '
        Me.btn_confirmar_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_confirmar_login.Location = New System.Drawing.Point(101, 449)
        Me.btn_confirmar_login.Name = "btn_confirmar_login"
        Me.btn_confirmar_login.Size = New System.Drawing.Size(161, 57)
        Me.btn_confirmar_login.TabIndex = 4
        Me.btn_confirmar_login.Text = "ENTRAR"
        Me.btn_confirmar_login.UseVisualStyleBackColor = False
        Me.btn_confirmar_login.UseWaitCursor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(268, 450)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(149, 56)
        Me.btn_voltar.TabIndex = 5
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_voltar)
        Me.Panel1.Controls.Add(Me.btn_confirmar_login)
        Me.Panel1.Controls.Add(Me.txt_senha_admin)
        Me.Panel1.Controls.Add(Me.txt_usuario_admin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(514, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 590)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(108, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Area Administrador"
        '
        'FormLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 844)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLoginAdmin"
        Me.Text = "FormLoginAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario_admin As TextBox
    Friend WithEvents txt_senha_admin As TextBox
    Friend WithEvents btn_confirmar_login As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
