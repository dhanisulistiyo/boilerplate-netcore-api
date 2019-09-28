# boilerplate-netcore-api

.Net Core Api

# Predictive Corrective Action Request

This Project Predictive Corrective Action Request

## Prerequirements

- [Visual Studio 2017 / Visual Studio code](https://code.visualstudio.com/download)
- [The .NET Core 2.2 SDK](https://www.microsoft.com/net/core)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2017)

## How To Run

- Clone this project
- Move to

  ```Console
  cd boilerplate-netcore-api

  ```

- Restore dependencies:

  ```Console
  dotnet restore

  ```

- Create Migration:

  ```Console
  dotnet ef migrations add InitialCreate

  ```

- Apply Migration:

  ```Console
  dotnet ef database update

  ```

- For Unit test:

  ```Console
  # Copy .appsetting.json to <ProjectName>\bin\Debug\netcoreapp2.2
  dotnet test

  ```

- For Run server:

  ```Console
  dotnet run
  or
  dotnet run --urls="http://*:{port}"
  ```
