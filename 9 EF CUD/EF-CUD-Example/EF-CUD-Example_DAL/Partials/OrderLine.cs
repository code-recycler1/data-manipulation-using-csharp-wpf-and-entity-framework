using EF_CUD_Example_Models;

namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Represents an order line, including validation and string formatting for display.
    /// </summary>
    public partial class OrderLine : BaseClass
    {
        /// <summary>
        /// Validates the specified property and returns an error message if invalid.
        /// </summary>
        /// <param name="columnName">The name of the property being validated.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "OrderID" && OrderID <= 0)
                {
                    return "Order ID must be a positive number!";
                }
                if (columnName == "Quantity" && Quantity < 0)
                {
                    return "Quantity must be a positive number!";
                }
                if (columnName == "ProductID" && ProductID <= 0)
                {
                    return "Product ID must be a positive number!";
                }
                return "";
            }
        }

        /// <summary>
        /// Returns a compact string representation of the order line, including quantity and product ID.
        /// </summary>
        /// <returns>A formatted string representing the order line.</returns>
        //public string ToStringCompact()
        //{
        //    string text = Quantity.ToString().PadLeft(10) + " x product ID " + ProductID;
        //    return text + Environment.NewLine;
        //}

        /// <summary>
        /// Returns a string representation of the order line, including quantity and product name (if available).
        /// </summary>
        /// <returns>A formatted string representing the order line.</returns>
        //public override string ToString()
        //{
        //    string text = Quantity.ToString().PadLeft(10) + " x ";
        //    if (Product != null)
        //    {
        //        text += Product.Name;
        //    }
        //    else
        //    {
        //        text += "unknown";
        //    }
        //    return text + Environment.NewLine;
        //}
    }
}
