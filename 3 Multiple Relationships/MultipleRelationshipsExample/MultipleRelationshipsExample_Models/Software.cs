namespace MultipleRelationshipsExample_Models
{
    /// <summary>
    /// Represents a software product, which is a specialized type of <see cref="Product"/>.
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
        /// <param name="description">The software description.</param>
        /// <param name="price">The price of the software.</param>
        /// <param name="version">The version of the software.</param>
        public Software(string code, string description, double price, string version)
            : base(code, description, price)
        {
            this.Version = version;
        }

        /// <summary>
        /// Returns a formatted string representation of the software,
        /// including its base product details and version number.
        /// </summary>
        /// <returns>A string containing the product details and software version.</returns>
        public override string ToString()
        {
            return base.ToString() + " Version: " + this.Version;
        }
    }
}
