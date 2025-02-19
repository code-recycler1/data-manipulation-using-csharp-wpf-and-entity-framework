namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Demonstrates the use of an indexer to access properties dynamically by name.
    /// </summary>
    public class IndexerExample2
    {
        /// <summary>
        /// Gets or sets the name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address property.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the property value based on its name.
        /// </summary>
        /// <param name="propertyName">The name of the property to access.</param>
        /// <returns>The value of the specified property.</returns>
        public string this[string propertyName]
        {
            get
            {
                switch (propertyName)
                {
                    case "Name": return Name;
                    case "Address": return Address;
                    default: return "";
                }
            }
            set
            {
                switch (propertyName)
                {
                    case "Name": Name = value; break;
                    case "Address": Address = value; break;
                }
            }
        }

        /// <summary>
        /// Returns a string representation of the object.
        /// </summary>
        /// <returns>A formatted string containing the name and address.</returns>
        public override string ToString()
        {
            return Name + " - " + Address;
        }
    }
}
