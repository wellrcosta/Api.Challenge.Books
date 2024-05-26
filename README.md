# Api.Challenge.Books

Api.Challenge.Books é uma API de gestão de livraria, desenvolvida em .NET 8 utilizando o template WebAPI. Esta API permite realizar operações CRUD (criar, ler, atualizar, excluir) em livros, incluindo informações como título, autor, gênero, preço e quantidade em estoque.

## Funcionalidades

- **Criar um livro:** Permite adicionar um novo livro à base de dados.
- **Ver todos os livros:** Retorna uma lista de todos os livros cadastrados.
- **Editar as informações de um livro:** Permite atualizar as informações de um livro existente.
- **Excluir um livro:** Remove um livro da base de dados.

## Instalação

1. Certifique-se de ter o SDK do .NET 8 instalado em sua máquina.
2. Clone este repositório:

   ```bash
   git clone https://github.com/wellrcosta/Api.Challenge.Books.git
   ```

3. Navegue até o diretório do projeto:

   ```bash
   cd Api.Challenge.Books
   ```

4. Execute a aplicação:

   ```bash
   dotnet run
   ```

5. Acesse a API em `http://localhost:5000`.

## Uso

- Consulte a documentação Swagger em `http://localhost:5000/swagger` para obter detalhes sobre os endpoints e como utilizá-los.
- Utilize ferramentas como Postman ou curl para realizar requisições HTTP aos endpoints da API.

## Banco de Dados

Esta API utiliza PostgreSQL como banco de dados. Para facilitar a configuração e execução, um arquivo `docker-compose.yml` está disponível.

### Subir o Banco de Dados com Docker

1. Certifique-se de ter o Docker instalado e em execução em sua máquina.
2. Para subir o banco de dados PostgreSQL execute:

   ```bash
   docker-compose up --build
   ```

3. A API estará disponível em `http://localhost:5000` e o banco de dados PostgreSQL estará configurado conforme definido no `docker-compose.yml`.

## Tecnologias Utilizadas

- .NET 8
- Entity Framework Core
- PostgreSQL (Banco de Dados)
- Docker (para execução em contêineres)

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir um PR ou uma issue para sugestões, correções ou melhorias.

## Licença

Este projeto está licenciado sob a [Licença MIT](https://opensource.org/licenses/MIT).