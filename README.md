# 📕 Book Collection API

A production-ready REST API built with **ASP.NET Core** for managing book collections with JWT authentication.  
Demonstrates clean architecture, modern backend practices, and enterprise-grade API design.

---

## 🚀 Live Demo

**API Base URL:** `https://bookcollectionapi-ewddceafbqcja8d4.swedencentral-01.azurewebsites.net`

**Swagger Documentation:** `https://bookcollectionapi-ewddceafbqcja8d4.swedencentral-01.azurewebsites.net/swagger`

> 💡 **Tip:** Try the interactive API documentation in Swagger to test all endpoints!

---

## ✈️ Overview

The **Book Collection API** is a CRUD-based REST service with JWT authentication and role-based authorization.  
Initially planned as a Christmas break learning project, it evolved into a comprehensive backend system showcasing production-ready practices.

**Project Purpose:**
- Backend-focused portfolio piece
- Preparation for Bachelor's thesis (Informatics / System Development)
- Demonstration of professional .NET development skills
- Foundation for future supermarket management system thesis project

---

## 🛠 Tech Stack

### Core Technologies
- **.NET 8.0** - Latest LTS framework
- **ASP.NET Core Web API** - RESTful API framework
- **Entity Framework Core** - ORM for database operations
- **SQL Server** - Relational database (Azure SQL)

### Architecture & Patterns
- **Repository Pattern** - Data access abstraction
- **DTO Pattern** - Clean API contracts
- **Dependency Injection** - Loose coupling
- **Async/Await** - Non-blocking operations

### Authentication & Security
- **JWT Bearer Tokens** - Stateless authentication
- **Refresh Tokens** - Token renewal mechanism
- **Role-Based Authorization** - User/Admin roles
- **BCrypt Password Hashing** - Secure credential storage

### Additional Libraries
- **AutoMapper** - Object-to-object mapping
- **Newtonsoft.Json** - JSON serialization & JSON Patch
- **Swashbuckle** - OpenAPI/Swagger documentation

### DevOps & Deployment
- **Azure App Service** - Cloud hosting
- **Azure SQL Database** - Managed database
- **GitHub Actions** - CI/CD pipeline
- **Git** - Version control

---

## 🔆 Features

### Core Functionality
- ✅ Full **CRUD** operations for books
- ✅ **User registration & authentication**
- ✅ **JWT token-based security**
- ✅ **Role-based authorization** (User, Admin)
- ✅ **Refresh token mechanism** for session management

### API Design
- ✅ **RESTful architecture** following HTTP standards
- ✅ **DTO-based contracts** for clean separation
- ✅ **Partial updates (PATCH)** using JSON Patch
- ✅ **Input validation** with Data Annotations
- ✅ **Swagger/OpenAPI** interactive documentation

### Code Quality
- ✅ **Repository pattern** for testable data access
- ✅ **AutoMapper** for maintainable mappings
- ✅ **Async/await** for scalable performance
- ✅ **Dependency injection** throughout

---

## 📋 API Endpoints

### 🔐 Authentication
| Method | Endpoint | Description | Public |
|--------|----------|-------------|--------|
| POST | `/api/auth/register` | Register new user | ✅ |
| POST | `/api/auth/login` | Login and receive JWT tokens | ✅ |
| POST | `/api/auth/refresh-token` | Refresh access token | ✅ |

**Example Request (Register):**
```json
POST /api/auth/register
{
  "username": "richmond",
  "password": "SecurePass123!"
}
```

**Example Response:**
```json
{
  "id": 1,
  "username": "richmond",
  "role": "User"
}
```

---

### 📚 Books Management
| Method | Endpoint | Description | Auth Required |
|--------|----------|-------------|---------------|
| GET | `/api/books` | Get all books | ❌ No |
| GET | `/api/books/{id}` | Get book by ID | ❌ No |
| POST | `/api/books` | Create new book | ✅ Yes |
| PUT | `/api/books/{id}` | Update entire book | ✅ Yes |
| PATCH | `/api/books/{id}` | Partial update book | ✅ Yes |
| DELETE | `/api/books/{id}` | Delete book | ✅ Yes (Admin only) |

**Example Request (Create Book):**
```json
POST /api/books
Authorization: Bearer {your-jwt-token}

{
  "title": "Clean Coding",
  "author": "Richmond Boakye",
  "description": "A handbook for agile software developers",
  "genre": "Technology",
  "publicationYear": 2025
}
```

---

## 🧪 Testing the API

### Option 1: Swagger UI (Recommended)

