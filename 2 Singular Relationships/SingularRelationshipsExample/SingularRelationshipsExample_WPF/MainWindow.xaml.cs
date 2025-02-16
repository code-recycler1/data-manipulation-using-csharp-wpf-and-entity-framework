using SingularRelationshipsExample_DAL;
using SingularRelationshipsExample_Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace SingularRelationshipsExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// Demonstrates the use of singular relationships and static classes.
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<OrderLine> orderLines = new List<OrderLine>();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Loads products from a file and binds them to the ComboBox.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
            lbOrderLines.ItemsSource = orderLines;
        }

        /// <summary>
        /// Handles the "Add New Product" button click event.
        /// Opens the ProductWindow to add a new product.
        /// </summary>
        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.ShowDialog();
            cmbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
        }

        /// <summary>
        /// Handles the "Add" button click event.
        /// Adds a new order line to the list and updates the ListBox.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = ValidateInput();
            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Product selectedProduct = cmbProducts.SelectedItem as Product;
                OrderLine orderLine = new OrderLine(selectedProduct, int.Parse(txtQuantity.Text));

                if (!orderLines.Contains(orderLine))
                {
                    orderLines.Add(orderLine);
                }
                else
                {
                    orderLines.Find(x => x.Equals(orderLine)).Quantity += orderLine.Quantity;
                }

                lbOrderLines.Items.Refresh();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Handles the "Remove" button click event.
        /// Removes the selected order line from the list.
        /// </summary>
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbOrderLines.SelectedItem is OrderLine selectedOrderLine)
            {
                orderLines.Remove(selectedOrderLine);
                lbOrderLines.Items.Refresh();
            }
        }

        /// <summary>
        /// Validates user input for quantity and product selection.
        /// </summary>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        private string ValidateInput()
        {
            string errorMessage = "";
            if (!int.TryParse(txtQuantity.Text, out _))
            {
                errorMessage += "Quantity is a mandatory NUMERIC field!" + Environment.NewLine;
            }
            if (!(cmbProducts.SelectedItem is Product))
            {
                errorMessage += "Select a product!" + Environment.NewLine;
            }
            return errorMessage;
        }
    }
}