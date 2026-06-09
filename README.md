# Port ATM - Caixa Eletrônico portátil  🏧

Um sistema desktop completo de simulação de um caixa eletrônico (ATM), desenvolvido com foco em segurança lógica, integridade de dados e design de interface moderna. O projeto simula as operações reais de um terminal de autoatendimento, desde a validação do cartão até o processamento de transações financeiras.

## 🚀 O Projeto
O Port ATM foi construído para replicar as regras de negócio de um ambiente bancário real. Ele não apenas realiza operações financeiras, mas também gerencia ativamente a segurança das contas através de bloqueios automáticos e painéis administrativos, garantindo que o histórico de transações (`logs` e `registros`) nunca seja corrompido.

## ✨ Principais Funcionalidades

**🔐 Sistema de Autenticação e Segurança**
* **Acesso por Cartão e PIN:** Validação em duas etapas (Número do cartão + Senha).
* **Bloqueio Temporário Automático:** Suspensão da conta por tempo determinado (com cronômetro em tela) após 3 tentativas incorretas de senha.
* **Bloqueio Administrativo:** Revogação manual de acesso via painel do administrador.
* **Exclusão Lógica de Contas:** Contas excluídas recebem status de "BLOQUEADO", preservando a integridade das chaves estrangeiras e o histórico de transações no banco de dados.

**💰 Operações Financeiras**
* **Saques e Depósitos:** Atualização de saldo em tempo real.
* **Transferências:** Validação cruzada de agência e conta corrente do destinatário (com trava de segurança impedindo transferências para a própria conta).
* **Saldo e Extrato:** Consulta de histórico financeiro do usuário.

**🎨 Interface (UI/UX)**
* Design "Flat" e moderno, afastando-se do padrão clássico do Windows.
* Modo *Full Screen* (Tela Cheia) imersivo, ocultando barras de tarefas para simular um terminal real.
* Feedback visual em tempo real (mudança de cores em botões e alertas customizados).

## 🛠️ Tecnologias Utilizadas
* **Front-end:** Windows Forms (WinForms)
* **Back-end:** Visual Basic .NET (VB.NET)
* **Banco de Dados:** MySQL 
