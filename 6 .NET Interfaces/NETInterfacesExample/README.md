# .NET Interfaces Example

This solution demonstrates the use of interfaces in a .NET Framework 4.8 WPF application. The project is divided into three main parts: the WPF application, the data access layer (DAL), and the models.

## Projects

1. **NETInterfacesExample_WPF**: This is the main WPF application that provides the user interface for interacting with the product data.
2. **NETInterfacesExample_DAL**: This project contains the data access layer, responsible for reading and writing product data to and from files.
3. **NETInterfacesExample_Models**: This project contains the model classes that represent the data structures used in the application.

## Classes

### NETInterfacesExample_WPF

- **MainWindow.xaml.cs**: Handles UI interactions, including loading products, adding new ones, and handling different product types (Book and Software).
- **IndexerWindow.xaml.cs**: Demonstrates the use of indexers in C# through two different examples.

### NETInterfacesExample_DAL

- **FileOperations.cs**: Provides file operations for reading and writing product data. It includes methods for reading product data from a file, adding a product to the file, and logging errors.

### NETInterfacesExample_Models

- **Product.cs**: An abstract base class representing a generic product.
- **Book.cs**: Represents a book product with an author.
- **Software.cs**: Represents a software product with a version.

## Windows

### MainWindow

The main window of the application allows users to:
- Load a list of products from a file.
- Add new products (either Book or Software) to the list.
- Exit the application.

### IndexerWindow

This window demonstrates the use of indexers in C# through two different examples:
- **IndexerExample1**: Accessing an array using an indexer.
- **IndexerExample2**: Accessing properties using a string-based indexer.

## Usage

1. **Loading Products**: When the application starts, it loads the product list from `products.txt` and sets the default product type to "Book".
2. **Adding Products**: Users can add new products by entering the product details and clicking the "Add" button. The product is then validated and added to the list.
3. **Indexer Example**: Users can open the IndexerWindow to see examples of how indexers can be used in C#.

## File Operations

The `FileOperations` class provides methods to:
- Read product data from a file and return a list of products.
- Add a product to the file.
- Log errors to a text file.

## Error Handling

Errors encountered during file operations are logged to `error_log.txt` with a timestamp, error type, message, and stack trace for debugging purposes.

## Conclusion

This solution provides a comprehensive example of using interfaces, file operations, and indexers in a .NET Framework 4.8 WPF application. It demonstrates best practices for organizing code into separate projects for the UI, data access, and models.
