# API RESTful - Clientes

API RESTful desenvolvida em ASP.NET Core (.NET 8) no padrão MVC para gerenciamento de **Clientes**, como entrega do Desafio Final do Bootcammp de Arquitetura de Software da pós-graduação em Arquitetura de Software e Soluções da XP Educação. 

### 📦 Funcionalidades

- CRUD completo de clientes (criar, listar, buscar, atualizar, remover)
- Busca de clientes por nome
- Contagem total de clientes cadastrados
- Persistência no SQL Server utilizando Entity Framework Core.
- Documentação automática via Swagger
  
### 🛠️ Stack de Tecnologias

- Visual Studio 2022
- ASP.NET Core 8 (MVC)
- Entity Framework Core (ORM)
- SQL Server (persistência de dados)
- Swagger UI (documentação interativa da API)
- Draw.io (desenho arquitetural) 
  
### 📂 Estrutura do Projeto
```
└─ mvc-rest-api/ 
    ├── Controllers/                          # Controladores que gerenciam as requisições HTTP da API 
    │   └── ClienteController.cs              # Define os endpoints da API de Cliente 
    ├── Models/                               # Camada de domínio e regras de negócio 
    │   └── Entities/                         # Entidades de domínio 
    │   │   └── Cliente.cs                    # Representa a tabela Cliente no Banco de Dados 
    │   └── Services/                         # Contém a lógica de negócios (Service Layer) 
    │   │   └── ClienteService.cs             # Recebe o repositório via injeção de dependência. 
    │   └── Repositories/                     # Camada de persistência de dados 
    │   │   └── DataContext/                  # Gerencia o mapeamento com o Banco de Dados 
    │   │   │   └── DataContext.cs            # Herda DbContext do Entity Framework Core 
    │   │   └── Interfaces/                   # Contratos dos repositórios 
    │   │   │   └── IClienteRepository.cs     # Interface com métodos CRUD e outras operações 
    │   │   └── Implementations/              # Implementações dos repositórios 
    │   │   │   └── ClienteRepository.cs      # Implementa a interface IClienteRepository usando EF Core 
    ├── Migrations                            # Armazena as migrações do Entity Framework Core
    ├── Program.cs                            # O arquivo Program.cs é o ponto de entrada da aplicação 
    ├── appsettings.json                      # Arquivo principal de configuração da aplicação 
    ├── mvc-rest-api.csproj                   # Arquivo de projeto do .NET 
    └── (outros arquivos padrão do .NET, como.gitignore, Properties/launchSettings.json, etc.) 
```

### 📐 Arquitetura 
Fluxo da aplicação:  
``` Cliente → Controller → Service → Repository → DataContext → SQL Server ```

![Diagrama UML API](UML%20API%20Rest%20Cliente.png)

### 🔗 Endpoints

- `GET /api/cliente` — Lista todos os clientes
- `GET /api/cliente/{id}` — Busca cliente por ID
- `GET /api/cliente/nome/{nome}` — Busca clientes pelo nome
- `POST /api/cliente` — Cria um novo cliente
- `PUT /api/cliente/{id}` — Atualiza um cliente existente
- `DELETE /api/cliente/{id}` — Remove um cliente
- `GET /api/cliente/count` — Retorna a quantidade de clientes

### 📦 Como executar

1. **Pré-requisitos**:
   - .NET 8 SDK
   - SQL Server (local ou remoto)

2. Clone o repositório:  
   ```bash
   git clone https://github.com/seuusuario/mvc-rest-api.git
   
3. **Configuração do banco de dados**:
   - Defina a string de conexão em `appsettings.json` na chave `DefaultConnection`.

4. **Aplicando as migrations no Banco de dados**:
    - No terminal execute o comando: `dotnet ef database update`

4. **Executando a aplicação**
    - Com o banco de dados criado, você pode rodar a API para começar a usá-la.
    - Pressione `F5` ou no terminal execute o comando: `dotnet run`
    
5. **Acessando a documentação Swagger**:
    - Acesse `https://localhost:{porta}/swagger` no navegador.

### Observações

    - O projeto segue o padrão de repositório e injeção de dependência.
    - Para customizações, edite os arquivos em `Models`, `Controllers` e `Services`.
