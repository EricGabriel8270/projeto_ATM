Imports MySql.Data.MySqlClient
Public Class FormAdmin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarUsuarios()
        CarregarTransacoes()
    End Sub


    Private Sub CarregarUsuarios()
        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim sql As String = "SELECT `id_conta` As 'ID', `cpf` As 'CPF', `nome completo` As 'Nome', `cartao` As 'Cartão', `agencia` As 'Agência', `status` as `Status` FROM `contas`;"

            Dim dtUsuarios As New DataTable()
            Using da As New MySqlDataAdapter(sql, conn)
                da.Fill(dtUsuarios)
            End Using


            dgv_usuarios.DataSource = dtUsuarios
            dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar usuários: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub CarregarTransacoes()
        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim sql As String = "SELECT `id_registros` As 'ID', `data` As 'Data', `id_conta_from` As 'De', `id_conta_to` As 'para', `operacao` As 'Operacao' FROM `registros` ORDER BY `data` DESC;"

            Dim dtTransacoes As New DataTable()
            Using da As New MySqlDataAdapter(sql, conn)
                da.Fill(dtTransacoes)
            End Using


            dgv_transacoes.DataSource = dtTransacoes
            dgv_transacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception

            MessageBox.Show("Erro ao carregar transações (Verifique se a tabela existe): " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btn_ir_registros_Click(sender As Object, e As EventArgs) Handles btn_ir_registros.Click

        Dim telaRegistros As New frm_registro()
        telaRegistros.Show()


    End Sub

    Private Sub btn_atualizar_tabelas_Click(sender As Object, e As EventArgs) Handles btn_atualizar_tabelas.Click
        Try

            Cursor = Cursors.WaitCursor


            CarregarUsuarios()
            CarregarTransacoes()


            Cursor = Cursors.Default

            MessageBox.Show("As tabelas de usuários e transações foram atualizadas com sucesso!", "Painel Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
           
            Cursor = Cursors.Default
            MessageBox.Show("Erro ao atualizar as listas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VoltarParaTelaCartao()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Cartao_acesso Then
                f.Show()
                Exit For
            End If
        Next
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        VoltarParaTelaCartao()
        Me.Hide()
    End Sub

End Class