﻿using System.Collections.Generic;
using System.Text;

namespace SingularRelationshipsExample_Models
{
    /// <summary>
    /// Represents a general product with a code, description, and price.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique product code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The product description.</param>
        /// <param name="price">The product price.</param>
        public Product(string code, string description, double price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        /// <summary>
        /// Returns a formatted string representing the product.
        /// </summary>
        /// <returns>A formatted string containing the product code, price, and description.</returns>
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append(this.Code.PadRight(15)
                + Conversions.ConvertNumericToCurrency(Price).PadLeft(10)
                + string.Empty.PadLeft(5)
                + this.Description);
            return message.ToString();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current product.
        /// Products are considered equal if they have the same code.
        /// </summary>
        /// <param name="obj">The object to compare with the current product.</param>
        /// <returns>True if the objects are equal, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Product product && Code == product.Code;
        }

        /// <summary>
        /// Returns a hash code for this product.
        /// </summary>
        /// <returns>A hash code based on the product code.</returns>
        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }
    }
}
