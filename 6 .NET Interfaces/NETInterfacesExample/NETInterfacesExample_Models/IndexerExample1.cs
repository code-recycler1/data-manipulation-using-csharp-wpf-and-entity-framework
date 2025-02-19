namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Demonstrates the use of an indexer to access and modify an array of names.
    /// </summary>
    public class IndexerExample1
    {
        /// <summary>
        /// Gets the array of names.
        /// </summary>
        public string[] Names { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerExample1"/> class with an empty array.
        /// </summary>
        public IndexerExample1()
        {
            Names = new string[] { "", "", "" };
        }

        /// <summary>
        /// Gets or sets the name at the specified index.
        /// </summary>
        /// <param name="index">The index of the name in the array.</param>
        /// <returns>The name at the given index.</returns>
        public string this[int index]
        {
            get
            {
                return Names[index];
            }
            set
            {
                Names[index] = value;
            }
        }
    }
}
