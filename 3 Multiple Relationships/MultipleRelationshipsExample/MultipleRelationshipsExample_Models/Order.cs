using System;
using System.Collections.Generic;

namespace MultipleRelationshipsExample_Models
{
    /// <summary>
    /// Represents an order containing multiple order lines.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique order number.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets the list of order lines associated with this order.
        /// </summary>
        public List<OrderLine> OrderLines { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class
        /// with a unique order number and an empty list of order lines.
        /// </summary>
        public Order()
        {
            OrderLines = new List<OrderLine>();
            OrderNumber = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Adds an order line to the order. If the order line already exists,
        /// its quantity is increased by the new quantity.
        /// </summary>
        /// <param name="orderLine">The order line to add.</param>
        public void AddOrderLine(OrderLine orderLine)
        {
            if (!OrderLines.Contains(orderLine))
            {
                OrderLines.Add(orderLine);
            }
            else
            {
                OrderLines.Find(x => x.Equals(orderLine)).Quantity += orderLine.Quantity;
            }
        }

        /// <summary>
        /// Removes an order line from the order.
        /// </summary>
        /// <param name="orderLine">The order line to remove.</param>
        public void RemoveOrderLine(OrderLine orderLine)
        {
            OrderLines.Remove(orderLine);
        }

        /// <summary>
        /// Calculates the total cost of the order by summing up the subtotals of all order lines.
        /// </summary>
        /// <returns>The total cost of the order.</returns>
        public double Total()
        {
            double total = 0;
            OrderLines.ForEach(x => total += x.Subtotal());
            return total;
        }

        /// <summary>
        /// Returns a formatted string representation of the order, 
        /// including the order number, order lines, and total cost.
        /// </summary>
        /// <returns>A string representation of the order.</returns>
        public override string ToString()
        {
            string text = $"Order {OrderNumber}{Environment.NewLine}";
            text += "Contains the following order lines:" + Environment.NewLine;
            OrderLines.ForEach(x => text += x.ToString() + Environment.NewLine);
            text += Environment.NewLine;
            text += "Total: " + Conversions.ConvertNumericToCurrency(Total());

            return text;
        }
    }
}
