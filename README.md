# Prompt-Powered Kickstart: Getting Started with ASP.NET Web API

## Project Overview

This project demonstrates how to build a simple ASP.NET Web API using Generative AI as a learning tool.

### Objective

* Build a simple API
* Return a welcome message
* Return the current server time
* Document the process clearly

## About ASP.NET Web API

ASP.NET Web API is a Microsoft framework for building HTTP-based services.

### Where it's used:

* Backend systems
* Mobile apps
* Web applications

### Real-world use:

Used in school systems, banking APIs, and e-commerce platforms.

## System Requirements

* .NET SDK (v6 or later)
* VS Code or Visual Studio
* Web browser

## Setup Instructions

### 1. Create Project

```bash
dotnet new webapi -n HelloApi
cd HelloApi
```

---

### 2. Enable Controllers

```csharp
builder.Services.AddControllers();
app.MapControllers();
```

---

### 3. Create Controller

```csharp
[HttpGet]
public IActionResult GetMessage()
{
    return Ok("Hello, welcome to ASP.NET Web API!");
}

[HttpGet("time")]
public IActionResult GetTime()
{
    return Ok(DateTime.Now);
}
```

---

### 4. Run the App

```bash
dotnet run
```
## Project Screenshots

### Running Project

![Project Running](screenshots/terminal.png)

---

### Swagger UI

![Swagger UI](screenshots/swagger.png)

---

### Hello Endpoint

![Hello Endpoint](screenshots/hello.png)

---

### Time Endpoint

![Time Endpoint](screenshots/time.png)

---

### Controller Code

![Controller Code](screenshots/code.png)

---

## API Endpoints

* `GET /api/hello`
* `GET /api/hello/time`

---

## AI Prompt Journal

### Prompt 1

"Give me a step-by-step guide to create a simple ASP.NET Web API"
✔ Helped set up project quickly

### Prompt 2

"Create a simple ASP.NET controller with a Hello World endpoint"
✔ Generated working code

### Prompt 3

"Why is my Swagger only showing weatherforecast?"
✔ Helped debug and understand API structure

---

## Common Issues

### Swagger only shows WeatherForecast

✔ Fix:

```csharp
builder.Services.AddControllers();
app.MapControllers();
```
### Endpoint not found

✔ Fix:

```csharp
[Route("api/[controller]")]
```

## References

* https://learn.microsoft.com/en-us/aspnet/core/web-api/
* https://dotnet.microsoft.com/

## Conclusion

This project shows how AI can:

* Speed up learning
* Help debug issues
* Improve productivity

Built with ASP.NET + AI-assisted learning
