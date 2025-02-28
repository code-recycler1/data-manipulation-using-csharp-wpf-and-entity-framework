# ADO.NET Entity Framework Example

This solution demonstrates the use of ADO.NET Entity Framework in a WPF application. The solution consists of two main projects:

1. **NETEntityFrameworkExample_WPF**: A WPF application that provides a user interface to interact with the database.
2. **NETEntityFrameworkExample_DAL**: A Data Access Layer (DAL) project that contains the Entity Framework context and operations for retrieving employee data from the database.

## Projects

### NETEntityFrameworkExample_WPF

This project is a WPF application that allows users to perform various operations related to employee data. The main features include:

- Displaying all employees.
- Searching employees by job title.
- Searching employees by full name (last name and first name).
- Searching an employee by their unique employee ID.

#### MainWindow.xaml

The main window of the application contains a `DataGrid` to display employee data and several input fields and buttons to perform the search operations.

#### MainWindow.xaml.cs

The code-behind file for the main window contains event handlers for the buttons. These event handlers call methods from the `DatabaseOperations` class to retrieve data from the database and display it in the `DataGrid`.

### NETEntityFrameworkExample_DAL

This project contains the Entity Framework context and data access methods. The main components include:

- **SalesManagementEntities**: The Entity Framework context class that represents the database.
- **DatabaseOperations**: A static class that provides methods for retrieving employee data from the database.

#### DatabaseOperations.cs

This file contains methods for retrieving employee data, including:

- `GetEmployees()`: Retrieves a list of all employees, ordered by last name and first name.
- `GetEmployeesByJobTitle(string jobTitle)`: Retrieves a list of employees filtered by a specific job title.
- `GetEmployeesByLastNameAndFirstName(string lastName, string firstName)`: Retrieves a list of employees filtered by last name and first name.
- `GetEmployeeByID(int employeeID)`: Retrieves a specific employee based on their unique employee ID.
