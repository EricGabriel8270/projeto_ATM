<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formsenhadeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formsenhadeposito))
        Me.txt_senha_deposito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1SD = New System.Windows.Forms.Button()
        Me.Button2SD = New System.Windows.Forms.Button()
        Me.Button3SD = New System.Windows.Forms.Button()
        Me.Button4SD = New System.Windows.Forms.Button()
        Me.Button5SD = New System.Windows.Forms.Button()
        Me.Button6SD = New System.Windows.Forms.Button()
        Me.Button7SD = New System.Windows.Forms.Button()
        Me.Button8SD = New System.Windows.Forms.Button()
        Me.Button9SD = New System.Windows.Forms.Button()
        Me.Button0SD = New System.Windows.Forms.Button()
        Me.btn_CancelSD = New System.Windows.Forms.Button()
        Me.btn_ClearSD = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_senha_deposito
        '
        Me.txt_senha_deposito.BackColor = System.Drawing.Color.White
        Me.txt_senha_deposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha_deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_deposito.Location = New System.Drawing.Point(37, 394)
        Me.txt_senha_deposito.Multiline = True
        Me.txt_senha_deposito.Name = "txt_senha_deposito"
        Me.txt_senha_deposito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_deposito.Size = New System.Drawing.Size(360, 50)
        Me.txt_senha_deposito.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 40)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Senha "
        Me.Label1.UseMnemonic = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1243, 802)
        Me.Panel2.TabIndex = 52
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(242, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(458, 40)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = " de senha é pessoal e intransferível."
        Me.Label5.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(173, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 40)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Por sua segurança, a digitação "
        Me.Label4.UseMnemonic = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_senha_deposito)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(765, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(477, 796)
        Me.Panel3.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Digite a sua senha para proseguir"
        '
        'Button1SD
        '
        Me.Button1SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1SD.Image = CType(resources.GetObject("Button1SD.Image"), System.Drawing.Image)
        Me.Button1SD.Location = New System.Drawing.Point(16, 30)
        Me.Button1SD.Name = "Button1SD"
        Me.Button1SD.Size = New System.Drawing.Size(147, 110)
        Me.Button1SD.TabIndex = 33
        Me.Button1SD.UseVisualStyleBackColor = True
        '
        'Button2SD
        '
        Me.Button2SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2SD.Image = CType(resources.GetObject("Button2SD.Image"), System.Drawing.Image)
        Me.Button2SD.Location = New System.Drawing.Point(169, 30)
        Me.Button2SD.Name = "Button2SD"
        Me.Button2SD.Size = New System.Drawing.Size(149, 109)
        Me.Button2SD.TabIndex = 34
        Me.Button2SD.UseVisualStyleBackColor = True
        '
        'Button3SD
        '
        Me.Button3SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3SD.Image = CType(resources.GetObject("Button3SD.Image"), System.Drawing.Image)
        Me.Button3SD.Location = New System.Drawing.Point(324, 30)
        Me.Button3SD.Name = "Button3SD"
        Me.Button3SD.Size = New System.Drawing.Size(148, 109)
        Me.Button3SD.TabIndex = 35
        Me.Button3SD.UseVisualStyleBackColor = True
        '
        'Button4SD
        '
        Me.Button4SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4SD.Image = CType(resources.GetObject("Button4SD.Image"), System.Drawing.Image)
        Me.Button4SD.Location = New System.Drawing.Point(16, 145)
        Me.Button4SD.Name = "Button4SD"
        Me.Button4SD.Size = New System.Drawing.Size(148, 111)
        Me.Button4SD.TabIndex = 36
        Me.Button4SD.UseVisualStyleBackColor = True
        '
        'Button5SD
        '
        Me.Button5SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5SD.Image = CType(resources.GetObject("Button5SD.Image"), System.Drawing.Image)
        Me.Button5SD.Location = New System.Drawing.Point(170, 145)
        Me.Button5SD.Name = "Button5SD"
        Me.Button5SD.Size = New System.Drawing.Size(148, 111)
        Me.Button5SD.TabIndex = 37
        Me.Button5SD.UseVisualStyleBackColor = True
        '
        'Button6SD
        '
        Me.Button6SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6SD.Image = CType(resources.GetObject("Button6SD.Image"), System.Drawing.Image)
        Me.Button6SD.Location = New System.Drawing.Point(324, 146)
        Me.Button6SD.Name = "Button6SD"
        Me.Button6SD.Size = New System.Drawing.Size(147, 111)
        Me.Button6SD.TabIndex = 38
        Me.Button6SD.UseVisualStyleBackColor = True
        '
        'Button7SD
        '
        Me.Button7SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7SD.Image = CType(resources.GetObject("Button7SD.Image"), System.Drawing.Image)
        Me.Button7SD.Location = New System.Drawing.Point(17, 263)
        Me.Button7SD.Name = "Button7SD"
        Me.Button7SD.Size = New System.Drawing.Size(147, 116)
        Me.Button7SD.TabIndex = 39
        Me.Button7SD.UseVisualStyleBackColor = True
        '
        'Button8SD
        '
        Me.Button8SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8SD.Image = CType(resources.GetObject("Button8SD.Image"), System.Drawing.Image)
        Me.Button8SD.Location = New System.Drawing.Point(170, 262)
        Me.Button8SD.Name = "Button8SD"
        Me.Button8SD.Size = New System.Drawing.Size(149, 115)
        Me.Button8SD.TabIndex = 40
        Me.Button8SD.UseVisualStyleBackColor = True
        '
        'Button9SD
        '
        Me.Button9SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9SD.Image = CType(resources.GetObject("Button9SD.Image"), System.Drawing.Image)
        Me.Button9SD.Location = New System.Drawing.Point(325, 260)
        Me.Button9SD.Name = "Button9SD"
        Me.Button9SD.Size = New System.Drawing.Size(147, 116)
        Me.Button9SD.TabIndex = 41
        Me.Button9SD.UseVisualStyleBackColor = True
        '
        'Button0SD
        '
        Me.Button0SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0SD.Image = CType(resources.GetObject("Button0SD.Image"), System.Drawing.Image)
        Me.Button0SD.Location = New System.Drawing.Point(170, 383)
        Me.Button0SD.Name = "Button0SD"
        Me.Button0SD.Size = New System.Drawing.Size(149, 116)
        Me.Button0SD.TabIndex = 42
        Me.Button0SD.UseVisualStyleBackColor = True
        '
        'btn_CancelSD
        '
        Me.btn_CancelSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelSD.Image = CType(resources.GetObject("btn_CancelSD.Image"), System.Drawing.Image)
        Me.btn_CancelSD.Location = New System.Drawing.Point(477, 30)
        Me.btn_CancelSD.Name = "btn_CancelSD"
        Me.btn_CancelSD.Size = New System.Drawing.Size(174, 110)
        Me.btn_CancelSD.TabIndex = 43
        Me.btn_CancelSD.UseVisualStyleBackColor = True
        '
        'btn_ClearSD
        '
        Me.btn_ClearSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ClearSD.Image = CType(resources.GetObject("btn_ClearSD.Image"), System.Drawing.Image)
        Me.btn_ClearSD.Location = New System.Drawing.Point(477, 146)
        Me.btn_ClearSD.Name = "btn_ClearSD"
        Me.btn_ClearSD.Size = New System.Drawing.Size(174, 109)
        Me.btn_ClearSD.TabIndex = 44
        Me.btn_ClearSD.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(477, 263)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(175, 114)
        Me.btn_confirmar.TabIndex = 46
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(17, 383)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(147, 116)
        Me.Button14.TabIndex = 47
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(324, 383)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(148, 116)
        Me.Button15.TabIndex = 48
        Me.Button15.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(480, 383)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(148, 116)
        Me.btn_cancelar.TabIndex = 49
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.btn_confirmar)
        Me.Panel1.Controls.Add(Me.btn_ClearSD)
        Me.Panel1.Controls.Add(Me.btn_CancelSD)
        Me.Panel1.Controls.Add(Me.Button0SD)
        Me.Panel1.Controls.Add(Me.Button9SD)
        Me.Panel1.Controls.Add(Me.Button8SD)
        Me.Panel1.Controls.Add(Me.Button7SD)
        Me.Panel1.Controls.Add(Me.Button6SD)
        Me.Panel1.Controls.Add(Me.Button5SD)
        Me.Panel1.Controls.Add(Me.Button4SD)
        Me.Panel1.Controls.Add(Me.Button3SD)
        Me.Panel1.Controls.Add(Me.Button2SD)
        Me.Panel1.Controls.Add(Me.Button1SD)
        Me.Panel1.Location = New System.Drawing.Point(1261, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 506)
        Me.Panel1.TabIndex = 51
        '
        'Formsenhadeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 839)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formsenhadeposito"
        Me.Text = "Formsenhadeposito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_senha_deposito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1SD As Button
    Friend WithEvents Button2SD As Button
    Friend WithEvents Button3SD As Button
    Friend WithEvents Button4SD As Button
    Friend WithEvents Button5SD As Button
    Friend WithEvents Button6SD As Button
    Friend WithEvents Button7SD As Button
    Friend WithEvents Button8SD As Button
    Friend WithEvents Button9SD As Button
    Friend WithEvents Button0SD As Button
    Friend WithEvents btn_CancelSD As Button
    Friend WithEvents btn_ClearSD As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
