# CleanUserApi 
[Leer en español](./README.es.md)

User REST API built with **.NET 8**, **Clean Architecture**, **Entity Framework Core**, **SQL Server LocalDB**, **AutoMapper** and **Swagger**.

This project was designed as a modern, scalable, and easily extensible API—ideal as a foundation for microservices or as a professional portfolio example.

---

## 🚀 Main Features

- ✔ .NET 8 Web API
- ✔ Clean Architecture
- ✔ Full User CRUD (/api/users)
- ✔ SQL Server LocalDB + EF Core
- ✔ DTOs + AutoMapper
- ✔ Validation using DataAnnotations
- ✔ Swagger / OpenAPI included
- ✔ Clear separation of layers:
  - Domain
  - Application
  - Infrastructure
  - Api

---

## 📂 Project Structure

```
Pon.CleanUsers.Api/
├─ Pon.CleanUsers.Api/ → Controllers, Program.cs, Swagger
├─ Pon.CleanUsers.Application/ → DTOs, Interfaces, Services, Mapping Profiles
├─ Pon.CleanUsers.Domain/ → Entities and domain rules
└─ Pon.CleanUsers.Infrastructure/ → EF Core, Repositories, SQL Server LocalDB
```

---

## 🧱 Technologies Used

- .NET 8
- Entity Framework Core 8
- SQL Server LocalDB
- AutoMapper
- Swagger (Swashbuckle)
- Clean Architecture
- C# 12

---

## ⚙️ Project Setup

### 1. Clone the repository

```bash
git clone https://github.com/tu-usuario/CleanUserApi.git
cd Pon.CleanUsers.Api
```

## 2. Database Configuration (LocalDB)

The project uses SQL Server LocalDB, included with Visual Studio.

You can update the connection string in `Pon.CleanUsers.Api/appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CleanUserApi;Trusted_Connection=True;"
}
```

## 3. Apply migrations

```bash
cd Pon.CleanUsers.Api
dotnet ef migrations add InitialCreate -p ../Infrastructure -s ./ 
dotnet ef database update -p ../Infrastructure -s ./
```
(Or create your own migrations if needed.)

---

## ▶️ Run the Project

From the root folder:

```bash
dotnet run --project src/WebApi
```

The API will be available at:

👉 https://localhost:5001/swagger

👉 http://localhost:5000/swagger

---

## 📌Available Endpoints

### GET /api/users
Returns all users.

### GET /api/users/{id}
Returns a user by ID.

### POST /api/users
Creates a new user.

Example:

```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}
```

### PUT /api/users/{id}
Updates an existing user.

### DELETE /api/users/{id}
Deletes a user.

---

## 🧪 Possible Improvements

- JWT Authentication
- Global exception handling
- Soft delete
- Unit and integration tests
- Redis caching layer
- Pagination and filtering
- Dockerfile + docker-compose

---

## 👤 Author

### Martín Ponce

Software Developer – .NET / Node.js

https://martinponce.com.ar

---

## ⭐ If you found this useful

Feel free to leave a ⭐ on the repository or contact me for collaborations or freelance projects.
