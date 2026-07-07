# Medicine Management API

A RESTful CRUD API for pharmacy medicine management, built with ASP.NET Core and Entity Framework Core. Developed as a hands-on backend project to demonstrate API design, database integration, and clean architecture principles, inspired by a larger pharmacy management system project.

## Tech Stack

- **Framework:** ASP.NET Core Web API (.NET 10)
- **ORM:** Entity Framework Core
- **Database:** SQLite
- **API Documentation:** Swagger / OpenAPI (Swashbuckle)

## Features

- Full CRUD operations (Create, Read, Update, Delete) for medicine records
- Code-first database design with EF Core Migrations
- RESTful API design following standard HTTP conventions
- Interactive API documentation via Swagger UI
- Dependency Injection for clean separation of concerns

## API Endpoints

| Method | Endpoint                | Description                  |
|--------|--------------------------|-------------------------------|
| GET    | `/api/medicines`         | Get all medicines             |
| GET    | `/api/medicines/{id}`    | Get a specific medicine by ID |
| POST   | `/api/medicines`         | Add a new medicine            |
| PUT    | `/api/medicines/{id}`    | Update an existing medicine   |
| DELETE | `/api/medicines/{id}`    | Delete a medicine             |

## Medicine Model

```json
{
  "id": 0,
  "name": "string",
  "category": "string",
  "price": 0,
  "quantity": 0,
  "expiryDate": "2026-01-01T00:00:00"
}
```

## Getting Started

### Prerequisites
- .NET SDK 10.0 or later
- Visual Studio 2022+ (or any IDE with C# support)

### Setup

1. Clone the repository:
```bash
git clone https://github.com/yousefsobhy12/MedicineManagementAPI.git
```

2. Navigate to the project directory:
```bash
cd MedicineManagementAPI/MedicineManagementAPI
```

3. Apply database migrations:
```bash
dotnet ef database update
```

4. Run the project:
```bash
dotnet run
```

5. Open Swagger UI in your browser:
```
https://localhost:{port}/swagger
```

## Project Structure

```
MedicineManagementAPI/
├── Controllers/
│   └── MedicinesController.cs   # API endpoints
├── Data/
│   └── AppDbContext.cs          # EF Core database context
├── Models/
│   └── Medicine.cs               # Medicine entity model
├── Migrations/                   # EF Core migration history
└── Program.cs                    # App configuration & DI setup
```

## Author

**Yousef Sobhy**
Flutter Developer | Backend Engineering Enthusiast
