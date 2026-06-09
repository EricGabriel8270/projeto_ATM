Public Class FormTransferenciaValor


    Private Sub Button1D_Click(sender As Object, e As EventArgs) Handles Button1D.Click
        txt_valor_transferencia.Text &= "1"
    End Sub

    Private Sub Button2D_Click(sender As Object, e As EventArgs) Handles Button2D.Click
        txt_valor_transferencia.Text &= "2"
    End Sub

    Private Sub Button3D_Click(sender As Object, e As EventArgs) Handles Button3D.Click
        txt_valor_transferencia.Text &= "3"
    End Sub

    Private Sub Button4D_Click(sender As Object, e As EventArgs) Handles Button4D.Click
        txt_valor_transferencia.Text &= "4"
    End Sub

    Private Sub Button5D_Click(sender As Object, e As EventArgs) Handles Button5D.Click
        txt_valor_transferencia.Text &= "5"
    End Sub

    Private Sub Button6D_Click(sender As Object, e As EventArgs) Handles Button6D.Click
        txt_valor_transferencia.Text &= "6"
    End Sub

    Private Sub Button7D_Click(sender As Object, e As EventArgs) Handles Button7D.Click
        txt_valor_transferencia.Text &= "7"
    End Sub

    Private Sub Button8D_Click(sender As Object, e As EventArgs) Handles Button8D.Click
        txt_valor_transferencia.Text &= "8"
    End Sub

    Private Sub Button9D_Click(sender As Object, e As EventArgs) Handles Button9D.Click
        txt_valor_transferencia.Text &= "9"
    End Sub

    Private Sub Button0D_Click(sender As Object, e As EventArgs) Handles Button0D.Click
        txt_valor_transferencia.Text &= "0"
    End Sub
    Private Sub btn_CancelD_Click(sender As Object, e As EventArgs) Handles btn_CancelD.Click
        If txt_valor_transferencia.Text.Length > 0 Then
            txt_valor_transferencia.Text = txt_valor_transferencia.Text.Substring(0, txt_valor_transferencia.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_ClearD_Click(sender As Object, e As EventArgs) Handles btn_ClearD.Click
        txt_valor_transferencia.Clear()
    End Sub


    Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
        Dim valorDigitado As Decimal


        If Not Decimal.TryParse(txt_valor_transferencia.Text, valorDigitado) OrElse valorDigitado <= 0 Then
            MessageBox.Show("Digite um valor válido e maior que zero para transferir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_valor_transferencia.Focus()
            Exit Sub
        End If


        FormTransferenciaID.ValorGuardado = valorDigitado


        Dim telaSenha As New FormSenhaTransferencia()
        telaSenha.Show()
        Me.Hide()
    End Sub


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormTransferenciaID Then
                f.Show()
                Exit For
            End If
        Next
        Me.Close()
    End Sub


End Class
