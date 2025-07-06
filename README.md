# User Management API (C# ASP.NET Core)

This API provides CRUD operations for managing users. It includes validation, middleware for logging, and is structured for clarity.

## 🛠️ Tech Stack

- ASP.NET Core Web API
- C#
- Built-in Data Annotations for validation

## 📦 Endpoints

| Method | Endpoint            | Description          |
|--------|---------------------|----------------------|
| GET    | /api/users          | Get all users        |
| POST   | /api/users          | Create new user      |
| GET    | /api/users/{id}     | Get user by ID       |
| PUT    | /api/users/{id}     | Update existing user |
| DELETE | /api/users/{id}     | Delete user          |

## 🧪 Running the API

```bash
dotnet run
