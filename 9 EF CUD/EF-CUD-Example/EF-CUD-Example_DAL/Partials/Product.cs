namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Represents a product with equality comparison and string representation overrides.
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Determines whether the specified object is equal to the current product.
        /// </summary>
        /// <param name="obj">The object to compare with the current product.</param>
        /// <returns>
        /// True if the specified object is a <see cref="Product"/> and has the same product ID; otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is Product product && ProductID == product.ProductID;
        }

        /// <summary>
        /// Returns a hash code for this product.
        /// </summary>
        /// <returns>A hash code based on the product number.</returns>
        public override int GetHashCode()
        {
            return -1472680747 + ProductID.GetHashCode();
        }

        /// <summary>
        /// Returns a string representation of the product, which is its name.
        /// </summary>
        /// <returns>The name of the product.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
