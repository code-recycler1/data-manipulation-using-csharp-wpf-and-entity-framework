using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EF_CUD_Example_DAL;

namespace EF_CUD_Example_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// This class handles UI interactions for managing order lines, including 
    /// searching, adding, updating, and deleting order lines.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event triggered when the window is loaded. 
        /// It populates the product combo box with available products.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbProducts.DisplayMemberPath = "Name";
            cmbProducts.ItemsSource = DatabaseOperations.GetProducts();
        }

        /// <summary>
        /// Event triggered when an order line is selected in the data grid.
        /// It updates the UI fields with the selected order line's details.
        /// </summary>
        private void datagridOrderLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagridOrderLines.SelectedItem is OrderLine orderLine)
            {
                txtQuantity.Text = orderLine.Quantity.ToString();
                cmbProducts.SelectedItem = orderLine.Product;
                cmbProducts.IsEnabled = false;
            }
        }

        /// <summary>
        /// Searches for order lines based on the given order ID.
        /// Displays the results in the data grid.
        /// </summary>
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtOrderID.Text, out int orderID))
            {
                List<OrderLine> orderLines = DatabaseOperations.GetOrderLinesByOrderId(orderID);
                if (orderLines != null)
                {
                    datagridOrderLines.ItemsSource = orderLines;
                }
                else
                {
                    MessageBox.Show("No order lines found for Order ID " + orderID);
                }
            }
            else
            {
                MessageBox.Show("Order ID is not numeric.");
            }
        }

        /// <summary>
        /// Deletes the selected order line from the database.
        /// Updates the UI after deletion.
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = Validate("OrderLine");
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                OrderLine orderLine = datagridOrderLines.SelectedItem as OrderLine;
                int orderID = orderLine.OrderID;

                int result = DatabaseOperations.DeleteOrderLine(orderLine);
                if (result > 0)
                {
                    datagridOrderLines.ItemsSource = DatabaseOperations.GetOrderLinesByOrderId(orderID);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Order line was not deleted.");
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        /// <summary>
        /// Adds a new order line to the database.
        /// Updates the UI with the new order line.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = Validate("Product") + Validate("Quantity") + Validate("OrderID");

            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                Product product = cmbProducts.SelectedItem as Product;
                OrderLine orderLine = new OrderLine
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = product.ProductID,
                    Quantity = short.Parse(txtQuantity.Text)
                };

                if (orderLine.IsValid())
                {
                    int result = DatabaseOperations.AddOrderLine(orderLine);
                    if (result > 0)
                    {
                        datagridOrderLines.ItemsSource = DatabaseOperations.GetOrderLinesByOrderId(orderLine.OrderID);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Order line was not added.");
                    }
                }
                else
                {
                    MessageBox.Show(orderLine.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        /// <summary>
        /// Updates the quantity of the selected order line.
        /// Updates the UI after modification.
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = Validate("OrderLine") + Validate("Quantity");

            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                OrderLine orderLine = datagridOrderLines.SelectedItem as OrderLine;
                orderLine.Quantity = short.Parse(txtQuantity.Text);

                if (orderLine.IsValid())
                {
                    int result = DatabaseOperations.UpdateOrderLine(orderLine);
                    if (result > 0)
                    {
                        datagridOrderLines.ItemsSource = DatabaseOperations.GetOrderLinesByOrderId(orderLine.OrderID);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Order line was not updated.");
                    }
                }
                else
                {
                    MessageBox.Show(orderLine.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        /// <summary>
        /// Cancels the current operation and resets the input fields.
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Resets the input fields and selection in the UI.
        /// </summary>
        private void Reset()
        {
            datagridOrderLines.SelectedIndex = -1;
            txtQuantity.Text = "";
            cmbProducts.SelectedIndex = -1;
            cmbProducts.IsEnabled = true;
        }

        /// <summary>
        /// Validates the input based on the given column name.
        /// </summary>
        /// <param name="columnName">The name of the column to validate.</param>
        /// <returns>A validation message if the input is invalid; otherwise, an empty string.</returns>
        private string Validate(string columnName)
        {
            if (columnName == "OrderLine" && datagridOrderLines.SelectedItem == null)
            {
                return "Select an order line!" + Environment.NewLine;
            }
            if (columnName == "Product" && cmbProducts.SelectedItem == null)
            {
                return "Select a product!" + Environment.NewLine;
            }
            if (columnName == "Quantity" && !short.TryParse(txtQuantity.Text, out short quantity))
            {
                return "Quantity must be a numeric value!" + Environment.NewLine;
            }
            if (columnName == "OrderID" && !int.TryParse(txtOrderID.Text, out int orderID))
            {
                return "Order ID must be a numeric value!" + Environment.NewLine;
            }
            return "";
        }
    }
}
