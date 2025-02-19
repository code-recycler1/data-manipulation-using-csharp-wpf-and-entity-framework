namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Represents a software product with a version.
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
        /// <param name="code">The software's code.</param>
        /// <param name="description">The software's description.</param>
        /// <param name="price">The software's price.</param>
        /// <param name="version">The software version.</param>
        public Software(string code, string description, double price, string version) :
            base(code, description, price)
        {
            this.Version = version;
        }

        /// <summary>
        /// Returns a string representation of the software including the version.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Version: {this.Version}";
        }

        /// <summary>
        /// Validates software properties based on column name.
        /// </summary>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Version" && string.IsNullOrWhiteSpace(Version))
                {
                    return "Version is a required field!";
                }

                return base[columnName];
            }
        }
    }
}
