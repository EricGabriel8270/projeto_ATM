Imports MySql.Data.MySqlClient

Public Class FormSenhaSaque
    Private Sub Button1D_Click(sender As Object, e As EventArgs) Handles Button1D.Click
        txt_senha_saque.Text &= "1"

    End Sub

    Private Sub Button2D_Click(sender As Object, e As EventArgs) Handles Button2D.Click
        txt_senha_saque.Text &= "2"

    End Sub
    Private Sub Button3D_Click(sender As Object, e As EventArgs) Handles Button3D.Click
        txt_senha_saque.Text &= "3"

    End Sub
    Private Sub Button4D_Click(sender As Object, e As EventArgs) Handles Button4D.Click
        txt_senha_saque.Text &= "4"

    End Sub
    Private Sub Button5D_Click(sender As Object, e As EventArgs) Handles Button5D.Click
        txt_senha_saque.Text &= "5"

    End Sub
    Private Sub Button6D_Click(sender As Object, e As EventArgs) Handles Button6D.Click
        txt_senha_saque.Text &= "6"

    End Sub
    Private Sub Button7D_Click(sender As Object, e As EventArgs) Handles Button7D.Click
        txt_senha_saque.Text &= "7"

    End Sub
    Private Sub Button8D_Click(sender As Object, e As EventArgs) Handles Button8D.Click
        txt_senha_saque.Text &= "8"

    End Sub

    Private Sub Button9D_Click(sender As Object, e As EventArgs) Handles Button9D.Click
        txt_senha_saque.Text &= "9"

    End Sub
    Private Sub Button0D_Click(sender As Object, e As EventArgs) Handles Button0D.Click
        txt_senha_saque.Text &= "0"

    End Sub

    Private Sub btn_CancelD_Click(sender As Object, e As EventArgs) Handles btn_CancelD.Click
        If txt_senha_saque.Text.Length > 0 Then
            txt_senha_saque.Text = txt_senha_saque.Text.Substring(0, txt_senha_saque.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_ClearD_Click(sender As Object, e As EventArgs) Handles btn_ClearD.Click
        txt_senha_saque.Clear()
    End Sub




    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        If txt_senha_saque.Text <> Cartao_acesso.SenhaCorreta Then
            MessageBox.Show("Senha incorreta! A transação não pode ser concluída.", "Erro de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_senha_saque.Clear()
            txt_senha_saque.Focus()
            Exit Sub
        End If


        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim idConta As Integer = Convert.ToInt32(Cartao_acesso.IDContaLogada)
            Dim dataFormatada As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim valorFormatado As Decimal = FormSaque.ValorGuardado

            Dim sqlSaldo As String = "SELECT `saldo` FROM `contas` WHERE `id_conta` = @id;"
            Dim saldoAtual As Decimal = 0

            Using cmdSaldo As New MySqlCommand(sqlSaldo, conn)
                cmdSaldo.Parameters.AddWithValue("@id", idConta)
                Dim resultado As Object = cmdSaldo.ExecuteScalar()
                If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                    saldoAtual = Convert.ToDecimal(resultado)
                End If
            End Using


            If valorFormatado > saldoAtual Then
                MessageBox.Show("Saldo insuficiente para realizar este saque!", "Operação Negada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_senha_saque.Clear()
                Exit Sub
            End If


            Dim sqlUpdate As String = "UPDATE `contas` SET `saldo` = `saldo` - @valor WHERE `id_conta` = @id;"
            Using cmdUpdate As New MySqlCommand(sqlUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@valor", valorFormatado)
                cmdUpdate.Parameters.AddWithValue("@id", idConta)
                cmdUpdate.ExecuteNonQuery()
            End Using


            Dim sqlRegistro As String = "INSERT INTO `registros` (`data`, `id_conta_to`, `id_conta_from`, `operacao`, `valor`) " &
                                            "VALUES (@data, @id_to, @id_from, @operacao, @valor);"

            Using cmdRegistro As New MySqlCommand(sqlRegistro, conn)
                cmdRegistro.Parameters.AddWithValue("@data", dataFormatada)
                cmdRegistro.Parameters.AddWithValue("@id_to", idConta)
                cmdRegistro.Parameters.AddWithValue("@id_from", idConta)
                cmdRegistro.Parameters.AddWithValue("@operacao", "Saque")
                cmdRegistro.Parameters.AddWithValue("@valor", valorFormatado)

                cmdRegistro.ExecuteNonQuery()




                Cartao_acesso.GerarComprovanteTXT("Saque", FormSaque.ValorGuardado, Cartao_acesso.IDContaLogada)


                MessageBox.Show("Saque de " & valorFormatado.ToString("C") & " autorizado!...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using


            MessageBox.Show("Saque de " & valorFormatado.ToString("C") & " autorizado! Por favor, retire o seu dinheiro.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao realizar o saque: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub FormSenhaSaque_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        For Each f As Form In Application.OpenForms
            If TypeOf f Is menu_principal Then
                f.Show()
                Exit For
            End If
        Next


        Dim telaAntiga As Form = Nothing
        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormSaque Then
                telaAntiga = f
                Exit For
            End If
        Next

        If telaAntiga IsNot Nothing Then
            telaAntiga.Close()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub
End Class
