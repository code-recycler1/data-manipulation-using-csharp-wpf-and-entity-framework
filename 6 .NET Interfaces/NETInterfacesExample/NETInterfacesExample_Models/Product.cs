using System.Collections.Generic;
using System.Text;

namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Represents a product with a code, description, and price.
    /// </summary>
    public abstract class Product : BaseClass
    {
        /// <summary>
        /// Gets or sets the product code.
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
        /// Initializes a new instance of the <see cref="Product"/> class with specified values.
        /// </summary>
        /// <param name="code">The product code.</param>
        /// <param name="description">The product description.</param>
        /// <param name="price">The product price.</param>
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
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append(this.Code.PadRight(15)
                + Conversions.ConvertNumericToCurrency(Price).PadLeft(10)
                + string.Empty.PadLeft(5) + this.Description);
            return message.ToString();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current product based on the code.
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Code == product.Code;
        }

        /// <summary>
        /// Gets the hash code for the product.
        /// </summary>
        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }

        /// <summary>
        /// Validates product properties based on column name.
        /// </summary>
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
