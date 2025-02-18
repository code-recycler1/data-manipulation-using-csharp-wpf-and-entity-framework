# Interfaces Example

## Overview

This solution demonstrates the use of interfaces in a WPF application. It includes two main projects:

1. **InterfacesExample_WPF**: A WPF application that draws shapes on a canvas and displays their areas.
2. **InterfacesExample_Models**: A class library containing the shape models and their implementations.

## Projects

### InterfacesExample_WPF

This project is a WPF application that provides the user interface for drawing shapes and displaying their areas. It includes the following key files:

- **MainWindow.xaml**: Defines the layout of the main window.
- **MainWindow.xaml.cs**: Contains the logic for drawing shapes and displaying their areas.
- **App.xaml**: Defines the application resources.
- **App.xaml.cs**: Contains the application startup logic.

### InterfacesExample_Models

This project is a class library that contains the shape models and their implementations. It includes the following key files:

- **RectangleShape.cs**: Defines a rectangle shape and its properties.
- **Circle.cs**: Defines a circle shape and its properties.
- **IShape.cs**: An interface that defines the common properties and methods for shapes.

## Classes

### MainWindow

Located in `InterfacesExample_WPF/MainWindow.xaml.cs`, this class handles the main window's logic, including:

- Initializing the window.
- Handling the `Window.Loaded` event to draw shapes and display their areas.

### RectangleShape

Located in `InterfacesExample_Models/RectangleShape.cs`, this class represents a rectangle shape and includes:

- Properties for the rectangle's dimensions and position.
- A method to calculate the area of the rectangle.
- A method to draw the rectangle on a canvas.

### Circle

Located in `InterfacesExample_Models/Circle.cs`, this class represents a circle shape and includes:

- Properties for the circle's radius and position.
- A method to calculate the area of the circle.
- A method to draw the circle on a canvas.

### IShape

Located in `InterfacesExample_Models/IShape.cs`, this interface defines the common properties and methods for shapes, including:

- A method to calculate the area of the shape.
- A method to draw the shape on a canvas.
