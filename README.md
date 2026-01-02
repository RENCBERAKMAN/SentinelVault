## SentinelVault 🛡️💰

**SentinelVault** is a bank-grade secure financial wallet API simulation built with a focus on data integrity, high performance, and security. This project demonstrates how to manage complex financial processes using a sustainable and robust architecture based on **Clean Architecture** principles.

## 🏗️ Architectural Overview (Clean Architecture)
The project is structured into 4 main layers to minimize dependencies and protect the core business logic:
* **Core (Domain & Application):** The heart and brain of the system. Contains pure business rules independent of any external technologies or frameworks.
* **Infrastructure (Persistence):** Manages database operations, external service integrations, and data storage.
* **Presentation (Web API):** The entry point for the outside world, built using RESTful standards.

<hr style="border: 50px solid #4CAF50; margin: 20px 0;">

## 🛠️ Technology Stack
* **.NET 8 (LTS):** Modern, high-performance runtime.
* **C# 12:** Latest language features for clean and efficient code.
* **Entity Framework Core:** Advanced Object-Relational Mapping (ORM) for database management.
* **JWT & Argon2:** Industry-standard authentication and high-level encryption.

<hr style="border: 50px solid #4CAF50; margin: 20px 0;">

## 🛡️ Why SentinelVault?
This project goes beyond simple CRUD operations by focusing on:
* **Data Consistency (ACID):** Ensures zero data loss during critical operations like fund transfers.
* **Security:** Encrypts sensitive data and includes defense mechanisms against common threats like Brute-force and DDoS.
* **Traceability (Audit Logging):** Maintains a "who, when, what" record for every critical action within the system.

<hr style="border: 50px solid #4CAF50; margin: 20px 0;">

## 🚀 Roadmap & Current Status
- [x] Initial project structure and layer setup.
- [x] Design of Domain models (Account Entity completed).
- [ ] Development of Business Logic and Service layers (In progress).
- [ ] Database integration and Migrations.
- [ ] Implementation of Secure Transfer logic.

---
*Developed with a focus on Backend Engineering and Cyber Security.*