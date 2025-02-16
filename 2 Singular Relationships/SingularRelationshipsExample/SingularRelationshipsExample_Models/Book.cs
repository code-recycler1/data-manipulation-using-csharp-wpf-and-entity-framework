namespace SingularRelationshipsExample_Models
{
    /// <summary>
    /// Represents a book, which extends the <see cref="Product"/> class.
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
        /// <param name="code">The book code.</param>
        /// <param name="description">The book description.</param>
        /// <param name="price">The book price.</param>
        /// <param name="author">The book author.</param>
        public Book(string code, string description, double price, string author)
            : base(code, description, price)
        {
            this.Author = author;
        }

        /// <summary>
        /// Returns a formatted string representing the book.
        /// </summary>
        /// <returns>A formatted string containing the product details and author name.</returns>
        public override string ToString()
        {
            return base.ToString() + " (" + this.Author + ")";
        }
    }
}
