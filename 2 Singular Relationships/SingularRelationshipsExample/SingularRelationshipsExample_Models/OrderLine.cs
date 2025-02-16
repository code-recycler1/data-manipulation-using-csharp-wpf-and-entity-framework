using System.Collections.Generic;

namespace SingularRelationshipsExample_Models
{
    /// <summary>
    /// Represents a line item in an order, which consists of a product and its quantity.
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Gets or sets the product associated with this order line.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product ordered.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine"/> class.
        /// </summary>
        /// <param name="product">The product being ordered.</param>
        /// <param name="quantity">The quantity of the product ordered.</param>
        public OrderLine(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Calculates the subtotal cost for this order line.
        /// </summary>
        /// <returns>The subtotal cost, which is price * quantity.</returns>
        public double Subtotal()
        {
            return Product != null ? Product.Price * Quantity : 0;
        }

        /// <summary>
        /// Returns a formatted string representing the order line.
        /// </summary>
        /// <returns>A formatted string containing the quantity, product description, and subtotal.</returns>
        public override string ToString()
        {
            if (Product != null)
            {
                return this.Quantity.ToString().PadLeft(3) + string.Empty.PadLeft(5)
                    + this.Product.Description.PadRight(20)
                    + Conversions.ConvertNumericToCurrency(Subtotal()).PadLeft(10);
            }
            else
            {
                return "No product available!";
            }
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current order line.
        /// Order lines are considered equal if they have the same product.
        /// </summary>
        /// <param name="obj">The object to compare with the current order line.</param>
        /// <returns>True if the objects are equal, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            return obj is OrderLine orderLine && this.Product.Equals(orderLine.Product);
        }

        /// <summary>
        /// Returns a hash code for this order line.
        /// </summary>
        /// <returns>A hash code based on the product.</returns>
        public override int GetHashCode()
        {
            return 680826068 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }
    }
}
