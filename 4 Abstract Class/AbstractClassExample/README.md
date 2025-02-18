# Abstract Class Example

## Overview
This solution demonstrates the use of abstract classes in a .NET Framework 4.8 WPF application. The solution consists of three projects:

1. **AbstractClassExample_WPF**: The WPF application that provides the user interface.
2. **AbstractClassExample_Models**: Contains the abstract class `Product` and its derived classes `Book` and `Software`.
3. **AbstractClassExample_DAL**: Handles data access operations, such as reading from and writing to files.

## Projects

### AbstractClassExample_WPF
This project is a WPF application that allows users to add and view products. The main window (`MainWindow.xaml.cs`) includes functionality to:
- Load products from a file when the window is loaded.
- Add new products (either `Book` or `Software`) to the file.
- Display different fields based on the selected product type.

### AbstractClassExample_Models
This project contains the following classes:
- **Product**: An abstract base class that defines common properties and methods for products.
- **Book**: A derived class that represents a book and includes an additional property for the author.
- **Software**: A derived class that represents software and includes an additional property for the version.

### AbstractClassExample_DAL
This project handles data access operations. It includes the `FileOperations` class, which provides methods to read from and write to a file.

## Classes

### Product (Abstract)

```csharp
public abstract class Product { 
public string Code { get; set; } 
public string Description { get; set; } 
public double Price { get; set; }
public abstract bool IsValid();
public abstract string ErrorMessages { get; }
}
```

### Book

```csharp
public class Book : Product { 
public string Author { get; set; }
public override bool IsValid()
{
    // Validation logic for Book
}

public override string ErrorMessages
{
    get
    {
        // Error messages for Book
    }
}
}
```

### Software

```csharp
public class Software : Product { 
public string Version { get; set; }
public override bool IsValid()
{
    // Validation logic for Software
}

public override string ErrorMessages
{
    get
    {
        // Error messages for Software
    }
}
}
```

### FileOperations

```csharp
public static class FileOperations { 
public static List<Product> ReadFile(string filePath) 
{
    // Logic to read products from file 
}
public static void AddProduct(string filePath, Product product)
{
    // Logic to add product to file
}
}
```