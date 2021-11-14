# Planets API & SPA

## Instructions
To run this application, you need the following:
- Visual Studio 2022 or later
- .NET 6 SDK
- Node Package Manager
- SQL Express (or alternative SQL database)

### Steps
1. Open the Planets.sln file in Visual Studio 2022
2. Change the connection string in appsettings.json in the Planets.API project to the connection string you want for your database (default is SQLEXPRESS with a database name of Planets)
3. Open Package Manager Console and run `update-database`, with `Planets.Migrations` set as the Default Project
4. Run the API project (ensure it is the Startup Project)
5. Navigate to the planets-spa folder in the source and open a PowerShell window in this folder
6. Run `npm install` to install the required dependencies for the SPA
7. Run `npm start` to start the SPA
8. Enjoy!