Public Class FormLoginAdmin


    Private errosAdmin As Integer = 0

    Private Sub btn_confirmar_login_Click(sender As Object, e As EventArgs) Handles btn_confirmar_login.Click

        If txt_usuario_admin.Text = "admin" AndAlso txt_senha_admin.Text = "admin" Then
            MessageBox.Show("Autenticação de Administrador Confirmada!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim painelAdmin As New FormAdmin()
            painelAdmin.Show()


            Me.Close()
        Else

            errosAdmin += 1

            If errosAdmin >= 3 Then
                MessageBox.Show("Acesso administrativo bloqueado por excesso de erros!", "BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Stop)


                VoltarParaTelaCartao()
                Me.Close()
            Else
                Dim tentativasRestantes As Integer = 3 - errosAdmin
                MessageBox.Show($"Usuário ou Senha incorretos! Você tem mais {tentativasRestantes} tentativa(s).", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error)


                txt_senha_admin.Clear()
                txt_usuario_admin.Focus()
            End If
        End If
    End Sub


    Private Sub VoltarParaTelaCartao()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Cartao_acesso Then
                f.Show()
                Exit For
            End If
        Next
    End Sub


    Private Sub FormLoginAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Dim painelAberto As Boolean = False
        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormAdmin Then
                painelAberto = True
                Exit For
            End If
        Next

        If Not painelAberto Then
            VoltarParaTelaCartao()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        VoltarParaTelaCartao()
        Me.Hide()
    End Sub
End Class