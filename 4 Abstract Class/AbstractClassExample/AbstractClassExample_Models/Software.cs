namespace AbstractClassExample_Models
{
    /// <summary>
    /// Represents a software product, inheriting from the <see cref="Product"/> class.
    /// </summary>
    public class Software : Product
    {
        /// <summary>
        /// Gets or sets the version of the software.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Software"/> class.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The description of the software.</param>
        /// <param name="price">The price of the software.</param>
        /// <param name="version">The version number of the software.</param>
        public Software(string code, string description, double price, string version) :
            base(code, description, price)
        {
            this.Version = version;
        }

        /// <summary>
        /// Returns a string representation of the software, including version details.
        /// </summary>
        /// <returns>A formatted string containing product details and version.</returns>
        public override string ToString()
        {
            return base.ToString() + " Version: " + this.Version;
        }

        /// <summary>
        /// Validates the specified property of the software.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails, otherwise an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "Version" && string.IsNullOrWhiteSpace(Version))
            {
                return "Version is a required field!";
            }

            return base.Validate(propertyName);
        }
    }
}
