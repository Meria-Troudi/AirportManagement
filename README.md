# Airport Management System

This project is a modular .NET solution for managing airport operations, including flights, passengers, planes, and tickets. It is organized into three main layers:

## Solution Structure

- **AM.ApplicationCore**: Contains core domain models, interfaces, and business logic services.
  - `Domain/`: Entity classes such as Flight, Passenger, Plane, Ticket, etc.
  - `Interfaces/`: Interface definitions for business logic.
  - `Services/`: Implementation of business logic and extension methods.
- **AM.Infrastructure**: Handles data access and persistence using Entity Framework Core.
  - `AMContext.cs`: Database context configuration.
  - `Configurations/`: Entity configurations for EF Core.
  - `Migrations/`: Database migration files.
- **AM.UI.Console**: Console application for interacting with the system.
  - `Program.cs`: Entry point for the console UI.

## Features

- Manage flights, passengers, planes, and tickets
- Entity Framework Core for data persistence
- Modular architecture for easy maintenance and scalability
- Console-based user interface

## Getting Started

1. **Clone the repository**
2. **Open the solution**: `AirportManagement4ARCTIC4.sln` in Visual Studio or your preferred IDE.
3. **Restore NuGet packages**
4. **Apply Migrations** (if using a database):
   - Open the Package Manager Console
   - Run `Update-Database` in the `AM.Infrastructure` project
5. **Run the application**:
   - Set `AM.UI.Console` as the startup project
   - Start debugging or run without debugging

## Project Requirements

- .NET 8.0 SDK
- Entity Framework Core

## Folder Overview

- `AM.ApplicationCore/Domain/`: Core domain entities
- `AM.ApplicationCore/Services/`: Business logic
- `AM.Infrastructure/Configurations/`: EF Core entity configurations
- `AM.Infrastructure/Migrations/`: Database migrations
- `AM.UI.Console/`: Console UI

## Contributing

Feel free to fork this repository and submit pull requests. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.
