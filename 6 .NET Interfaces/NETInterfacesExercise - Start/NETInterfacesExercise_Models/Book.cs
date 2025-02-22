﻿namespace NETInterfacesExercise_Models
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
        /// Returns a compact string representation of the book.
        /// </summary>
        /// <returns>A semicolon-separated string containing product details and the author.</returns>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + this.Author;
        }
    }

}
