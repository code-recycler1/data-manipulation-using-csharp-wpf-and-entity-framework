# Entity Framework Navigation Properties Example

This repository contains an example of using Entity Framework with navigation properties in a WPF application targeting .NET Framework 4.8. The example demonstrates how to retrieve and display data from a database, including related entities, using navigation properties.

## Projects

- **EFNavigationPropertiesExample_WPF**: A WPF application that provides a user interface to display customer orders and related details.
- **EFNavigationPropertiesExample_DAL**: A Data Access Layer (DAL) project that contains the Entity Framework context and database operations.

## Features

- Display all orders, including the associated customer and handling employee.
- Display all customers and their orders.
- Display all customers, their orders, and the order lines (products and quantities).
- Display all customers, their orders, order lines, and product names.
- Display all customers, their orders, order lines, product names, and the employee handling the order.
