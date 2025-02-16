# Multiple Relationships Example

## Overview

This solution demonstrates a WPF application that manages different types of products, including books and software. The application allows users to add new products, view existing products, and save product information to a file.

## Projects

### MultipleRelationshipsExample_WPF
This project contains the WPF application that provides the user interface for managing products.

- **App.xaml.cs**: The entry point of the WPF application.
- **ProductWindow.xaml.cs**: The main window where users can add and view products.

### MultipleRelationshipsExample_Models
This project contains the model classes that represent the different types of products.

- **Product.cs**: The base class for all products.
- **Book.cs**: Represents a book product, which includes an author.
- **Software.cs**: Represents a software product, which includes a version.

### MultipleRelationshipsExample_DAL
This project contains the data access layer for reading and writing product information to a file.

- **FileOperations.cs**: Provides methods to read products from a file and add new products to a file.

## Classes

### Product
Represents a generic product with the following properties:
- `Code`: The unique product code.
- `Description`: The product description.
- `Price`: The price of the product.

### Book
Inherits from `Product` and adds the following property:
- `Author`: The author of the book.

### Software
Inherits from `Product` and adds the following property:
- `Version`: The version of the software.

## Usage

1. **Run the WPF Application**: Start the `MultipleRelationshipsExample_WPF` project to open the product management window.
2. **Add Products**: Use the interface to add new products by selecting the product type (Book, Software, or Generic Product) and entering the required information.
3. **View Products**: The list of products is displayed in the window, and it is loaded from the `products.txt` file located in the `doc` directory.
4. **Save Products**: New products are saved to the `products.txt` file.

## File Structure

- **doc/products.txt**: The file where product information is stored. Each product is saved in a specific format based on its type.

## Example

Here is an example of how products are saved in the `products.txt` file:

```
Book;B001;The Great Gatsby;10.99;F. Scott Fitzgerald 
Software;S001;Visual Studio;499.99;2022 
Product;P001;Generic Product;19.99;
```