# AspNet-3Layers-Architecture
 Asp.Net 3Layers Architecture with a cascading dropdownlist


# Asp Net MVVM
This is a demo, to implements a web api in 3 layers with C# (dotnet) and Entity Framework using Repository pattern and SQL Server 2017 Database. 
I implement too in in the frontend a cascading DropdownList using jQuey/JavaScrip.


# Architecture (Layers)
.Service - Layer responsible for responsible for business rules.

.Data - Layer responsible for abstraction and data modeling and access to the database.

.Web - Layer responsable to interact with user and the manipulation of routes and requests.

# Run Migrations
cd HDBellData

dotnet ef database update

Run

# After preparing your database and your connection string ( HDBellData/HDBellContext.cs ), follow the steps:

dotnet restore

cd HDBellWeb

dotnet run

Application is listening on http://localhost:54434/  or its depend on your machine.



