using InterfacesExample_Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace InterfacesExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the <see cref="Window.Loaded"/> event.
        /// Draws a rectangle and a circle on the canvas and displays their areas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the <see cref="RoutedEventArgs"/>.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create a rectangle shape with specified dimensions
            RectangleShape rectangleShape = new RectangleShape(100, 50, 50, 100);

            // Create a circle shape with specified position and radius
            Circle circle = new Circle(100, 200, 50);

            // Create and position a label displaying the rectangle's area
            Label lblRectangle = new Label
            {
                Content = "Rectangle Area: " + rectangleShape.CalculateArea().ToString()
            };
            Canvas.SetLeft(lblRectangle, rectangleShape.X + rectangleShape.Width);
            Canvas.SetTop(lblRectangle, rectangleShape.Y);
            LayoutRoot.Children.Add(lblRectangle);

            // Draw the rectangle and add it to the canvas
            Rectangle rectShape = (Rectangle)rectangleShape.Draw();
            Canvas.SetLeft(rectShape, rectangleShape.X);
            Canvas.SetTop(rectShape, rectangleShape.Y);
            LayoutRoot.Children.Add(rectShape);

            // Create and position a label displaying the circle's area
            Label lblCircle = new Label
            {
                Content = "Circle Area: " + circle.CalculateArea().ToString()
            };
            Canvas.SetLeft(lblCircle, circle.X + circle.Radius);
            Canvas.SetTop(lblCircle, circle.Y);
            LayoutRoot.Children.Add(lblCircle);

            // Draw the circle and add it to the canvas
            Ellipse ellipseShape = (Ellipse)circle.Draw();
            Canvas.SetLeft(ellipseShape, circle.X);
            Canvas.SetTop(ellipseShape, circle.Y);
            LayoutRoot.Children.Add(ellipseShape);
        }
    }
}
