namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Represents a book, which is a type of product.
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// Gets or sets the book's author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="code">The book's code.</param>
        /// <param name="description">The book's description.</param>
        /// <param name="price">The book's price.</param>
        /// <param name="author">The book's author.</param>
        public Book(string code, string description, double price, string author) :
            base(code, description, price)
        {
            this.Author = author;
        }

        /// <summary>
        /// Returns a string representation of the book including the author.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} ({this.Author})";
        }

        /// <summary>
        /// Validates book properties based on column name.
        /// </summary>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Author" && string.IsNullOrWhiteSpace(Author))
                {
                    return "Author is a required field!";
                }

                return base[columnName];
            }
        }
    }
}
