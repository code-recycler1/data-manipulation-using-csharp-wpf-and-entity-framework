namespace MultipleRelationshipsExample_Models
{
    /// <summary>
    /// Represents a book, which is a specialized type of <see cref="Product"/>.
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The book description.</param>
        /// <param name="price">The price of the book.</param>
        /// <param name="author">The author of the book.</param>
        public Book(string code, string description, double price, string author)
            : base(code, description, price)
        {
            this.Author = author;
        }

        /// <summary>
        /// Returns a formatted string representation of the book,
        /// including its base product details and the author's name.
        /// </summary>
        /// <returns>A string containing the product details and author name.</returns>
        public override string ToString()
        {
            return base.ToString() + " (" + this.Author + ")";
        }
    }
}
