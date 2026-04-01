# 🎮 Video Game Character API

A simple and clean backend project to manage video game characters — built to demonstrate how modern APIs are structured and organized.

This project focuses on **clarity, scalability, and clean design**, making it easy to understand for both technical and non-technical audiences.

---

## 🌟 What is this project about?

Imagine you are building a game or an app where you want to:

- Add new characters 🎯  
- View all characters 📋  
- Update their roles ⚔️  
- Remove characters ❌  

This API acts as the **engine behind that system**, handling all those operations smoothly.

---

## ✨ Key Highlights

- Easy-to-understand API structure  
- Clean separation of logic (well-organized code)  
- Supports all basic operations (Create, Read, Update, Delete)  
- Designed in a way that can grow into a real-world product  
- Includes interactive API testing interface  

---

## 🧩 How the system works (Simple View)
User Request → API → Logic Layer → Database → Response Back

- You send a request (like “add a character”)  
- The system processes it  
- Stores or retrieves data  
- Sends back a response  

---

## 🚀 What can you do with it?

### ➕ Add a Character
You can create a new character with details like name, game, and role.

---

### 📄 View Characters
Get a list of all characters stored in the system.

---

### 🔍 Find by ID
Search for a specific character using its unique ID.

---

### ✏️ Update Character
Modify existing character details.

---

### 🗑️ Delete Character
Remove a character from the system.

---

## 🛠️ Tech Stack (Light Overview)

This project uses modern backend tools:

- **.NET 10** → Core framework to build APIs  
- **ASP.NET Core** → Handles web requests  
- **Entity Framework Core** → Talks to the database  
- **SQL Server Express** → Stores the data  
- **OpenAPI (Scalar UI)** → Helps test APIs easily  

---

## 📦 Project Structure (Simplified)
- Controllers → Handles incoming requests
- Services → Contains logic
- Models → Data structure
- DTOs → Clean input/output format
- Data → Database connection


---

## ⚙️ How to run the project

### 1. Install Requirements

- .NET 10 SDK  
- SQL Server Express  

---

### 2. Setup Database

Update the connection string in:
`appsetting.json`


---

### 3. Run the Project

```bash
dotnet run
