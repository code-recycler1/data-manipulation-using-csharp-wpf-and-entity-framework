using System.Collections.Generic;
using System.Text;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents an abstract product with common properties and validation functionality.
    /// Inherits from <see cref="BaseClass"/> for validation support.
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
        /// Gets or sets the product price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class with the specified code, description, and price.
        /// </summary>
        /// <param name="code">The unique product code.</param>
        /// <param name="description">The product description.</param>
        /// <param name="price">The product price.</param>
        protected Product(string code, string description, double price)
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
        /// Returns a string representation of the product including its type, description, and price.
        /// </summary>
        /// <returns>A formatted string describing the product.</returns>
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"{this.GetType().Name} : {this.Description} (price: {this.Price})");
            return message.ToString();
        }

        /// <summary>
        /// Returns a compact, semicolon-separated string representation of the product.
        /// </summary>
        /// <returns>A compact string containing the product type, code, description, and price.</returns>
        public virtual string ToCompactString()
        {
            return $"{this.GetType().Name};{this.Code};{this.Description};{this.Price}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current product based on the product code.
        /// </summary>
        /// <param name="obj">The object to compare with the current product.</param>
        /// <returns><c>true</c> if the product codes are equal; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Code == product.Code;
        }

        /// <summary>
        /// Returns a hash code for the current product.
        /// </summary>
        /// <returns>A hash code based on the product code.</returns>
        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }

        /// <summary>
        /// Validates the specified property value and returns an error message if invalid.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>An error message if the property is invalid; otherwise, an empty string.</returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Code" && string.IsNullOrWhiteSpace(Code))
                {
                    return "Code is a required field!";
                }
                else if (columnName == "Description" && string.IsNullOrWhiteSpace(Description))
                {
                    return "Description is a required field!";
                }
                else if (columnName == "Price" && Price < 0)
                {
                    return "Price must be greater than or equal to 0!";
                }

                return "";
            }
        }
    }
}
