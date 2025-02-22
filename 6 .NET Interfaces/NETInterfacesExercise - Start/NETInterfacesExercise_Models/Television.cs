namespace NETInterfacesExercise_Models
{
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
        }
    }

}
