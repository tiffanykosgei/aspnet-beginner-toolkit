# 🚀 Prompt-Powered Kickstart: Getting Started with ASP.NET Web API

---

## 1. Title & Objective

**Technology Chosen:** ASP.NET Web API

**Why I chose it:**
I chose ASP.NET Web API because it is a powerful backend framework widely used to build RESTful services. It is also relevant to my current learning in backend development.

**Project Objective:**
To build a simple API that returns:

* A welcome message
* The current server time

**End Goal:**
A working API that can be tested using Swagger or a browser.

---

## 2. Quick Summary of the Technology

ASP.NET Web API is a framework developed by Microsoft for building HTTP-based services.

**Where it is used:**

* Backend systems
* Mobile applications
* Web applications

**Real-world example:**
Used in systems like school management platforms, banking APIs, and e-commerce backends.

---

## 3. System Requirements

* OS: Windows / Linux / Mac
* .NET SDK (v6 or later)
* Code Editor: VS Code or Visual Studio
* Web Browser (Chrome recommended)

---

## 4. Installation & Setup Instructions

### Step 1: Install .NET SDK

Download and install from:
https://dotnet.microsoft.com/

---

### Step 2: Create the Project

```bash
dotnet new webapi -n HelloApi
cd HelloApi
```

---

### Step 3: Modify Program.cs

Enable controllers by adding:

```csharp
builder.Services.AddControllers();
app.MapControllers();
```

---

### Step 4: Create Controller

Create `Controllers/HelloController.cs` and add:

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

### Step 5: Run the Project

```bash
dotnet run
```

---

### 📸 Screenshot: Project Running

![Project Running](screenshots/terminal.png)

---

## 5. Minimal Working Example

This project exposes two endpoints:

* `/api/hello`
* `/api/hello/time`

---

### 📸 Screenshot: Swagger UI

![Swagger UI](screenshots/swagger.png)

---

### 📸 Screenshot: Hello Endpoint Output

![Hello Endpoint](screenshots/hello.png)

---

### 📸 Screenshot: Time Endpoint Output

![Time Endpoint](screenshots/time.png)

---

### 📸 Screenshot: Controller Code

![Controller Code](screenshots/code.png)

---

## 6. AI Prompt Journal

### Prompt 1:

**"Give me a step-by-step guide to create a simple ASP.NET Web API"**

**AI Response Summary:**
The AI provided commands to initialize the project and run it.

**Evaluation:**
Very helpful in setting up the project quickly.

---

### Prompt 2:

**"Create a simple ASP.NET controller with a Hello World endpoint"**

**AI Response Summary:**
Generated controller code with GET endpoints.

**Evaluation:**
Saved time and reduced errors.

---

### Prompt 3:

**"Why is my Swagger only showing weatherforecast?"**

**AI Response Summary:**
Explained the difference between Minimal APIs and Controllers and how to fix it.

**Evaluation:**
Very useful in debugging and understanding ASP.NET structure.

---

## 7. Common Issues & Fixes

### Issue 1: Swagger only shows WeatherForecast

**Cause:** Using Minimal API template without controllers
**Fix:** Add:

```csharp
builder.Services.AddControllers();
app.MapControllers();
```

---

### Issue 2: Endpoint not found

**Fix:** Ensure correct route:

```csharp
[Route("api/[controller]")]
```

---

### Issue 3: App not running

**Fix:** Restart using:

```bash
dotnet run
```

---

## 8. References

* https://learn.microsoft.com/en-us/aspnet/core/web-api/
* https://dotnet.microsoft.com/
* StackOverflow

---

## 🎯 Conclusion

This project demonstrates how generative AI can be used to quickly learn and implement a new technology. Using AI assistance, I was able to:

* Set up an ASP.NET Web API
* Debug issues
* Build a working example
* Document the entire process clearly

---
