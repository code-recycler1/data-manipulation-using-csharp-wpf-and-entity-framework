using System;
using System.Windows.Media;
using System.Windows.Shapes;

namespace InterfacesExample_Models
{
    /// <summary>
    /// Represents a circle shape with position and radius properties.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the circle's center.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the circle's center.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="x">The X-coordinate of the circle's center.</param>
        /// <param name="y">The Y-coordinate of the circle's center.</param>
        /// <param name="radius">The radius of the circle.</param>
        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle as a <see cref="double"/>.</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Draws the circle as a WPF <see cref="Ellipse"/> shape.
        /// </summary>
        /// <returns>An <see cref="Ellipse"/> representing the circle.</returns>
        public Shape Draw()
        {
            Ellipse ellipse = new Ellipse
            {
                Height = Radius * 2,
                Width = Radius * 2,
                StrokeThickness = 4,
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.Red)
            };

            return ellipse;
        }
    }
}
