using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Provides database operations related to customers, orders, products, and order lines.
    /// </summary>
    public static class DatabaseOperations
    {
        /// <summary>
        /// Retrieves a list of customers along with their orders.
        /// </summary>
        /// <returns>A list of customers including their associated orders.</returns>
        public static List<Customer> GetCustomersWithOrders()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Customers
                              .Include(x => x.Orders)
                              .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders and order lines.
        /// </summary>
        /// <returns>A list of customers including their associated orders and order lines.</returns>
        public static List<Customer> GetCustomersWithOrdersAndOrderLines()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Customers
                              .Include(x => x.Orders.Select(y => y.OrderLines))
                              .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders, order lines, and products.
        /// </summary>
        /// <returns>A list of customers including their associated orders, order lines, and products.</returns>
        public static List<Customer> GetCustomersWithOrdersOrderLinesAndProducts()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Customers
                              .Include(x => x.Orders.Select(y => y.OrderLines.Select(z => z.Product)))
                              .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders, order lines, products, and employees handling the orders.
        /// </summary>
        /// <returns>A list of customers including their associated orders, order lines, products, and employees.</returns>
        public static List<Customer> GetCustomersWithOrdersOrderLinesProductsAndEmployees()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Customers
                              .Include(x => x.Orders.Select(y => y.OrderLines.Select(z => z.Product)))
                              .Include(x => x.Orders.Select(y => y.Employee))
                              .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves all orders including customer and employee details.
        /// </summary>
        /// <returns>A list of orders with related customer and employee information.</returns>
        public static List<Order> GetOrders()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Orders
                            .Include(x => x.Customer)
                            .Include(x => x.Employee);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves an order by its ID, including order lines, customer, and employee details.
        /// </summary>
        /// <param name="orderId">The ID of the order to retrieve.</param>
        /// <returns>The order if found; otherwise, null.</returns>
        public static Order GetOrderById(int orderId)
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Orders
                            .Include(x => x.OrderLines)
                            .Include(x => x.Customer)
                            .Include(x => x.Employee)
                            .Where(x => x.OrderID == orderId);
                return query.SingleOrDefault();
            }
        }

        /// <summary>
        /// Retrieves all order lines associated with a specific order.
        /// </summary>
        /// <param name="orderId">The ID of the order whose order lines should be retrieved.</param>
        /// <returns>A list of order lines related to the specified order.</returns>
        public static List<OrderLine> GetOrderLinesByOrderId(int orderId)
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.OrderLines
                            .Include(x => x.Product)
                            .Where(x => x.OrderID == orderId);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves all available products.
        /// </summary>
        /// <returns>A list of all products.</returns>
        public static List<Product> GetProducts()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Products;
                return query.ToList();
            }
        }

        /// <summary>
        /// Adds a new order line to the database.
        /// </summary>
        /// <param name="orderLine">The order line to add.</param>
        /// <returns>The number of affected rows (1 if successful, 0 if an error occurs).</returns>
        public static int AddOrderLine(OrderLine orderLine)
        {
            try
            {
                using (SalesManagementEntities entities = new SalesManagementEntities())
                {
                    entities.OrderLines.Add(orderLine);
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }

        /// <summary>
        /// Updates an existing order line in the database.
        /// </summary>
        /// <param name="orderLine">The order line with updated information.</param>
        /// <returns>The number of affected rows (1 if successful, 0 if an error occurs).</returns>
        public static int UpdateOrderLine(OrderLine orderLine)
        {
            try
            {
                using (SalesManagementEntities entities = new SalesManagementEntities())
                {
                    entities.Entry(orderLine).State = EntityState.Modified;
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }

        /// <summary>
        /// Deletes an existing order line from the database.
        /// </summary>
        /// <param name="orderLine">The order line to delete.</param>
        /// <returns>The number of affected rows (1 if successful, 0 if an error occurs).</returns>
        public static int DeleteOrderLine(OrderLine orderLine)
        {
            try
            {
                using (SalesManagementEntities entities = new SalesManagementEntities())
                {
                    entities.Entry(orderLine).State = EntityState.Deleted;
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }
    }
}
