
Public Class menu_principal
    Private Sub btn_extrato_Click(sender As Object, e As EventArgs) Handles btn_extrato.Click

        Dim telaExtrato As New FormExtrato()
        telaExtrato.Show()


        Me.Hide()
    End Sub

    Private Sub menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not String.IsNullOrWhiteSpace(Cartao_acesso.NomeUsuarioLogado) Then


            Dim nomeCompleto As String = Cartao_acesso.NomeUsuarioLogado


            Dim partesDoNome As String() = nomeCompleto.Trim().Split(" "c)
            Dim primeiroNome As String = partesDoNome(0)


            lbl_usuario_logado.Text = "Olá " & primeiroNome
        Else

            lbl_usuario_logado.Text = "Olá, Cliente"
        End If
    End Sub

    Private Sub btn_deposito_Click(sender As Object, e As EventArgs) Handles btn_deposito.Click

        Dim telaDeposito As New FormDeposito()
        telaDeposito.Show()


        Me.Hide()
    End Sub

    Private Sub btn_saque_Click(sender As Object, e As EventArgs) Handles btn_saque.Click

        Dim telasaque As New FormSaque()
        telasaque.Show()


        Me.Hide()
    End Sub

    Private Sub btn_transferencia_Click(sender As Object, e As EventArgs) Handles btn_transferencia.Click
        Dim telaID As New FormTransferenciaID()
        telaID.Show()
        Me.Hide()
    End Sub
    Private Sub VoltarParaTelaCartao()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Cartao_acesso Then
                f.Show()
                Exit For
            End If
        Next
    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        VoltarParaTelaCartao()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class