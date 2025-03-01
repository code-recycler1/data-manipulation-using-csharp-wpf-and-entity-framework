using System;
using System.Linq;

namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Partial class for Customer, providing various string representations of customer orders.
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// Returns a compact string representation of the customer and their orders.
        /// </summary>
        /// <returns>A string containing the company name and order IDs.</returns>
        public string ToStringCompact()
        {
            string text = "";
            text += "All orders from " + Company + Environment.NewLine;
            foreach (var order in Orders)
            {
                text += order.OrderID + Environment.NewLine;
            }
            return text;
        }

        /// <summary>
        /// Returns a compact string representation of the customer, their orders, and order lines.
        /// </summary>
        /// <returns>A string containing the company name, order IDs, and placeholders for order lines.</returns>
        public string ToStringOrderLinesCompact()
        {
            string text = "";
            text += "All orders from " + Company + Environment.NewLine;
            foreach (var order in Orders)
            {
                text += order.OrderID + Environment.NewLine;
                // Uncomment the line below if ToStringCompact is implemented for OrderLines.
                // order.OrderLines.ToList().ForEach(x => text += x.ToStringCompact());
            }
            return text;
        }

        /// <summary>
        /// Returns a detailed string representation of the customer, including orders and order lines.
        /// </summary>
        /// <returns>A string containing the company name, order IDs, and order line details.</returns>
        public override string ToString()
        {
            string text = "";
            text += "All orders from " + Company + Environment.NewLine;
            foreach (var order in Orders)
            {
                text += order.OrderID + Environment.NewLine;
                order.OrderLines.ToList().ForEach(x => text += x.ToString());
            }
            return text;
        }

        /// <summary>
        /// Returns a detailed string representation of the customer, including orders, order lines, and the employees handling them.
        /// </summary>
        /// <returns>
        /// A string containing the company name, order IDs, employee handling the order, and order line details.
        /// </returns>
        public string ToStringDetailed()
        {
            string text = "";
            text += "All orders from " + Company + Environment.NewLine;
            foreach (var order in Orders)
            {
                text += order.OrderID + " handled by: ";
                text += order.Employee.FirstName + " " + order.Employee.LastName + Environment.NewLine;

                order.OrderLines.ToList().ForEach(x => text += x.ToString());
            }
            return text;
        }
    }
}
