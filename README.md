# Blazor DataGrid MSSQL Connectivity Using API Service

## Overview

This sample demonstrates how to connect a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) to Microsoft SQL Server through a Web API service. The solution consists of two applications: a Blazor DataGrid client (`GridMSSql`) and an API service (`MyWebService`) that communicates with the database. The DataGrid retrieves data and performs CRUD operations through the API layer using the Syncfusion DataManager URL adaptor pattern, providing a practical reference for database-driven Blazor applications.

## Key Features

- Demonstrates data binding between Syncfusion Blazor DataGrid and Microsoft SQL Server through a Web API service.
- Uses a dedicated API project (`MyWebService`) to retrieve and update database records.
- Supports CRUD operations performed from the Syncfusion Blazor DataGrid.
- Uses the Syncfusion DataManager URL adaptor to communicate with server-side endpoints.
- Uses the `NORTHWND.MDF` sample database included in the solution.
- Requires database connection configuration through `GridController.cs`.
- Demonstrates a multi-project architecture separating UI, API, and database access responsibilities.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution files contained in the `MyWebService` and `GridMSSql` project folders. 
3. Restore all NuGet packages.
4. Open the **Server Explorer** in Visual Studio.
5. Attach the `NORTHWND.MDF` database located in the `App_Data` folder of the service project.
6. Update the database connection string in `GridController.cs`.
7. Build the solution.
8. Start the `MyWebService` project first.
9. Start the `GridMSSql` application.
10. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the API project directory and restore packages.

```bash
cd MyWebService
dotnet restore
dotnet run
```

4. Open a second terminal and navigate to the Blazor DataGrid project directory.

```bash
cd GridMSSql
dotnet restore
dotnet run
```

5. Ensure the API service is running before launching the Blazor application.
6. Open the local application URL displayed in the terminal after startup.

## Project Structure

- `GridMSSql/` — contains the Syncfusion Blazor DataGrid application that displays records and performs CRUD operations.
- `MyWebService/` — contains the API service responsible for database connectivity and data processing.
- `MyWebService/App_Data/` — contains the `NORTHWND.MDF` SQL Server database used by the sample.
- `MyWebService/GridController.cs` — contains the database connection string and API endpoints used by the Grid. 
- `GridMSSql/Pages/` — contains the Blazor pages that render the Syncfusion DataGrid and configure data binding.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to this feature, see https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/url-adaptor

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
