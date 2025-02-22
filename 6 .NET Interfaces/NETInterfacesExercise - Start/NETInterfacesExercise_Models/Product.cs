using System.Collections.Generic;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents an abstract product with common properties and functionality.
    /// </summary>
    public abstract class Product
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
        /// Initializes a new instance of the <see cref="Product"/> class with the specified parameters.
        /// </summary>
        /// <param name="code">The product code.</param>
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
        /// Returns a compact string representation of the product.
        /// </summary>
        /// <returns>A semicolon-separated string containing product type, code, description, and price.</returns>
        public virtual string ToCompactString()
        {
            return $"{this.GetType().Name};{this.Code};{this.Description};{this.Price}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current product.
        /// </summary>
        /// <param name="obj">The object to compare with the current product.</param>
        /// <returns><c>true</c> if the products are equal based on the product code; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Product product && Code == product.Code;
        }

        /// <summary>
        /// Returns a hash code for the product.
        /// </summary>
        /// <returns>A hash code based on the product code.</returns>
        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }
    }
}
