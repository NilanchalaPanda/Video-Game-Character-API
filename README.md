# 🎮 Video Game Character API

A modern backend API to manage video game characters — built with clean architecture, containerization, and cloud deployment in mind.

This project demonstrates how to build, containerize, and deploy a scalable API using **.NET 10, PostgreSQL, Docker, and Render**.

---

## 🌟 What is this project about?

Imagine you are building a game or an app where you want to:

- Add new characters 🎯  
- View all characters 📋  
- Update their roles ⚔️  
- Remove characters ❌  

This API acts as the **backend engine**, handling all these operations efficiently and reliably.

---

## ✨ Key Highlights

- Clean and scalable API architecture  
- Fully containerized using Docker 🐳  
- Cloud deployed on Render ☁️  
- Uses PostgreSQL for production-grade storage 🗄️  
- Automatic database migrations on startup  
- Interactive API documentation via Swagger  
- Environment-based configuration (secure & production-ready)

---

## 🧩 How the system works (Simple View)

User Request → API → Service Layer → Database → Response

- Client sends a request  
- API processes it  
- Business logic is applied  
- Data is stored/retrieved from PostgreSQL  
- Response is returned  

---

## 🚀 Features

### ➕ Add a Character
Create a new character with:
- Name
- Game
- Role

---

### 📄 View Characters
Retrieve all characters stored in the database.

---

### 🔍 Get by ID
Fetch a specific character using its unique ID.

---

### ✏️ Update Character
Modify existing character details.

---

### 🗑️ Delete Character
Remove a character permanently.

---

## 🛠️ Tech Stack

### Backend
- **.NET 10 (Preview)**  
- **ASP.NET Core Web API**

### Database
- **PostgreSQL (Render Hosted)**  
- **Entity Framework Core (Npgsql Provider)**  

### DevOps & Deployment
- **Docker** → Containerization  
- **Render** → Cloud hosting  

### API Documentation
- **Swagger (Swashbuckle)** → `/swagger`

---

## 📦 Project Structure
- Controllers → Handles HTTP requests
- Services → Business logic
- Models → Database entities
- Dtos → Request/response shaping
- Data → DbContext (database connection)
- Migrations → Database schema history


---

## ⚙️ Environment Configuration

### 🔐 Production (Render)

Environment variable used:
```ConnectionStrings__DefaultConnection=Host=localhost;Port=5432;Database=YourDb;Username=YourUser;Password=YourPassword```


---

### 🖥️ Local Development

Use: appsettings.Development.json

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=VideoGameCharactersDb;Username=postgres;Password=yourpassword"
  }
}
```

## 🐳 Running with Docker (Optional)

### Build
```bash
docker build -t game-api .
```

Run 
```bash
docker run -p 8080:8080 game-api
```

# Project Setup & Documentation

## 🚀 Running the Project Locally

1. **Install Requirements**
    * **.NET 10 SDK**
    * **PostgreSQL** (Local or Docker)

2. **Setup Database**
    * Update the connection string in: `appsettings.Development.json`

3. **Apply Migrations**
    ```bash
    dotnet ef database update
    ```

4. **Run the API**
    ```bash
    dotnet run
    ```

---

## 🌐 API Documentation

Once running, you can access the API documentation here:

* **Swagger UI (Local):** [http://localhost:8080/swagger](http://localhost:8080/swagger)
* **Production:** [https://video-game-character-api-1.onrender.com/swagger/index.html](https://video-game-character-api-1.onrender.com/swagger/index.html)

---

## ☁️ Deployment (Render)

This project is deployed using:

* **Docker-based Web Service**
* **Managed PostgreSQL database**
* **Environment variables** for configuration

---

## 🔄 Database Migrations

Migrations are handled via EF Core:

* **Management:** Created using EF Core CLI.
* **Execution:** Automatically applied on app startup:
    ```csharp
    db.Database.Migrate();
    ```

---

## 🔐 Security Best Practices

* **Zero Secrets in Code:** No sensitive data is stored in the source code.
* **Environment Variables:** Used for all production configurations.
* **Git Hygiene:** `appsettings.Development.json` is excluded from Git to prevent accidental credential leaks.
