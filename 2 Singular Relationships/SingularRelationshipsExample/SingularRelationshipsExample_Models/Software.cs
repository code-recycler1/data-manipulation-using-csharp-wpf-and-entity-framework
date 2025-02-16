namespace SingularRelationshipsExample_Models
{
    /// <summary>
    /// Represents a software product, which extends the <see cref="Product"/> class.
    /// </summary>
    public class Software : Product
    {
        /// <summary>
        /// Gets or sets the software version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Software"/> class.
        /// </summary>
        /// <param name="code">The software code.</param>
        /// <param name="description">The software description.</param>
        /// <param name="price">The software price.</param>
        /// <param name="version">The software version.</param>
        public Software(string code, string description, double price, string version)
            : base(code, description, price)
        {
            this.Version = version;
        }

        /// <summary>
        /// Returns a formatted string representing the software.
        /// </summary>
        /// <returns>A formatted string containing the product details and software version.</returns>
        public override string ToString()
        {
            return base.ToString() + " Version: " + this.Version;
        }
    }
}
