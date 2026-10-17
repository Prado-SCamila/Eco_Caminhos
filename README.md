# Eco_Caminhos
🌿 EcoCaminhos: Gestão de Voluntários e Hospedagem

Sistema de banco de dados e API para gerenciar o programa de voluntariado da EcoCaminhos: quem são os voluntários, em qual casa e quarto estão hospedados, por quanto tempo ficam e qual é a situação financeira de cada um.

🎯 O problema
A gestão de voluntários costuma depender de planilhas e anotações soltas, o que dificulta responder perguntas básicas do dia a dia:
Quantos voluntários estão em cada casa e em cada quarto agora?
Quais quartos ainda têm vaga?
Quem está com pagamento pendente?
Quando cada voluntário entra e sai?

O EcoCaminhos centraliza essas informações em um banco relacional e as expõe por uma API, para que qualquer sistema (painel administrativo, site, aplicativo) consulte dados sempre atualizados e consistentes.

✨ Funcionalidades
Cadastro de voluntários com nacionalidade, programa, datas de entrada e saída e valor a devolver
Controle de casas e quartos, com capacidade por quarto
Controle de situação financeira (pago / pendente)
Classificação por tipo de programa
Consulta de ocupação por quarto, incluindo quartos vazios
Integridade garantida por chaves estrangeiras e restrições de unicidade


Banco de dados	Microsoft SQL Server (T-SQL)
API	ASP.NET Core + Dapper (ajuste conforme o seu projeto)
Versionamento	Git e GitHub
