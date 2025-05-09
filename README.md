# 📝 TaskManagerApp (.NET 8 Web App)

A simple task management web application built using **ASP.NET Core Razor Pages**, running on a **Linux VM** with **SQLite** as the database.

---

## 🚀 Features

- Add and view tasks
- SQLite database with Entity Framework Core
- Runs on .NET 8
- Ready to deploy on Linux VM

---

## 🧰 Prerequisites

Install the following on your Linux VM:

```bash
# Install .NET 8 SDK
sudo apt update
sudo apt install -y dotnet-sdk-8.0

# Optional: Confirm .NET installation
dotnet --version
```

## 🧰 STEPS
```bash
# Clone or Create the Project
dotnet new webapp -n TaskManagerApp
cd TaskManagerApp


# Install EF Core & Create DB
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool install --global dotnet-ef

# Add EF tool path (if not already):
export PATH="$PATH:$HOME/.dotnet/tools"

# Create DB:
dotnet ef migrations add InitialCreate
dotnet ef database update


# Run the App
dotnet run

# Access it:
http://<Your-VM-Public-IP>:5298/Tasks


