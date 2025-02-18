using System.Windows.Media;
using System.Windows.Shapes;

namespace InterfacesExample_Models
{
    /// <summary>
    /// Represents a rectangular shape with position, height, and width properties.
    /// </summary>
    public class RectangleShape : IShape
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the rectangle's position.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the rectangle's position.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the height of the rectangle.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the rectangle.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleShape"/> class.
        /// </summary>
        /// <param name="x">The X-coordinate of the rectangle's position.</param>
        /// <param name="y">The Y-coordinate of the rectangle's position.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        public RectangleShape(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area of the rectangle as a <see cref="double"/>.</returns>
        public double CalculateArea()
        {
            return Width * Height;
        }

        /// <summary>
        /// Draws the rectangle as a WPF <see cref="Rectangle"/> shape.
        /// </summary>
        /// <returns>A <see cref="Rectangle"/> representing the rectangle.</returns>
        public Shape Draw()
        {
            Rectangle blueRectangle = new Rectangle
            {
                Height = Height,
                Width = Width,
                StrokeThickness = 4,
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.Blue)
            };

            return blueRectangle;
        }
    }
}
