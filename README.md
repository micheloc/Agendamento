# Windows Forms Application

## Descrição

Este é um sistema desenvolvido em **Windows Forms** utilizando o **.NET 6**, com uma arquitetura baseada nos princípios de **Domain-Driven Design (DDD)**. A aplicação se conecta a um banco de dados **PostgreSQL** para gerenciar e armazenar os dados.

## Tecnologias Utilizadas

- **.NET 6**: A versão mais recente da plataforma .NET, proporcionando alto desempenho e suporte a longo prazo.
- **Windows Forms**: Framework para a criação de interfaces gráficas desktop.
- **Domain-Driven Design (DDD)**: Arquitetura que prioriza a modelagem do domínio de negócio, separando responsabilidades em camadas distintas.
- **PostgreSQL**: Banco de dados relacional, utilizado para armazenar e gerenciar os dados da aplicação.

## Arquitetura

Este projeto adota o padrão de arquitetura **DDD (Domain-Driven Design)**, que organiza o código em camadas distintas:
-
- **Services**: Engloba todo o padrão descrito abaixo. 
- **Domain**: Contém as entidades, agregados, e lógica de domínio. É o núcleo do projeto.
- **Application**: Contém os casos de uso, coordenando as operações que precisam ser realizadas.
- **Data**: Contém a implementação dos repositórios e a configuração de banco de dados (PostgreSQL).

- 
- **UI**: Interface de usuário desenvolvida em Windows Forms, onde os usuários interagem com o sistema.

## Conexão com o Banco de Dados

A conexão com o banco de dados **PostgreSQL** foi configurada utilizando **Entity Framework Core**, permitindo a interação entre a aplicação e o banco de forma eficiente e segura.

### Configuração do Banco de Dados

Certifique-se de que o PostgreSQL esteja instalado e configurado corretamente em sua máquina. Em seguida, ajuste a string de conexão no arquivo de configuração da aplicação para refletir as credenciais do seu banco de dados.

```csharp
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=nome_do_banco;Username=seu_usuario;Password=sua_senha"
}
"# Agendamento" 
