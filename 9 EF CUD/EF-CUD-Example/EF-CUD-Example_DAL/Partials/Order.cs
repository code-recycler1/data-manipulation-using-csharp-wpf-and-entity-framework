namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Partial class for Order, providing a formatted string representation of an order.
    /// </summary>
    public partial class Order
    {
        /// <summary>
        /// Returns a string representation of the order, including order ID, customer company name (if available), 
        /// and the employee handling the order (if available).
        /// </summary>
        /// <returns>A formatted string describing the order.</returns>
        //public override string ToString()
        //{
        //    string text = $"Order {OrderID} ";

        //    if (Customer != null)
        //    {
        //        text += $"from {Customer.Company}";
        //    }

        //    text += Environment.NewLine;

        //    if (Employee != null)
        //    {
        //        text += $"handled by {Employee.FirstName} {Employee.LastName}";
        //    }

        //    return text + Environment.NewLine;
        //}
    }
}
