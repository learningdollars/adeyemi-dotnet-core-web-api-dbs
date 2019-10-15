

# Distributed database in dotnet core web api 3.0 Tutorial

This repository demonstrate how to connect web api to distributed database in dotnet core web api 3.0.

Install the following
[dotnet core 3.0 sdk](https://dotnet.microsoft.com/download/dotnet-core/3.0)

> My preferred editor is visual studio code

The project involves doing the following
- Store User entity in a Postgres database
- Store Book entity  in Microsoft Sql Server database (MSSQL)

### ENDPOINT DESCRIPTION

| verb |Endpoint  | description | body        
|--|--| -- | -- |
| POST | /api/user  | `adds a dummy user`   | {	"FirstName": "John","LastName" : "Doe"}
| GET| /api/user  | `gets all dummy user`   | None
| POST | /api/book| `adds a dummy book`   | {	"ISBN": 16657", Author": "Learning Dollars"}
| GET| /api/book  | `gets all dummy books`   |  None

### TO RUN THE APPLICATION DO THE FOLLOWING

- provision a database instance on MSSQL.
- provision a database instance on PostgresDB

- add the connnection strings to appsettings.json in the following format below.

>**note appsettings.json must be in the project root directory**

```{
   "ConnectionStrings": {
   "UserDBConnection"postgres connection string",
   "DefaultConnection": "mssql connection string"
    },
     "Logging": {
   "LogLevel": {
     "Default": "Information",
     "Microsoft": "Warning",
     "Microsoft.Hosting.Lifetime": "Information"
   }
 },
 }

```
### Run the following command below to update your dependencies
- dotnet restore

### Run the following command below to update your database schema
```
dotnet ef database update --context UserDbContext
dotnet ef database update --context BookDbContext

```
### Run the following to build and start the application

- dotnet run build
