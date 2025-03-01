using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFNavigationPropertiesExample_DAL
{
    /// <summary>
    /// Provides database operations for retrieving customer and order-related data.
    /// </summary>
    public static class DatabaseOperations
    {
        /// <summary>
        /// Retrieves a list of customers along with their associated orders.
        /// </summary>
        /// <returns>A list of customers with their orders.</returns>
        public static List<Customer> GetCustomersWithOrders()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                //var query = entities.Customers
                //              .Include("Orders")
                //              .OrderBy(x => x.Company);
                var query = entities.Customers
                    .Include(x => x.Orders)
                    .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders and order lines.
        /// </summary>
        /// <returns>A list of customers with their orders and order lines.</returns>
        public static List<Customer> GetCustomersWithOrdersAndOrderLines()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                //var query = entities.Customers
                //              .Include("Orders.OrderLines")
                //              .OrderBy(x => x.Company);
                var query = entities.Customers
                    .Include(x => x.Orders.Select(sub => sub.OrderLines))
                    .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders, order lines, and associated products.
        /// </summary>
        /// <returns>A list of customers with their orders, order lines, and products.</returns>
        public static List<Customer> GetCustomersWithOrdersOrderLinesProduct()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                //var query = entities.Customers
                //              .Include("Orders.OrderLines.Product")
                //              .OrderBy(x => x.Company);
                var query = entities.Customers
                    .Include(x => x.Orders.Select(sub => sub.OrderLines.Select(sub2 => sub2.Product)))
                    .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of customers along with their orders, order lines, products, and employees associated with the orders.
        /// </summary>
        /// <returns>A list of customers with their orders, order lines, products, and employees.</returns>
        public static List<Customer> GetCustomersWithOrdersOrderLinesProductEmployees()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                //var query = entities.Customers
                //              .Include("Orders.OrderLines.Product")
                //              .Include("Orders.Employee")
                //              .OrderBy(x => x.Company);
                var query = entities.Customers
                    .Include(x => x.Orders.Select(sub => sub.OrderLines.Select(sub2 => sub2.Product)))
                    .Include(x => x.Orders.Select(sub => sub.Employee))
                    .OrderBy(x => x.Company);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of orders along with their associated customers and employees.
        /// </summary>
        /// <returns>A list of orders including customer and employee details.</returns>
        public static List<Order> GetOrders()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                //var query = entities.Orders
                //            .Include("Customer")
                //            .Include("Employee");
                var query = entities.Orders
                    .Include(x => x.Customer)
                    .Include(x => x.Employee);
                return query.ToList();
            }
        }
    }
}
