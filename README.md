# IngressosNet

IngressosNet é um aplicativo de comércio eletrônico desenvolvido com ASP.NET MVC (.NET 8). Este projeto demonstra a utilização do padrão de design MVC para separar as preocupações de interface de usuário (view), dados (model) e lógica de aplicação (controller), facilitando a manutenção e a escalabilidade.

## Funcionalidades

- **Gerenciamento de Filmes e Cinemas**: Adicione, edite e remova filmes e cinemas.
- **Integração com Banco de Dados**: Utilização do Entity Framework para interação com um banco de dados SQL.
- **Autenticação e Autorização**: Implementação de autenticação baseada em cookies e autorização baseada em papéis.
- **Serviços e Repositórios Genéricos**: Criação de serviços e repositórios genéricos para operações comuns de CRUD.
- **Renderização Dinâmica de Conteúdo**: Uso de ViewComponents para renderização dinâmica de conteúdo.
- **Pagamentos Online**: Integração com o PayPal para processar pagamentos online.
- **Validação e Vinculação de Modelos**: Implementação de vinculação de modelos e validação de dados.

## Tecnologias Utilizadas

- **ASP.NET MVC**: Framework principal para desenvolvimento do aplicativo.
- **Entity Framework**: Ferramenta para mapeamento objeto-relacional (ORM) e migrações de banco de dados.
- **SQL Server**: Banco de dados utilizado para armazenamento dos dados.
- **Bootstrap**: Biblioteca para criação de interfaces responsivas.
- **PayPal SDK**: Integração para pagamentos online.
- **Autenticação e Autorização**: Implementação de autenticação baseada em cookies e autorização baseada em papéis.

## Funcionalidades em Detalhes

- **Modelos vs ViewModels**: Separação clara entre os dados da aplicação e os dados apresentados na interface do usuário.
- **Views vs PartialViews**: Uso de Views e PartialViews para criação de interfaces modulares e reutilizáveis.
- **Configuração do SQL Server com Entity Framework**: Configuração e utilização do Entity Framework para interação com o banco de dados SQL.
- **Migrações do Entity Framework**: Atualização do esquema do banco de dados utilizando migrações do Entity Framework.
- **Operações CRUD**: Adição, obtenção, atualização e exclusão de dados no banco de dados SQL utilizando o Entity Framework.
- **Trabalho com Dados Relacionais e Não-Relacionais**: Manipulação de dados relacionais e não-relacionais.
- **Injeção de Dependência**: Implementação de injeção de dependência e seus principais tempos de vida.
- **Serviços/Repositorios Estáticos e Genéricos**: Criação de serviços e repositórios genéricos para tarefas comuns.
- **Vinculação e Validação de Modelos**: Implementação de vinculação de modelos e validação de dados.
- **Roteamento**: Configuração e gerenciamento de rotas no ASP.NET MVC.
- **Autenticação e Autorização**: Implementação de autenticação baseada em cookies e autorização baseada em papéis.
- **Renderização Dinâmica com ViewComponents**: Uso de ViewComponents para renderização dinâmica de conteúdo.
- **Pagamentos Online com PayPal SDK**: Integração com PayPal para processar pagamentos online.

## Instalação e Execução

1. Clone o repositório:
   ```sh
   git clone https://github.com/etrupja/complete-ecommerce-aspnet-mvc-application.git
2. Navegue até o diretório do projeto:
   ```sh
   cd complete-ecommerce-aspnet-mvc-application
3. Restaure as dependências do projeto:
   ```sh
   dotnet restore
4. Atualize o banco de dados:
   ```sh
   dotnet ef database update
5. Execute o aplicativo:
   ```sh
   dotnet run

## Contato

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato:

[E-mail](danilo.silva@msn.com)

[LinkedIn](https://www.linkedin.com/in/ddcsilva/)

---

Este projeto faz parte do meu portfólio pessoal, demonstrando minhas habilidades em desenvolvimento de aplicações web com ASP.NET MVC e outras tecnologias. Fique à vontade para explorar o código e utilizá-lo como referência para seus próprios projetos.


