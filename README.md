# CleanUserApi  
API REST de Usuarios desarrollada con **.NET 8**, **Clean Architecture**, **Entity Framework Core**, **SQL Server LocalDB**, **AutoMapper** y **Swagger**.

Este proyecto fue diseñado como una API moderna, escalable y fácil de extender, ideal como base para microservicios o como ejemplo profesional para portfolios.

---

## 🚀 Características principales

- ✔ **.NET 8 Web API**
- ✔ **Arquitectura Limpia (Clean Architecture)**
- ✔ **CRUD completo de Usuarios (`/api/users`)**
- ✔ **SQL Server LocalDB + EF Core**
- ✔ **DTOs + AutoMapper**
- ✔ **Validación con DataAnnotations**
- ✔ **Swagger / OpenAPI incluido**
- ✔ Separación clara en capas:
  - **Domain**
  - **Application**
  - **Infrastructure**
  - **Api**

---

## 📂 Estructura del proyecto

```
Pon.CleanUsers.Api/
├─ Pon.CleanUsers.Api/ → Controllers, Program.cs, Swagger
├─ Pon.CleanUsers.Application/ → DTOs, Interfaces, Services, Mapping Profiles
├─ Pon.CleanUsers.Domain/ → Entidades y reglas de negocio
└─ Pon.CleanUsers.Infrastructure/ → EF Core, Repositories, SQL Server LocalDB
```

---

## 🧱 Tecnologías utilizadas

- **.NET 8**
- **Entity Framework Core 8**
- **SQL Server LocalDB**
- **AutoMapper**
- **Swagger (Swashbuckle)**
- **Clean Architecture**
- **C# 12**

---

## ⚙️ Configuración del proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/CleanUserApi.git
cd Pon.CleanUsers.Api
```

## 2. Configuración de la base de datos (LocalDB)

El proyecto utiliza SQL Server LocalDB, incluido con Visual Studio.

Podés modificar la conexión en WebApi/appsettings.json:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CleanUserApi;Trusted_Connection=True;"
}
```

## 3. Aplicar migraciones

```bash
cd Pon.CleanUsers.Api
dotnet ef migrations add InitialCreate -p ../Infrastructure -s ./ 
dotnet ef database update -p ../Infrastructure -s ./
```
(O podés crear tus propias migraciones si preferís.)

---

## ▶️ Ejecutar el proyecto

Desde la carpeta raíz:

```bash
dotnet run --project src/WebApi
```

La API quedará disponible en:

👉 https://localhost:5001/swagger

👉 http://localhost:5000/swagger

---

## 📌 Endpoints disponibles

### GET /api/users
Obtiene la lista de usuarios.

### GET /api/users/{id}
Obtiene un usuario por ID.

### POST /api/users
Crea un nuevo usuario.
Ejemplo:

```json
{
  "firstName": "Juan",
  "lastName": "Pérez",
  "email": "juan@example.com"
}
```

### PUT /api/users/{id}
Actualiza un usuario existente.

### DELETE /api/users/{id}
Elimina un usuario.

---

## 🧪 Mejoras que pueden implementarse

- Autenticación con JWT
- Manejo global de excepciones
- Soft delete
- Tests unitarios y de integración
- Capa de caché con Redis
- Paginación y filtros en los listados
- Dockerfile + docker-compose

---

## 👤 Autor

Martín Ponce

Desarrollador de Software – .NET / Node.js

https://martinponce.com.ar

---

## ⭐ Si te resultó útil

Podés dejar una ⭐ en el repositorio o contactarme para colaboraciones o proyectos freelance.
