ASP.NET Web API – Custom Identity with JWT Authentication
This project is an ASP.NET Core Web API that implements custom identity authentication with JWT (JSON Web Token) for secure user authentication and authorization.

Features
✅ Custom Identity System (instead of default ASP.NET Identity)
✅ Secure JWT-based Authentication
✅ Role-based Authorization
✅ User Registration & Login APIs
✅ Secure Password Hashing

Technologies Used
ASP.NET Core Web API
Entity Framework Core (for user management)
JWT (JSON Web Token) for authentication
SQL Server (or any configured database)
Installation
1️⃣ Clone the Repository
bash
Copy
Edit
git clone https://github.com/Andu2023/IdentityApp.git
cd IdentityApp
2️⃣ Configure Database
Update the connection string in appsettings.json:

j
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;"
}
Apply EF Core Migrations (if using Entity Framework):


dotnet ef database update
3️⃣ Run the Application

dotnet run
