Imports MySql.Data.MySqlClient
Public Class FormExtrato
    Private Sub FormExtrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarSaldo()
        CarregarExtrato()
    End Sub


    Private Sub CarregarSaldo()
        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "SELECT `saldo` FROM `contas` WHERE `id_conta` = @id;"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", Cartao_acesso.IDContaLogada)

                Dim resultado As Object = cmd.ExecuteScalar()

                If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                    Dim saldoAtual As Decimal = Convert.ToDecimal(resultado)
                    lbl_saldo_atual.Text = "" & saldoAtual.ToString("C")
                Else
                    lbl_saldo_atual.Text = "R$ 0,00"
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar o saldo: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub CarregarExtrato()
        Dim conexaoBanco As New ConexaoBanco()
        Dim conn As MySqlConnection = conexaoBanco.ConectarBanco()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            Dim sql As String = "SELECT `id_registros` As 'ID', `data` As 'Data', `id_conta_from` As 'de', `id_conta_to` As 'para', `operacao` As 'Operacao'" &
                                "FROM `registros` " &
                                "WHERE `id_conta_to` = @id OR `id_conta_from` = @id " &
                                "ORDER BY `data` DESC;"

            Dim dtExtrato As New DataTable()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", Cartao_acesso.IDContaLogada)

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dtExtrato)
                End Using
            End Using


            dgv_extrato.DataSource = dtExtrato


            If dgv_extrato.Columns.Contains("ID") Then
                dgv_extrato.Columns("ID").Visible = False
            End If


            dgv_extrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            If dgv_extrato.Columns.Contains("Valor") Then
                dgv_extrato.Columns("Valor").DefaultCellStyle.Format = "c"
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar o extrato: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is menu_principal Then
                f.Show()
                Exit For
            End If
        Next
        Me.Close()
    End Sub


    Private Sub FormExtrato_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        For Each f As Form In Application.OpenForms
            If TypeOf f Is menu_principal Then
                f.Show()
                Exit For
            End If
        Next
    End Sub

End Class