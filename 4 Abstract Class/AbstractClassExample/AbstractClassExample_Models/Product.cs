using System.Collections.Generic;
using System.Text;

namespace AbstractClassExample_Models
{
    /// <summary>
    /// Represents an abstract product with common properties and validation logic.
    /// </summary>
    public abstract class Product : BaseClass
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
        /// Gets or sets the price of the product.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class with specified details.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The description of the product.</param>
        /// <param name="price">The price of the product.</param>
        public Product(string code, string description, double price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class with default values.
        /// </summary>
        public Product() : this("", "", 0) { }

        /// <summary>
        /// Returns a formatted string representation of the product.
        /// </summary>
        /// <returns>A string containing the product's code, price, and description.</returns>
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append(this.Code.PadRight(15)
                + Conversions.ConvertNumericToCurrency(Price).PadLeft(10)
                + string.Empty.PadLeft(5) + this.Description);
            return message.ToString();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current product.
        /// </summary>
        /// <param name="obj">The object to compare with the current product.</param>
        /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Product product && Code == product.Code;
        }

        /// <summary>
        /// Returns the hash code for this product.
        /// </summary>
        /// <returns>The hash code of the product based on its code.</returns>
        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }

        /// <summary>
        /// Validates the specified property of the product.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>A validation error message if invalid; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "Code" && string.IsNullOrWhiteSpace(Code))
            {
                return "Code is a required field!";
            }
            else if (propertyName == "Description" && string.IsNullOrWhiteSpace(Description))
            {
                return "Description is a required field!";
            }
            else if (propertyName == "Price" && Price < 0)
            {
                return "Price must be greater than or equal to 0!";
            }

            return "";
        }
    }
}
