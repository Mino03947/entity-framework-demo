# 🛠️ EF Core ORM Workshop: Step-by-Step Tutorial

## Overview

In this workshop, you'll build a simple e-commerce CRUD API using Entity Framework Core in ASP.NET Core (.NET 8), with Visual Studio 2022.

### You'll learn:

- How to define entities
- Set up EF Core and database context
- Apply migrations and create the database
- Implement CRUD endpoints
- Introduce a repository pattern for abstraction

## Technologies

- ASP.NET
- Entity Framework Core
- SQL Server
- Visual Studio 2022

## Entities

We will model two basic entities:

- Product
  - Id
  - Name
  - Description
  - Price
  - CategoryId (FK)
- Category
  - Id
  - Name

---

## Step-by-Step Guide

### 📦 Step 1 – Clone this Repo

Open your terminal and choose the desired folder where you want to download the project.
```bash
git clone https://github.com/Mino03947/entity-framework-demo.git
```

### ✅ Step 2 – Install Required NuGet Packages

Install the following packages via NuGet Package Manager or CLI:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`

### ✅ Step 3 – Create Models (Entities)

- Create a folder named `Models`
- Add two classes: `Product` and `Category`
- Add properties as defined in the Entities section above
- Add DTO classes for handling requests and responses.

### ✅ Step 4 – Create and Configure DbContext

- Create a folder named `Data`
- Add a class called `ECommerceDbContext`
- Inherit from `DbContext`
- Add `DbSet<Product>` and `DbSet<Category>`

### ✅ Step 5 – Configure EF Core in appsettings.json

- Add a connection string under `ConnectionStrings`
- Example: `(localdb)\\MSSQLLocalDB` with a database named `ECommerceDB`

### ✅ Step 6 – Register DbContext in Program.cs

- Use `builder.Services.AddDbContext` to register `ECommerceDbContext`
- Use `builder.Configuration.GetConnectionString` to pass the connection

### ✅ Step 7 – Run Migrations

- Open Package Manager Console
- Run the following:
  - `Add-Migration InitialCreate`
  - `Update-Database`

### ✅ Step 8 – Create CRUD Controllers

- Create:
  - `ProductsController`
  - `CategoriesController`
- Define and inject the `ECommerceDbContext` in the controller, as `_context`.
- Use `_context` to start interacting with the DbContext.
- Implement the typical CRUD actions: GET, POST, PUT, DELETE

### ✅ Step 9 – Test the API

- Run the API
- Use Swagger or Postman to test endpoints
  - Create Categories
  - Create Products (linked to Categories)
  - Retrieve and filter data

### ✅ Step 10 – Implement Repository Pattern (Bonus)

- Create a folder named `Repositories`
- Define `IProductRepository` and `ICategoryRepository` interfaces
- Implement `ProductRepository` and `CategoryRepository` classes
- Move all EF Core logic from controllers to repositories
- Update dependency injection in `Program.cs`
- Refactor controllers to use repositories instead of `DbContext` directly
