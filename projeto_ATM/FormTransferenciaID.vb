Imports MySql.Data.MySqlClient
Public Class FormTransferenciaID
    Private Sub Button1D_Click(sender As Object, e As EventArgs) Handles Button1D.Click
        txt_conta_destino.Text &= "1"

    End Sub

    Private Sub Button2D_Click(sender As Object, e As EventArgs) Handles Button2D.Click
        txt_conta_destino.Text &= "2"

    End Sub
    Private Sub Button3D_Click(sender As Object, e As EventArgs) Handles Button3D.Click
        txt_conta_destino.Text &= "3"

    End Sub
    Private Sub Button4D_Click(sender As Object, e As EventArgs) Handles Button4D.Click
        txt_conta_destino.Text &= "4"

    End Sub
    Private Sub Button5D_Click(sender As Object, e As EventArgs) Handles Button5D.Click
        txt_conta_destino.Text &= "5"

    End Sub
    Private Sub Button6D_Click(sender As Object, e As EventArgs) Handles Button6D.Click
        txt_conta_destino.Text &= "6"

    End Sub
    Private Sub Button7D_Click(sender As Object, e As EventArgs) Handles Button7D.Click
        txt_conta_destino.Text &= "7"

    End Sub
    Private Sub Button8D_Click(sender As Object, e As EventArgs) Handles Button8D.Click
        txt_conta_destino.Text &= "8"

    End Sub

    Private Sub Button9D_Click(sender As Object, e As EventArgs) Handles Button9D.Click
        txt_conta_destino.Text &= "9"

    End Sub
    Private Sub Button0D_Click(sender As Object, e As EventArgs) Handles Button0D.Click
        txt_conta_destino.Text &= "0"

    End Sub

    Private Sub btn_CancelD_Click(sender As Object, e As EventArgs) Handles btn_CancelD.Click
        If txt_conta_destino.Text.Length > 0 Then
            txt_conta_destino.Text = txt_conta_destino.Text.Substring(0, txt_conta_destino.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_ClearD_Click(sender As Object, e As EventArgs) Handles btn_ClearD.Click
        txt_conta_destino.Clear()
    End Sub


    Public Shared ContaDestinoGuardada As Integer = 0
    Public Shared ValorGuardado As Decimal = 0


    Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click

        ContaDestinoGuardada = IdentificarContaTransferencia(txt_conta_destino.Text, txt_cc.Text)
        If ContaDestinoGuardada.ToString() = Cartao_acesso.IDContaLogada Then
            MessageBox.Show("Você não pode transferir dinheiro para a sua própria conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sqlCheck As String = "SELECT COUNT(*) FROM `contas` WHERE `id_conta` = @idDestino;"
            Using cmdCheck As New MySqlCommand(sqlCheck, conn)
                cmdCheck.Parameters.AddWithValue("@idDestino", ContaDestinoGuardada)
                Dim qtd As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If qtd = 0 Then
                    MessageBox.Show("A conta informada não existe no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar conta: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try


        Dim telaValor As New FormTransferenciaValor()
        telaValor.Show()
        Me.Hide()
    End Sub


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        VoltarParaMenu()
        Me.Hide()
    End Sub

    Private Sub FormTransferenciaID_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VoltarParaMenu()
    End Sub

    Private Sub VoltarParaMenu()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is menu_principal Then
                f.Show()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub
End Class