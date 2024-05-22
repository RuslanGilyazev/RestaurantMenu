# .NET CRUD Application Demo - RestaurantMenu

This repository contains a demonstration of a simple CRUD (Create, Read, Update, Delete) application showcasing basic functionalities. The project includes logging, validation, and test coverage. The application is built using .NET 8 and Entity Framework.

## Features

- **CRUD Operations**: Basic operations for creating, reading, updating, and deleting records.
- **Logging**: Integrated logging to track application activities and errors.
- **Validation**: Data validation to ensure the integrity and correctness of the data.
- **Test Coverage**: Unit and integration tests to ensure the application works as expected.

## Technologies Used

- **.NET 8**: The latest version of the .NET platform.
- **PostgreSQL**: A powerful, open-source object-relational database system.
- **Entity Framework**: An ORM framework for data access.
- **Mapster**: A high-performance object mapping library.
- **FluentValidation**: A popular .NET library for building strongly-typed validation rules.
- **Docker**: Containerization for easy deployment.
- **Docker Compose**: Orchestration for multi-container Docker applications.

## Getting Started

### Prerequisites

- .NET 8 SDK: [Download and install .NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Docker: [Download and install Docker](https://www.docker.com/get-started)
- Docker Compose: [Download and install Docker Compose](https://docs.docker.com/compose/install/)

### Running the Application

To run the application using Docker Compose, use the following command:
```sh
docker-compose up