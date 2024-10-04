# API Development Project

This project demonstrates the development of web services based on open standards such as XML, JSON, and HTTP(S).

## Project Overview

This Web API project is built using ASP.NET Core, focusing on:

- CRUD operations
- Data access using Entity Framework
- API documentation with Swagger
- Dependency Injection
- Security implementation

## Setup Instructions

1. Ensure you have .NET 6.0 SDK installed on your machine.
2. Clone this repository to your local machine.
3. Open the solution in Visual Studio or your preferred IDE.
4. Restore NuGet packages:
   ```
   dotnet restore
   ```
5. Build the project:
   ```
   dotnet build
   ```
6. Run the project:
   ```
   dotnet run
   ```

## Project Structure

- `WEB_API_PROJ.csproj`: Project file containing dependencies and configuration.
- `appsettings.json`: Application settings file.
- `Startup.cs`: Configuration for services and middleware.

## Features Implemented

1. **Dependency Injection**: Services are registered in the `ConfigureServices` method of `Startup.cs`.
2. **Swagger Integration**: API documentation is available through Swagger UI.
3. **Error Handling**: Custom error handling for production environment.
4. **Data Services**: Implemented `IHeroData`, `IFactionData`, and `IWeaponData` services.

## API Endpoints

The API includes:

- CRUD operations for Heroes, Factions, and Weapons
- RESTful endpoints following best practices

## Testing

You can test the API endpoints using Swagger UI, which is accessible when running the application in development mode.

## Technologies Used

- ASP.NET Core 6.0
- Swagger / OpenAPI
- Entity Framework
- Dependency Injection (Ninject)

## Future Improvements

- Implement authentication and authorization
- Add logging with Serilog
- Expand API functionality
- Implement full CRUD operations for all entities
- Add unit and integration tests

This project demonstrates proficiency in developing APIs using modern web technologies and best practices in software development.