1. Visit the [Swagger UI](https://bookcollectionapi-ewddceafbqcja8d4.swedencentral-01.azurewebsites.net/swagger)
2. Click **"Try it out"** on any endpoint
3. For protected endpoints:
   - First, use `/api/auth/register` and `/api/auth/login`
   - Copy the `accessToken` from the login response
   - Click the **"Authorize"** button (🔒 lock icon)
   - Enter: `Bearer {your-access-token}`
   - Click **"Authorize"**
   - Now you can test protected endpoints!

### Option 2: Postman

1. Import the API collection
2. Set base URL: `https://bookcollectionapi-ewddceafbqcja8d4.swedencentral-01.azurewebsites.net`
3. Add header: `Authorization: Bearer {token}`


---

## 📚 Learning Resources & References

### Official Documentation
- [ASP.NET Core Dependency Injection](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- [Entity Framework Core – DbContext Configuration](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/)
- [EF Core Connection Strings](https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings)
- [Data Annotations Validation](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations)
- [JWT Authentication in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/)
- https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-10.0
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-10.0
- https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings?tabs=dotnet-core-cli

### Problem-Solving Resources
- [SQL Server Certificate Trust Issue](https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted)
- [EF Core Table Naming](https://learn.microsoft.com/en-us/answers/questions/494218/how-to-change-the-table-name-to-lower-case-in-gene)

### Tutorial References
- [Les Jackson's .NET REST API Tutorial](https://www.youtube.com/watch?v=fmvcAzHpsk8)
- [JWT Authentication Tutorial](https://www.youtube.com/watch?v=6EEltKS8AwA)
- https://www.youtube.com/watch?v=nVHEnRA8LL4&t=291s

---

## 🏗️ Project Architecture
```
BookCollectionAPI/
├── Controllers/          # API endpoints
│   ├── AuthController    # Authentication (register, login, refresh tokens)
│   └── BooksController   # CRUD operations for books
│
├── Services/             # Business logic
│   └── AuthService       # JWT token management
│
├── Data/                 # Data access
│   ├── BookCollectionContext      # EF Core DbContext
│   └── SqlBookCollectionsRepo     # Repository pattern implementation
│
├── Models/Entities/      # Domain models
│   ├── Book              # Book entity
│   └── User              # User entity with authentication
│
├── Dtos/                 # Data transfer objects
│   ├── Book DTOs         # Create, Read, Update
│   └── Auth DTOs         # User, Token, Refresh
│
├── Profiles/             # AutoMapper configurations
│
├── Migrations/           # EF Core database migrations
│
└── Program.cs            # Application startup & DI configuration
```

---

## 🏹 Next Steps (Planned Enhancements)

### Short-term (Next 2 weeks)
- [ ] **Unit Testing** - xUnit test suite
- [ ] **Integration Testing** - API endpoint tests
- [ ] **Logging** - Structured logging with Serilog
- [ ] **Pagination** - Efficient data retrieval for large datasets

### Medium-term (Thesis preparation)
- [ ] **Advanced Filtering** - Query parameters for search
- [ ] **Sorting** - Flexible result ordering
- [ ] **Caching** - Redis for performance optimization
- [ ] **Rate Limiting** - API abuse prevention

### Long-term (Professional practice)
- [ ] **Microservices** - Service decomposition
- [ ] **Message Queuing** - RabbitMQ/Azure Service Bus
- [ ] **Docker** - Containerization
- [ ] **Kubernetes** - Orchestration for scalability

---

## 🚀 Local Development

### Prerequisites
- .NET 8.0 SDK
- SQL Server or SQL Server Express
- Visual Studio 2022 / VS Code / Rider

### Setup

1. **Clone the repository**
```bash
git clone https://github.com/Richmondbh/BookCollectionAPI.git
cd BookCollectionAPI
```

2. **Update connection string**

Right-click project → **Manage User Secrets**
```json
{
  "ConnectionStrings": {
    "BooksConnection": "Server=localhost\\SQLEXPRESS;Database=BookCollectionDb;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "AppSettings": {
    "Token": "YourSuperSecretKeyHere",
    "Issuer": "BookCollectionAPI",
    "Audience": "BookCollectionAPIUsers"
  }
}
```

3. **Run migrations**
```bash
dotnet ef database update
```

4. **Run the application**
```bash
dotnet run
```

5. **Access Swagger**
```
https://localhost:7XXX/swagger
```

---

## 📊 Deployment

### GitHub Actions CI/CD

This project uses **GitHub Actions** for continuous deployment to Azure:

1. Code pushed to `main` branch
2. GitHub Actions workflow triggered
3. Build and test
4. Deploy to Azure App Service
5. Live in ~3-5 minutes! 🚀

**View the workflow:** `.github/workflows/azure-deploy.yml`

---

## 👤 Author

**Richmond Boakye**  
System Development / Informatics Student @ Mittuniversitetet (Mid Sweden University)

- 📧 Email: richmondboakye0017@gmail.com
- 💼 LinkedIn: [Richmond Boakye](https://www.linkedin.com/in/richmond-boakye-188678207/) 
- 🐙 GitHub: [@Richmondbh](https://github.com/Richmondbh)
- 🎓 Focus: Backend Development with .NET, C#

---

## 📜 License

This project is open source and available for educational purposes.

---

## 🙏 Acknowledgments

- **Les Jackson** - For excellent ASP.NET Core tutorials
- **Patrick God** -  For excellent JWT authntication tutorials
- **Microsoft Learn** - Comprehensive .NET documentation
- **Mittuniversitetet** - Academic foundation in System Development

---

**⭐ If you find this project helpful, consider giving it a star!**

---

*Last updated: December 25, 2024*
