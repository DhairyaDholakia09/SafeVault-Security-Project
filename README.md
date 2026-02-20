🔐 SafeVault – Secure Authentication & Authorization System

SafeVault is a secure ASP.NET Core MVC web application developed to demonstrate secure coding practices, authentication, and role-based authorization using Microsoft Copilot.

The application implements modern security techniques to protect against common web vulnerabilities such as SQL Injection and Cross-Site Scripting (XSS). It uses ASP.NET Core Identity for secure user authentication and password hashing, ensuring industry-standard protection mechanisms.

🔑 Key Features

User Registration & Login using ASP.NET Identity

Role-Based Access Control (Admin/User)

SQL Injection Prevention using Entity Framework Core

XSS Protection through automatic output encoding

Secure password hashing and validation

Database integration using SQL Server (LocalDB)

Security testing and debugging

🛡 Security Measures Implemented

Parameterized queries via Entity Framework Core

Input validation using Data Annotations

Authentication & Authorization using ASP.NET Identity

Restricted access using [Authorize] attributes

Removal of insecure dynamic SQL queries

🧪 Security Testing

The application was tested against:

SQL Injection attempts (e.g., ' OR 1=1 --)

XSS attacks using script injection

Unauthorized access to protected routes

All identified vulnerabilities were resolved successfully.
