
# WCA Inteligência Comercial - Desafio
Montar uma aplicação web que permita ao usuário fazer o cadastro de Cliente x Produto x Vendas (CRUD)
- Utilizar o Ado.Net como ORM para a tabela de Vendas (OK)
- Utilizar o Ado.Net como ORM para a tabela de Cliente (OK)
- Utilizar o EF Core como ORM para a tabela de Produto (OK)
- Utilizar o DDD na hora de organizar o Projeto (OK)
- Adicionar 1 query utilizando Inner Join utilizando Ado.Net (OK)
- Adicionar 1 query utilizando Left Join utilizando Ado.Net (OK)
- Gerar 1 lista integrando 2 entidades utilizando Left Join c/ LINQ (OK)
- Gerar 1 lista integrando 2 entidades utilizando Inner Join c/ LINQ (OK)
- Adicionar pelo menos 1 chamada do front-end chamando um método do back-end utilizando AJAX (OK)

## OBS
O projeto foi desenvolvido no Windows, usando SQL Server Express. É Importante que o projeto execute no mesmo sistema operacional para ter o máximo de compatibilidade.

## Pacotes utilizdos
- Bogus
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- AutoMapper
- AutoMapper.Extensions.Microsoft.DependencyInjection
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- Microsoft.Extensions.Configuration.Abstractions
- Microsoft.Extensions.DependencyInjection.Abstractions
- xunit
-xunit.runner.visualstudio
- Microsoft.NET.Test.Sdk
- Moq
- coverlet.collector

## Test
Os testes realizados no projeto não representam as unidades utilizadas no projeto em sua totalidade, devido à várias mudanças durante o desenvolvimento. Devido ao prazo, foi decidio manter o código dos testes

## Como executar
- Baixe o projeto no link:`https://github.com/vitorpcruz/websales`
- Navegue até a página do projeto
- Na pasta do projeto abra um terminal
- Execute a seguinte linha de comando para que as migrações contidas no projeo criem o banco de dados: `dotnet ef database update -s .\src\WebSales.WebInterface\WebSales.WebInterface.csproj`
- Build o projeto com o seguinte comando: `dotnet build`
- Execute o seguinte comando para executar o projeto: `dotnet run --project .\src\WebSales.WebInterface\WebSales.WebInterface.csproj`
- Pode acessar o projeto via  `https://localhost:7089`

