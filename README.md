# Help Desk Ticketing System

A RESTful Help Desk Ticketing API built with **C#**, **ASP.NET Core Web API**, and **.NET 10**. This project simulates a real-world IT support system where users can create, update, retrieve, and delete support tickets.

---

## Features

- Create support tickets
- View all tickets
- View a ticket by ID
- Update ticket information
- Delete tickets
- Request validation using DTOs
- RESTful API design
- Tested using the VS Code REST Client
- Git version control with GitHub

---

## Tech Stack

- C#
- ASP.NET Core Web API
- .NET 10
- REST APIs
- Data Transfer Objects (DTOs)
- Git & GitHub
- VS Code

---

## Project Structure

```text
HelpDesk.Api/
├── Controllers/
├── DTOs/
├── Models/
├── Data/
├── Repositories/
├── Services/
├── Enums/
├── Properties/
├── Program.cs
├── appsettings.json
└── HelpDesk.Api.csproj
```

---

## API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/api/tickets` | Get all tickets |
| GET | `/api/tickets/{id}` | Get ticket by ID |
| POST | `/api/tickets` | Create a new ticket |
| PUT | `/api/tickets/{id}` | Update a ticket |
| DELETE | `/api/tickets/{id}` | Delete a ticket |

---

## Sample Request

```json
{
  "title": "Laptop cannot connect to Wi-Fi",
  "description": "The employee cannot connect to the office network.",
  "priority": "High"
}
```

---

## Current Status

### Completed

- ASP.NET Core Web API setup
- CRUD endpoints
- DTOs
- Request validation
- REST Client testing
- GitHub integration

### Coming Soon

- Entity Framework Core
- PostgreSQL
- Authentication (JWT)
- User Accounts
- Role-Based Authorization
- Docker
- Azure Deployment
- Swagger documentation
- Unit Testing

---

## Getting Started

Clone the repository:

```bash
git clone https://github.com/LilTeo48/helpdesk-ticketing-system.git
```

Navigate into the project:

```bash
cd helpdesk-ticketing-system
```

Run the API:

```bash
cd HelpDesk.Api
dotnet run
```

The API will be available at:

```
http://localhost:5011
```

---

## Author

**Tyler Chadwick**

- GitHub: https://github.com/LilTeo48
- LinkedIn: *(Add your LinkedIn URL here)*

---

## License

This project is licensed under the MIT License.
