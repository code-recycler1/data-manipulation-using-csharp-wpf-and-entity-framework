using System;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a television with specific properties like refresh rate (Hz) and screen size.
    /// Inherits from ElectricalAppliance.
    /// </summary>
    public class Television : ElectricalAppliance
    {
        /// <summary>
        /// Gets or sets the refresh rate of the television in Hertz.
        /// </summary>
        public int RefreshRate { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the television in inches.
        /// </summary>
        public int ScreenSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Television"/> class.
        /// </summary>
        /// <param name="code">Unique product code.</param>
        /// <param name="description">Short description of the television.</param>
        /// <param name="price">Price of the television.</param>
        /// <param name="brand">Brand of the television.</param>
        /// <param name="model">Model name or type.</param>
        /// <param name="refreshRate">Screen refresh rate in Hertz (Hz).</param>
        /// <param name="screenSize">Screen size in inches.</param>
        public Television(string code, string description, double price,
                          string brand, string model, int refreshRate, int screenSize)
            : base(code, description, price, brand, model)
        {
            RefreshRate = refreshRate;
            ScreenSize = screenSize;
        }

        /// <summary>
        /// Returns a compact string representation of the television.
        /// </summary>
        /// <returns>A semicolon-separated string containing product details.</returns>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + RefreshRate + ";" + ScreenSize;
        }

        /// <summary>
        /// Returns a formatted string representation of the television, including its refresh rate and screen size.
        /// </summary>
        /// <returns>A string that includes the base product information, refresh rate, and screen size.</returns>
        public override string ToString()
        {
            string text = base.ToString();
            text += "Hertz: " + RefreshRate + Environment.NewLine;
            text += "Screen Size: " + ScreenSize + Environment.NewLine;
            return text;
        }

        /// <summary>
        /// Validates the specified property value for the television.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>
        /// An error message if the validation fails; otherwise, an empty string.
        /// </returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "RefreshRate" && RefreshRate < 0)
                {
                    return "RefreshRate must be greater than or equal to 0!";
                }
                else if (columnName == "ScreenSize" && ScreenSize < 0)
                {
                    return "Screen size must be greater than or equal to 0!";
                }
                return base[columnName];
            }
        }

    }
}