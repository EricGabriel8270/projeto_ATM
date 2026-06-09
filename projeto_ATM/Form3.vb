Imports MySql.Data.MySqlClient
Imports Mysqlx.Expr

Public Class frm_registro
    Dim str As String = "server=localhost; uid=root; pwd=; database=atm"
    Dim conn As New MySqlConnection(str)

    Private Sub LimparFormulario()

        txt_usuario.Clear()
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_cartao.Clear()
        txt_senha.Clear()
        txt_agencia.Clear()
        txt_cc.Clear()


        DateTimePicker1.Value = DateTime.Now



        txt_usuario.Focus()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim gend As String


        conn.Open()

        Try

            Dim sqlCheck As String = "SELECT `id_conta`, `cpf`, `cartao`, `agencia` FROM `contas` " &
                                     "WHERE `id_conta` = @id_conta OR `cpf` = @cpf OR `cartao` = @cartao OR `agencia` = @agencia;"

            Dim cmdCheck As New MySqlCommand(sqlCheck, conn)
            cmdCheck.Parameters.AddWithValue("@id_conta", txt_usuario.Text)
            cmdCheck.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            cmdCheck.Parameters.AddWithValue("@cartao", txt_cartao.Text)
            cmdCheck.Parameters.AddWithValue("@agencia", txt_agencia.Text)

            Dim reader As MySqlDataReader = cmdCheck.ExecuteReader()


            If reader.Read() Then
                Dim mensagemErro As String = "Não foi possível cadastrar:" & vbCrLf


                If reader("id_conta").ToString() = txt_usuario.Text Then
                    mensagemErro &= "- Este ID de Conta já está em uso." & vbCrLf
                End If
                If reader("cpf").ToString() = txt_cpf.Text Then
                    mensagemErro &= "- Este CPF já está cadastrado." & vbCrLf
                End If
                If reader("cartao").ToString() = txt_cartao.Text Then
                    mensagemErro &= "- Este número de Cartão já está em uso." & vbCrLf
                End If

                If reader("agencia").ToString() = txt_agencia.Text Then
                    mensagemErro &= "- Esta Agência já está registrada." & vbCrLf
                End If

                MsgBox(mensagemErro, MsgBoxStyle.Exclamation, "Dados Duplicados")

                reader.Close()
                conn.Close()
                Exit Sub
            End If

            reader.Close()


            Dim cmb As MySqlCommand = conn.CreateCommand()
            cmb.CommandText = "INSERT INTO `contas` (`id_conta`, `cpf`, `nome completo`, `aniversario`, `saldo`, `cartao`, `pin`, `agencia`, `cc`, `status`) VALUES (@id_conta, @cpf, @nome_completo, @aniversario, @saldo, @cartao, @pin, @agencia, @cc, @status);"

            cmb.Parameters.AddWithValue("@id_conta", txt_usuario.Text)
            cmb.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            cmb.Parameters.AddWithValue("@nome_completo", txt_nome.Text)
            cmb.Parameters.AddWithValue("@aniversario", DateTimePicker1.Value)
            cmb.Parameters.AddWithValue("@saldo", "")
            cmb.Parameters.AddWithValue("@cartao", txt_cartao.Text)
            cmb.Parameters.AddWithValue("@pin", txt_senha.Text)
            cmb.Parameters.AddWithValue("@agencia", txt_agencia.Text)
            cmb.Parameters.AddWithValue("@cc", txt_cc.Text)
            cmb.Parameters.AddWithValue("@status", "ATIVO")


            cmb.ExecuteNonQuery()
            MsgBox("Novo registro gravado com sucesso!", MsgBoxStyle.Information, "Sucesso")

            LimparFormulario()
        Catch ex As Exception
            MsgBox("Erro na operação: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub BuscarEPreencher(ByVal nomeCampoBanco As String, ByVal valorBuscado As String)

        If String.IsNullOrWhiteSpace(valorBuscado) Then Exit Sub


        Dim sql As String = $"SELECT * FROM `contas` WHERE `{nomeCampoBanco}` = @valor LIMIT 1;"


        If conn.State = ConnectionState.Closed Then conn.Open()

        Try
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@valor", valorBuscado)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        txt_usuario.Text = reader("id_conta").ToString()
                        txt_cpf.Text = reader("cpf").ToString()
                        txt_nome.Text = reader("nome completo").ToString()
                        txt_cartao.Text = reader("cartao").ToString()
                        txt_senha.Text = reader("pin").ToString()
                        txt_agencia.Text = reader("agencia").ToString()
                        txt_cc.Text = reader("cc").ToString()


                        If Not IsDBNull(reader("aniversario")) AndAlso reader("aniversario").ToString() <> "" Then
                            Dim dataBanco As Object = reader("aniversario")


                            If TypeOf dataBanco Is Date Then
                                DateTimePicker1.Value = DirectCast(dataBanco, Date)
                            Else

                                Dim dataConvertida As Date
                                If Date.TryParse(dataBanco.ToString(), dataConvertida) Then
                                    DateTimePicker1.Value = dataConvertida
                                Else

                                    DateTimePicker1.Value = DateTime.Now
                                End If
                            End If
                        Else

                            DateTimePicker1.Value = DateTime.Now
                        End If

                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Erro ao buscar dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally

            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub txt_usuario_Leave(sender As Object, e As EventArgs) Handles txt_usuario.Leave
        BuscarEPreencher("id_conta", txt_usuario.Text)
    End Sub


    Private Sub txt_cpf_Leave(sender As Object, e As EventArgs) Handles txt_cpf.Leave
        BuscarEPreencher("cpf", txt_cpf.Text)
    End Sub


    Private Sub txt_cartao_Leave(sender As Object, e As EventArgs) Handles txt_cartao.Leave
        BuscarEPreencher("cartao", txt_cartao.Text)
    End Sub


    Private Sub txt_agencia_Leave(sender As Object, e As EventArgs) Handles txt_agencia.Leave
        BuscarEPreencher("agencia", txt_agencia.Text)
    End Sub




    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If String.IsNullOrWhiteSpace(txt_usuario.Text) Then
            MessageBox.Show("Por favor, selecione ou busque uma conta antes de tentar atualizar os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_usuario.Focus()
            Exit Sub
        End If


        Dim resposta As DialogResult
        resposta = MessageBox.Show("Deseja realmente salvar as alterações para a conta '" & txt_usuario.Text & "'?",
                                   "Confirmar Atualização",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

        If resposta = DialogResult.No Then Exit Sub


        If conn.State = ConnectionState.Closed Then conn.Open()

        Try

            Dim sql As String = "UPDATE `contas` SET " &
                                 "`cpf` = @cpf, " &
                                 "`nome completo` = @nome_completo, " &
                                 "`aniversario` = @aniversario, " &
                                 "`cartao` = @cartao, " &
                                 "`pin` = @pin, " &
                                 "`agencia` = @agencia, " &
                                 "`cc` = @cc " &
                                 "WHERE `id_conta` = @id_conta;"

            Using cmd As New MySqlCommand(sql, conn)
                ' Parâmetros que vão substituir os @valores na Query
                cmd.Parameters.AddWithValue("@id_conta", txt_usuario.Text) ' O ID usado no WHERE para localizar o registro
                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                cmd.Parameters.AddWithValue("@nome_completo", txt_nome.Text)
                cmd.Parameters.AddWithValue("@aniversario", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@cartao", txt_cartao.Text)
                cmd.Parameters.AddWithValue("@pin", txt_senha.Text) ' Atualiza a senha/pin com o que estiver na txt_senha
                cmd.Parameters.AddWithValue("@agencia", txt_agencia.Text)
                cmd.Parameters.AddWithValue("@cc", txt_cc.Text)
                ' Executa o comando de atualização
                Dim linhasAfetadas As Integer = cmd.ExecuteNonQuery()

                If linhasAfetadas > 0 Then
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpa o formulário após atualizar com sucesso para o próximo uso
                    LimparFormulario()
                Else
                    MessageBox.Show("Nenhuma alteração foi feita ou a conta não foi encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar os dados: " & ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Garante que a conexão sempre feche
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click

        If String.IsNullOrWhiteSpace(txt_usuario.Text) Then
            MessageBox.Show("Por favor, selecione ou digite o ID da conta que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_usuario.Focus()
            Exit Sub
        End If


        Dim resposta As MsgBoxResult
        resposta = MsgBox("Tem certeza de que deseja excluir permanentemente a conta do usuário '" & txt_usuario.Text & "'?",
                          MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
                          "Confirmar Exclusão")


        If resposta = MsgBoxResult.No Then Exit Sub


        If conn.State = ConnectionState.Closed Then conn.Open()

        Try
            Using cmd As New MySqlCommand("DELETE FROM registros WHERE id_conta_to = @id_conta", conn)
                cmd.Parameters.AddWithValue("@id_conta", txt_usuario.Text)
                cmd.ExecuteNonQuery()
            End Using

            Dim sql As String = "DELETE FROM contas WHERE `contas`.`id_conta` = @id_conta"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id_conta", txt_usuario.Text)


                Dim linhasAfetadas As Integer = cmd.ExecuteNonQuery()


                If linhasAfetadas > 0 Then
                    MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information, "Sucesso")


                    LimparFormulario()
                Else

                    MsgBox("Nenhuma conta foi encontrada com o ID informado.", MsgBoxStyle.Exclamation, "Não Encontrado")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Erro ao tentar excluir a conta: " & ex.Message, MsgBoxStyle.Critical, "Erro de Banco de Dados")
        Finally

            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btn_bloquear_Click(sender As Object, e As EventArgs) Handles btn_bloquear.Click
        If String.IsNullOrWhiteSpace(txt_usuario.Text) Then
            MessageBox.Show("Por favor, digite o ID da conta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_usuario.Focus()
            Exit Sub
        End If

        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim statusAtual As String = ""
            Dim sqlBusca As String = "SELECT `status` FROM `contas` WHERE `id_conta` = @id;"

            Using cmdBusca As New MySqlCommand(sqlBusca, conn)
                cmdBusca.Parameters.AddWithValue("@id", txt_usuario.Text)
                Dim resultado As Object = cmdBusca.ExecuteScalar()

                If resultado Is Nothing OrElse IsDBNull(resultado) Then
                    MessageBox.Show("Nenhuma conta foi encontrada com o ID informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    statusAtual = resultado.ToString()
                End If
            End Using

            Dim novoStatus As String = ""
            Dim mensagemSucesso As String = ""

            If statusAtual = "ATIVO" Then
                novoStatus = "BLOQUEADO"
                mensagemSucesso = "Conta BLOQUEADA com sucesso! O cliente não poderá acessar o caixa."
            ElseIf statusAtual = "BLOQUEADO" Then
                novoStatus = "ATIVO"
                mensagemSucesso = "Conta DESBLOQUEADA com sucesso! O acesso foi restaurado."
            End If


            Dim sqlUpdate As String = "UPDATE `contas` SET `status` = @novoStatus WHERE `id_conta` = @id;"
            Using cmdUpdate As New MySqlCommand(sqlUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@novoStatus", novoStatus)
                cmdUpdate.Parameters.AddWithValue("@id", txt_usuario.Text)
                cmdUpdate.ExecuteNonQuery()
            End Using


            MessageBox.Show(mensagemSucesso, "Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o status da conta: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
