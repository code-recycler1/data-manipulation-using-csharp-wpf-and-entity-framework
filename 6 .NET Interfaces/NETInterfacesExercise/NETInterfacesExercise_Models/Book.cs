using System;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a book product with an associated author.
    /// Inherits from the <see cref="Product"/> class.
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
        /// <param name="code">The product code.</param>
        /// <param name="description">The description of the book.</param>
        /// <param name="price">The price of the book.</param>
        /// <param name="author">The author of the book.</param>
        public Book(string code, string description, double price, string author)
            : base(code, description, price)
        {
            this.Author = author;
        }

        /// <summary>
        /// Returns a string representation of the book, including its author.
        /// </summary>
        /// <returns>A string containing book details and the author's name.</returns>
        public override string ToString()
        {
            return base.ToString() + "Author:" + this.Author + Environment.NewLine;
        }

        /// <summary>
        /// Returns a compact string representation of the book.
        /// </summary>
        /// <returns>A semicolon-separated string containing product details and the author.</returns>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + this.Author;
        }

        /// <summary>
        /// Gets the validation error message for the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>
        /// An error message if the property value is invalid; otherwise, an empty string.
        /// </returns>
        public override string this[string propertyName]
        {
            get
            {
                if (propertyName == "Author" && string.IsNullOrWhiteSpace(Author))
                {
                    return "Author is a required field!";
                }
                return base[propertyName];
            }
        }
    }
}
