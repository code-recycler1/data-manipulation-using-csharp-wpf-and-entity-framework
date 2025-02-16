using System.Collections.Generic;

namespace MultipleRelationshipsExample_Models
{
    /// <summary>
    /// Represents a line item in an order, which includes a product and its quantity.
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Gets or sets the product associated with this order line.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product in this order line.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine"/> class.
        /// </summary>
        /// <param name="product">The product being ordered.</param>
        /// <param name="quantity">The quantity of the product.</param>
        public OrderLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        /// <summary>
        /// Calculates the subtotal cost for this order line.
        /// </summary>
        /// <returns>The subtotal, calculated as price * quantity.</returns>
        public double Subtotal()
        {
            return Product != null ? Product.Price * Quantity : 0;
        }

        /// <summary>
        /// Returns a formatted string representing this order line,
        /// including quantity, product description, and subtotal.
        /// </summary>
        /// <returns>A string representation of the order line.</returns>
        public override string ToString()
        {
            if (Product != null)
            {
                return Quantity.ToString().PadLeft(3) + string.Empty.PadLeft(5)
                    + Product.Description.PadRight(20)
                    + Conversions.ConvertNumericToCurrency(Subtotal()).PadLeft(10);
            }
            else
            {
                return "No product assigned!";
            }
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current order line.
        /// Two order lines are considered equal if they reference the same product.
        /// </summary>
        /// <param name="obj">The object to compare with the current order line.</param>
        /// <returns>True if the objects are equal, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            return obj is OrderLine orderLine && this.Product.Equals(orderLine.Product);
        }

        /// <summary>
        /// Returns the hash code for this order line, based on its product.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return 680826068 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }
    }
}
