using EFNavigationPropertiesExample_DAL;
using System;
using System.Collections.Generic;
using System.Windows;

namespace EFNavigationPropertiesExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// Provides functionality to display customer orders and related details.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays all orders, including the associated customer and handling employee.
        /// </summary>
        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Order> orders = DatabaseOperations.GetOrders();
            foreach (Order order in orders)
            {
                lblData.Content += $"Order {order.OrderID} from {order.Customer.Company}" + Environment.NewLine;
                lblData.Content += $"Handled by {order.Employee.FirstName} {order.Employee.LastName}" + Environment.NewLine;
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays all customers and their orders.
        /// </summary>
        private void btnCustomersWithOrders_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Customer> customers = DatabaseOperations.GetCustomersWithOrders();
            foreach (var customer in customers)
            {
                lblData.Content += "All orders from " + customer.Company + Environment.NewLine;
                foreach (var order in customer.Orders)
                {
                    lblData.Content += order.OrderID + Environment.NewLine;
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays all customers, their orders, and the order lines (products and quantities).
        /// </summary>
        private void btnCustomersWithOrdersAndOrderLines_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Customer> customers = DatabaseOperations.GetCustomersWithOrdersAndOrderLines();
            foreach (var customer in customers)
            {
                lblData.Content += "All orders from " + customer.Company + Environment.NewLine;
                foreach (var order in customer.Orders)
                {
                    lblData.Content += order.OrderID + Environment.NewLine;
                    foreach (var orderLine in order.OrderLines)
                    {
                        lblData.Content += orderLine.Quantity.ToString().PadLeft(10)
                            + " x product number " + orderLine.ProductID + Environment.NewLine;
                    }
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays all customers, their orders, order lines, and product names.
        /// </summary>
        private void btnCustomersWithOrdersOrderLinesProduct_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Customer> customers = DatabaseOperations.GetCustomersWithOrdersOrderLinesProduct();
            foreach (var customer in customers)
            {
                lblData.Content += "All orders from " + customer.Company + Environment.NewLine;
                foreach (var order in customer.Orders)
                {
                    lblData.Content += order.OrderID + Environment.NewLine;
                    foreach (var orderLine in order.OrderLines)
                    {
                        lblData.Content += orderLine.Quantity.ToString().PadLeft(10)
                            + " x " + orderLine.Product.Name + Environment.NewLine;
                    }
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays all customers, their orders, order lines, product names, and the employee handling the order.
        /// </summary>
        private void btnCustomersWithOrdersOrderLinesProductEmployee_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Customer> customers = DatabaseOperations.GetCustomersWithOrdersOrderLinesProductEmployees();
            foreach (var customer in customers)
            {
                lblData.Content += "All orders from " + customer.Company + Environment.NewLine;
                foreach (var order in customer.Orders)
                {
                    lblData.Content += order.OrderID + " handled by: ";
                    lblData.Content += order.Employee.FirstName + " " + order.Employee.LastName + Environment.NewLine;
                    foreach (var orderLine in order.OrderLines)
                    {
                        lblData.Content += orderLine.Quantity.ToString().PadLeft(10)
                            + " x " + orderLine.Product.Name + Environment.NewLine;
                    }
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }
    }

}
