Imports MySql.Data.MySqlClient

Public Class menu_senha
    Private errosTentativas As Integer = 0
    Private Sub menu_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not String.IsNullOrWhiteSpace(Cartao_acesso.IDContaLogada) Then

            lbl_usuario.Text = "Olá, " & Cartao_acesso.NomeUsuarioLogado & "! "
        Else
            lbl_usuario.Text = "Por favor, digite sua senha:"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_display.Text &= "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_display.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_display.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_display.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_display.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_display.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_display.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_display.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt_display.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txt_display.Text &= "0"
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        If txt_display.Text.Length > 0 Then
            txt_display.Text = txt_display.Text.Substring(0, txt_display.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_display.Clear()
    End Sub
    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        If txt_display.Text = Cartao_acesso.SenhaCorreta Then
            MessageBox.Show("Acesso Autorizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Cartao_acesso.QuantidadeDeBloqueios = 0

            Dim telaMenu As New menu_principal()
            telaMenu.Show()
            Me.Close()
        Else
            tentativas += 1

            If tentativas >= 3 Then

                Cartao_acesso.QuantidadeDeBloqueios += 1


                Dim minutosPenalidade As Integer = Cartao_acesso.QuantidadeDeBloqueios * 1


                Cartao_acesso.HorarioDesbloqueio = DateTime.Now.AddMinutes(minutosPenalidade)
                Cartao_acesso.EstaBloqueioAtivo = True

                MessageBox.Show($"Cartão bloqueado por excesso de tentativas! O acesso estará suspenso por {minutosPenalidade} minutos.",
                            "TERMINAL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Stop)


                txt_display.Clear()


                For Each f As Form In Application.OpenForms
                    If TypeOf f Is Cartao_acesso Then
                        f.Show()


                        Dim telaCartao As Cartao_acesso = DirectCast(f, Cartao_acesso)


                        telaCartao.txt_display.Clear()

                        Exit For
                    End If
                Next

                Me.Close()
            Else
                Dim chancesRestantes As Integer = 3 - tentativas
                MessageBox.Show($"Senha incorreta! Você tem mais {chancesRestantes} tentativa(s).", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_display.Clear()
            End If
        End If
    End Sub


    Private Sub BloquearCartaoNoBanco(idConta As String)
        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim sql As String = "UPDATE `contas` SET `status` = 'Bloqueado' WHERE `id_conta` = @id;"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idConta))
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao bloquear cartão no sistema: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub VoltarParaTelaInicial()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Cartao_acesso Then
                f.Show()
                Exit For
            End If
        Next
        Me.Close()
    End Sub


    Private Function ObterPrimeiroNome(ByVal nomeCompleto As String) As String
        If String.IsNullOrWhiteSpace(nomeCompleto) Then Return "Usuário"


        Dim partesDoNome As String() = nomeCompleto.Trim().Split(" "c)


        Return partesDoNome(0)
    End Function


End Class