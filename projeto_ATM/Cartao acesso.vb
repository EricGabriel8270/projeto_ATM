Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Cartao_acesso


    Dim ConexaoBanco As New ConexaoBanco()
    Dim Conn As MySqlConnection


    Public Shared IDContaLogada As String = ""
    Public Shared SenhaCorreta As String = ""
    Public Shared NumeroCartaoLogado As String = ""
    Public Shared NomeUsuarioLogado As String = ""
    Public Shared HorarioDesbloqueio As DateTime = DateTime.MinValue
    Public Shared QuantidadeDeBloqueios As Integer = 0
    Public Shared EstaBloqueioAtivo As Boolean = False

    Public Shared Sub GerarComprovanteTXT(operacao As String, valor As Decimal, contaDestino As String)
        Try

            Dim caminhoArquivo As String = Application.StartupPath & "\comprovantes_caixa.txt"


            Dim linhaDeTexto As String = $"DATA: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | " &
                                         $"OPERAÇÃO: {operacao.PadRight(15)} | " &
                                         $"VALOR: {valor.ToString("C").PadRight(15)} | " &
                                         $"CONTA ORIGEM: {IDContaLogada} | " &
                                         $"CONTA DESTINO: {contaDestino}" & Environment.NewLine


            File.AppendAllText(caminhoArquivo, linhaDeTexto)

        Catch ex As Exception

            Console.WriteLine("Erro ao gerar comprovante: " & ex.Message)
        End Try
    End Sub

    Private Sub Cartaoacesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = ConexaoBanco.ConectarBanco()
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

        If String.IsNullOrWhiteSpace(txt_display.Text) Then
            MessageBox.Show("Por favor, digite o número do seu cartão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If txt_display.Text = "111111" Then
            MessageBox.Show("Identificado Cartão Administrativo. Insira as credenciais.", "Modo Técnico", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_display.Clear()

            Dim telaLoginAdmin As New FormLoginAdmin()
            telaLoginAdmin.Show()
            Me.Hide()
            Exit Sub
        End If


        If EstaBloqueioAtivo Then
            If DateTime.Now < HorarioDesbloqueio Then
                Dim tempoRestante As TimeSpan = HorarioDesbloqueio - DateTime.Now
                Dim tempoFormatado As String = String.Format("{0:D2}:{1:D2}", tempoRestante.Minutes, tempoRestante.Seconds)

                MessageBox.Show($"O sistema está temporariamente bloqueado. Aguarde {tempoFormatado} para tentar novamente.",
                            "Acesso Suspenso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                EstaBloqueioAtivo = False
            End If
        End If


        If Conn.State = ConnectionState.Closed Then Conn.Open()

        Try

            Dim sql As String = "SELECT `id_conta`, `pin`, `cartao`, `nome completo`, `status` FROM `contas` WHERE `cartao` = @cartao LIMIT 1;"

            Using cmd As New MySqlCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@cartao", txt_display.Text)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then


                        Dim statusConta As String = reader("status").ToString()


                        If statusConta = "BLOQUEADO" Then
                            MessageBox.Show("Este cartão encontra-se BLOQUEADO no sistema! Por favor, dirija-se a uma agência.", "Cartão Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txt_display.Clear()
                            Exit Sub
                        End If


                        If statusConta = "Inativo" Then
                            MessageBox.Show("Esta conta foi desativada pelo administrador.", "Conta Inativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txt_display.Clear()
                            Exit Sub
                        End If


                        IDContaLogada = reader("id_conta").ToString()
                        SenhaCorreta = reader("pin").ToString()
                        NumeroCartaoLogado = reader("cartao").ToString()
                        NomeUsuarioLogado = reader("nome completo").ToString()




                        reader.Close()
                        If Conn.State = ConnectionState.Open Then Conn.Close()


                        Dim telaSenha As New menu_senha()
                        telaSenha.Show()
                        txt_display.Clear()
                        Me.Hide()
                    Else
                        MessageBox.Show("Cartão não encontrado ou inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_display.Clear()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao validar cartão: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class ConexaoBanco
    Dim conexao As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Function ConectarBanco() As MySqlConnection
        conexao = New MySqlConnection
        conexao.ConnectionString = "server=localhost;user id=root;password=;database=atm"
        Try

            conexao.Open()
            Return conexao
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return Nothing
        End Try
    End Function
End Class