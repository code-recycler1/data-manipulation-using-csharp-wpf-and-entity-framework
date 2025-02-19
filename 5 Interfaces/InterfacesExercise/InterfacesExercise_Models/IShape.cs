using System.Windows.Shapes;

namespace InterfacesExercise_Models
{
    /// <summary>
    /// Represents a geometric shape with basic properties and operations.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the shape.
        /// </summary>
        double X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the shape.
        /// </summary>
        double Y { get; set; }

        /// <summary>
        /// Draws the shape and returns a corresponding WPF <see cref="Shape"/> object.
        /// </summary>
        /// <returns>A <see cref="Shape"/> representing the drawn geometric figure.</returns>
        Shape Draw();

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>The calculated area of the shape as a <see cref="double"/>.</returns>
        double CalculateArea();
    }
}
