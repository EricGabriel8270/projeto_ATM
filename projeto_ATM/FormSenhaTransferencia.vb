Imports MySql.Data.MySqlClient
Public Class FormSenhaTransferencia
    Private Sub Button1D_Click(sender As Object, e As EventArgs) Handles Button1D.Click
        txt_senha_transferencia.Text &= "1"

    End Sub

    Private Sub Button2D_Click(sender As Object, e As EventArgs) Handles Button2D.Click
        txt_senha_transferencia.Text &= "2"

    End Sub
    Private Sub Button3D_Click(sender As Object, e As EventArgs) Handles Button3D.Click
        txt_senha_transferencia.Text &= "3"

    End Sub
    Private Sub Button4D_Click(sender As Object, e As EventArgs) Handles Button4D.Click
        txt_senha_transferencia.Text &= "4"

    End Sub
    Private Sub Button5D_Click(sender As Object, e As EventArgs) Handles Button5D.Click
        txt_senha_transferencia.Text &= "5"

    End Sub
    Private Sub Button6D_Click(sender As Object, e As EventArgs) Handles Button6D.Click
        txt_senha_transferencia.Text &= "6"

    End Sub
    Private Sub Button7D_Click(sender As Object, e As EventArgs) Handles Button7D.Click
        txt_senha_transferencia.Text &= "7"

    End Sub
    Private Sub Button8D_Click(sender As Object, e As EventArgs) Handles Button8D.Click
        txt_senha_transferencia.Text &= "8"

    End Sub
    Private Sub Button9D_Click(sender As Object, e As EventArgs) Handles Button9D.Click
        txt_senha_transferencia.Text &= "9"

    End Sub
    Private Sub Button0D_Click(sender As Object, e As EventArgs) Handles Button0D.Click
        txt_senha_transferencia.Text &= "0"

    End Sub

    Private Sub btn_CancelD_Click(sender As Object, e As EventArgs) Handles btn_CancelD.Click
        If txt_senha_transferencia.Text.Length > 0 Then
            txt_senha_transferencia.Text = txt_senha_transferencia.Text.Substring(0, txt_senha_transferencia.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_ClearD_Click(sender As Object, e As EventArgs) Handles btn_ClearD.Click
        txt_senha_transferencia.Clear()
    End Sub


    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        If txt_senha_transferencia.Text <> Cartao_acesso.SenhaCorreta Then
                MessageBox.Show("Senha incorreta! Transação cancelada.", "Erro de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_senha_transferencia.Clear()
                txt_senha_transferencia.Focus()
                Exit Sub
            End If

            Dim conexaoBanco As New ConexaoBanco()
            Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()


            Dim idRemetente As Integer = Convert.ToInt32(Cartao_acesso.IDContaLogada)
                Dim idDestinatario As Integer = FormTransferenciaID.ContaDestinoGuardada
                Dim valorFormatado As Decimal = FormTransferenciaID.ValorGuardado
                Dim dataFormatada As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")


            Dim sqlSaldo As String = "SELECT `saldo` FROM `contas` WHERE `id_conta` = @idRemetente;"
                Dim saldoAtual As Decimal = 0

                Using cmdSaldo As New MySqlCommand(sqlSaldo, conn)
                    cmdSaldo.Parameters.AddWithValue("@idRemetente", idRemetente)
                    Dim res As Object = cmdSaldo.ExecuteScalar()
                    If res IsNot Nothing AndAlso Not IsDBNull(res) Then
                        saldoAtual = Convert.ToDecimal(res)
                    End If
                End Using

                If valorFormatado > saldoAtual Then
                    MessageBox.Show("Saldo insuficiente para concluir a transferência!", "Operação Negada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                    Exit Sub
                End If


            Dim sqlTira As String = "UPDATE `contas` SET `saldo` = `saldo` - @valor WHERE `id_conta` = @idRemetente;"
                Using cmdTira As New MySqlCommand(sqlTira, conn)
                    cmdTira.Parameters.AddWithValue("@valor", valorFormatado)
                    cmdTira.Parameters.AddWithValue("@idRemetente", idRemetente)
                    cmdTira.ExecuteNonQuery()
                End Using


            Dim sqlColoca As String = "UPDATE `contas` SET `saldo` = `saldo` + @valor WHERE `id_conta` = @idDestinatario;"
                Using cmdColoca As New MySqlCommand(sqlColoca, conn)
                    cmdColoca.Parameters.AddWithValue("@valor", valorFormatado)
                    cmdColoca.Parameters.AddWithValue("@idDestinatario", idDestinatario)
                    cmdColoca.ExecuteNonQuery()
                End Using


            Dim sqlRegistro As String = "INSERT INTO `registros` (`data`, `id_conta_to`, `id_conta_from`, `operacao`, `valor`) VALUES (@data, @id_to, @id_from, 'Transferência', @valor);"
            Using cmdReg As New MySqlCommand(sqlRegistro, conn)
                    cmdReg.Parameters.AddWithValue("@data", dataFormatada)
                    cmdReg.Parameters.AddWithValue("@id_to", idDestinatario)
                    cmdReg.Parameters.AddWithValue("@id_from", idRemetente)
                    cmdReg.Parameters.AddWithValue("@valor", valorFormatado)
                    cmdReg.ExecuteNonQuery()
                End Using

           
            Cartao_acesso.GerarComprovanteTXT("Transferência", valorFormatado, idDestinatario.ToString())

            MessageBox.Show("Transferência de " & valorFormatado.ToString("C") & " enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Me.Close()

            Catch ex As Exception
                MessageBox.Show("Erro ao transferir: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
            Me.Close()
        End Sub


    Private Sub FormSenhaTransferencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        For Each f As Form In Application.OpenForms
                If TypeOf f Is menu_principal Then
                    f.Show()
                    Exit For
                End If
            Next


        Dim telasParaFechar As New List(Of Form)()
            For Each f As Form In Application.OpenForms
                If TypeOf f Is FormTransferenciaID OrElse TypeOf f Is FormTransferenciaValor Then
                    telasParaFechar.Add(f)
                End If
            Next


        For Each f In telasParaFechar
                f.Close()
            Next
        End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub
End Class