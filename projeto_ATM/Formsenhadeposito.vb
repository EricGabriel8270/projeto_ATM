Imports MySql.Data.MySqlClient
Public Class Formsenhadeposito
    Private Sub Button1SD_Click(sender As Object, e As EventArgs) Handles Button1SD.Click
        txt_senha_deposito.Text &= "1"

    End Sub

    Private Sub Button2SD_Click(sender As Object, e As EventArgs) Handles Button2SD.Click
        txt_senha_deposito.Text &= "2"

    End Sub
    Private Sub Button3SD_Click(sender As Object, e As EventArgs) Handles Button3SD.Click
        txt_senha_deposito.Text &= "3"

    End Sub
    Private Sub Button4SD_Click(sender As Object, e As EventArgs) Handles Button4SD.Click
        txt_senha_deposito.Text &= "4"

    End Sub
    Private Sub Button5SD_Click(sender As Object, e As EventArgs) Handles Button5SD.Click
        txt_senha_deposito.Text &= "5"

    End Sub
    Private Sub Button6SD_Click(sender As Object, e As EventArgs) Handles Button6SD.Click
        txt_senha_deposito.Text &= "6"

    End Sub
    Private Sub Button7SD_Click(sender As Object, e As EventArgs) Handles Button7SD.Click
        txt_senha_deposito.Text &= "7"

    End Sub
    Private Sub Button8SD_Click(sender As Object, e As EventArgs) Handles Button8SD.Click
        txt_senha_deposito.Text &= "8"

    End Sub
    Private Sub Button9SD_Click(sender As Object, e As EventArgs) Handles Button9SD.Click
        txt_senha_deposito.Text &= "9"

    End Sub
    Private Sub Button0SD_Click(sender As Object, e As EventArgs) Handles Button0SD.Click
        txt_senha_deposito.Text &= "0"

    End Sub

    Private Sub btn_CancelSD_Click(sender As Object, e As EventArgs) Handles btn_CancelSD.Click
        If txt_senha_deposito.Text.Length > 0 Then
            txt_senha_deposito.Text = txt_senha_deposito.Text.Substring(0, txt_senha_deposito.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_ClearSD_Click(sender As Object, e As EventArgs) Handles btn_ClearSD.Click
        txt_senha_deposito.Clear()
    End Sub


    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        If txt_senha_deposito.Text <> Cartao_acesso.SenhaCorreta Then
            MessageBox.Show("Senha incorreta! A transação não pode ser concluída.", "Erro de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_senha_deposito.Clear()
            txt_senha_deposito.Focus()
            Exit Sub
        End If


        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim idConta As Integer = Convert.ToInt32(Cartao_acesso.IDContaLogada)


            Dim dataFormatada As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")


            Dim valorFormatado As Decimal = FormDeposito.ValorGuardado

            Dim sqlUpdate As String = "UPDATE `contas` SET `saldo` = `saldo` + @valor WHERE `id_conta` = @id;"
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
                cmdRegistro.Parameters.AddWithValue("@operacao", "Depósito")
                cmdRegistro.Parameters.AddWithValue("@valor", valorFormatado)

                cmdRegistro.ExecuteNonQuery()


                Cartao_acesso.GerarComprovanteTXT("Depósito", FormDeposito.ValorGuardado, Cartao_acesso.IDContaLogada)


                MessageBox.Show("Depósito de " & FormDeposito.ValorGuardado.ToString("C") & " concluído...", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using


            MessageBox.Show("Depósito de " & valorFormatado.ToString("C") & " concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao realizar o depósito: " & ex.Message & vbCrLf & vbCrLf & "Detalhe Técnico: Pode haver um nome de coluna escrito diferente no MySQL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        VoltarParaMenuPrincipal()
    End Sub


    Private Sub VoltarParaMenuPrincipal()

        For Each f As Form In Application.OpenForms
            If TypeOf f Is menu_principal Then
                f.Show()
                Exit For
            End If
        Next


        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormDeposito Then
                DirectCast(f, FormDeposito).Close()
                Exit For
            End If
        Next


        Me.Close()
    End Sub

    Private Sub FormSenhaDeposito_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        menu_principal.Show()
    End Sub

    Private Sub Formsenhadeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class