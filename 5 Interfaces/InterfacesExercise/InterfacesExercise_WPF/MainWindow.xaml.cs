using InterfacesExercise_Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace InterfacesExercise_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Visual representation of the rectangle.
        /// </summary>
        private Rectangle rectangleVisual;

        /// <summary>
        /// Visual representation of the circle.
        /// </summary>
        private Ellipse circleVisual;

        /// <summary>
        /// Rectangle shape model instance.
        /// </summary>
        private RectangleShape rectangleShape = new RectangleShape(50, 50, 50, 100);

        /// <summary>
        /// Circle shape model instance.
        /// </summary>
        private Circle circleShape = new Circle(100, 200, 50);

        /// <summary>
        /// Handles the window load event. Initializes and displays shapes and labels.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Display rectangle area
            Label lblRectangle = new Label
            {
                Content = "Rectangle area: " + rectangleShape.CalculateArea().ToString()
            };
            Canvas.SetLeft(lblRectangle, rectangleShape.X + rectangleShape.Width);
            Canvas.SetTop(lblRectangle, rectangleShape.Y);
            LayoutRoot.Children.Add(lblRectangle);

            // Draw and position rectangle
            rectangleVisual = (Rectangle)rectangleShape.Draw();
            Canvas.SetLeft(rectangleVisual, rectangleShape.X);
            Canvas.SetTop(rectangleVisual, rectangleShape.Y);
            LayoutRoot.Children.Add(rectangleVisual);

            // Display circle area
            Label lblCircle = new Label
            {
                Content = "Circle area: " + circleShape.CalculateArea().ToString()
            };
            Canvas.SetLeft(lblCircle, circleShape.X + circleShape.Radius);
            Canvas.SetTop(lblCircle, circleShape.Y);
            LayoutRoot.Children.Add(lblCircle);

            // Draw and position circle
            circleVisual = (Ellipse)circleShape.Draw();
            Canvas.SetLeft(circleVisual, circleShape.X);
            Canvas.SetTop(circleVisual, circleShape.Y);
            LayoutRoot.Children.Add(circleVisual);
        }

        /// <summary>
        /// Moves the rectangle left when the Left button is clicked.
        /// </summary>
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            rectangleShape.MoveLeft();
            Canvas.SetLeft(rectangleVisual, rectangleShape.X);
        }

        /// <summary>
        /// Moves the rectangle right when the Right button is clicked.
        /// </summary>
        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            rectangleShape.MoveRight();
            Canvas.SetLeft(rectangleVisual, rectangleShape.X);
        }

        /// <summary>
        /// Moves the rectangle up when the Up button is clicked.
        /// </summary>
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            rectangleShape.MoveUp();
            Canvas.SetTop(rectangleVisual, rectangleShape.Y);
        }

        /// <summary>
        /// Moves the rectangle down when the Down button is clicked.
        /// </summary>
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            rectangleShape.MoveDown();
            Canvas.SetTop(rectangleVisual, rectangleShape.Y);
        }
    }
}
