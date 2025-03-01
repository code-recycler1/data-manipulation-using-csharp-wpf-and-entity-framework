# Entity Framework CUD Example

## Overview

This solution demonstrates basic Create, Update, and Delete (CUD) operations using Entity Framework in a WPF application. The solution is divided into three main projects:

1. **EF-CUD-Example_WPF**: The WPF application that provides the user interface.
2. **EF-CUD-Example_Models**: Contains the data models and base classes.
3. **EF-CUD-Example_DAL**: Data Access Layer (DAL) that handles database operations.

## Projects

### EF-CUD-Example_WPF

This project is the main WPF application. It includes the following:

- **MainWindow.xaml**: The main window of the application.
- **App.xaml**: Application configuration.
- **MainWindow.xaml.cs**: Handles UI interactions for managing order lines, including searching, adding, updating, and deleting order lines.

### EF-CUD-Example_Models

This project contains the data models and base classes used across the solution. Key components include:

- **BaseClass.cs**: An abstract base class implementing `IDataErrorInfo` for data validation.

### EF-CUD-Example_DAL

This project is responsible for data access and includes:

- **DatabaseOperations.cs**: Contains methods for performing CUD operations on the database.
- **FileOperations.cs**: Provides file-related operations, such as logging errors to a file.
