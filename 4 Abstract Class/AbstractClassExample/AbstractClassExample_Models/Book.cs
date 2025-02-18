namespace AbstractClassExample_Models
{
    /// <summary>
    /// Represents a book product that extends the base <see cref="Product"/> class.
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class with the specified details.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The description of the book.</param>
        /// <param name="price">The price of the book.</param>
        /// <param name="author">The author of the book.</param>
        public Book(string code, string description, double price, string author) :
            base(code, description, price)
        {
            this.Author = author;
        }

        /// <summary>
        /// Returns a string representation of the book, including its author.
        /// </summary>
        /// <returns>A string containing product details and the author's name.</returns>
        public override string ToString()
        {
            return base.ToString() + " (" + this.Author + ")";
        }

        /// <summary>
        /// Validates the specified property of the book.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>A validation error message if invalid; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "Author" && string.IsNullOrWhiteSpace(Author))
            {
                return "Author is a required field!";
            }

            return base.Validate(propertyName);
        }
    }
}
