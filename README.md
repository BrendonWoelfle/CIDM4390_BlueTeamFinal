# CIDM4390_BlueTeamFinal

dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore

dotnet aspnet-codegenerator razorpage -m Instructor -dc WebApp1.Data.ApbetProjectContext -udl -outDir Pages/Instructors --referenceScriptLibraries -sqlite