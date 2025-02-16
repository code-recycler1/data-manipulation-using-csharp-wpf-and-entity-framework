using MultipleRelationshipsExample_DAL;
using MultipleRelationshipsExample_Models;
using System;
using System.Windows;

namespace MultipleRelationshipsExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// Manages the ordering process, including product selection, adding/removing items, and checkout.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the main window components.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Represents the current order in progress.
        /// </summary>
        private Order _order = null;

        /// <summary>
        /// Handles the window's Loaded event.
        /// Loads available products from a file into the combo box.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbProduct.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
        }

        /// <summary>
        /// Opens a new product entry window and refreshes the product list after the window is closed.
        /// </summary>
        private void btnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            var productWindow = new ProductWindow();
            productWindow.ShowDialog();
            cmbProduct.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
        }

        /// <summary>
        /// Adds a selected product to the order with the specified quantity.
        /// If no order exists, a new one is created.
        /// </summary>
        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = ValidateInput();

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                if (_order == null)
                {
                    _order = new Order();
                    lbOrderLines.ItemsSource = _order.OrderLines;
                }

                var selectedProduct = cmbProduct.SelectedItem as Product;
                var orderLine = new OrderLine(selectedProduct, int.Parse(txtQuantity.Text));

                _order.AddOrderLine(orderLine);
                RefreshItems();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Removes the selected order line from the current order.
        /// </summary>
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbOrderLines.SelectedItem is OrderLine orderLine)
            {
                _order.RemoveOrderLine(orderLine);
                RefreshItems();
            }
            else
            {
                MessageBox.Show("Select an order line!", "Error");
            }
        }

        /// <summary>  
        /// Displays the order receipt and resets the order and UI.  
        /// </summary>  
        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            if (_order != null)
            {
                MessageBox.Show(_order.ToString(), "Order Receipt", MessageBoxButton.OK, MessageBoxImage.Information);

                // Reset order
                _order = null;

                // Clear UI elements
                txtQuantity.Text = string.Empty;
                cmbProduct.SelectedIndex = -1; // Resets the ComboBox selection
                lbOrderLines.ItemsSource = null; // Clears the ListBox
                txtTotal.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("There is no order to checkout. Please add items to the order first.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        /// <summary>
        /// Validates user input for product selection and quantity.
        /// </summary>
        /// <returns>Error message string if validation fails; otherwise, an empty string.</returns>
        private string ValidateInput()
        {
            var errorMessage = "";
            if (!double.TryParse(txtQuantity.Text, out _))
            {
                errorMessage += "Quantity is a required NUMERIC field!" + Environment.NewLine;
            }
            if (!(cmbProduct.SelectedItem is Product))
            {
                errorMessage += "Select a product!" + Environment.NewLine;
            }
            return errorMessage;
        }

        /// <summary>
        /// Refreshes the displayed order lines and updates the total price.
        /// </summary>
        private void RefreshItems()
        {
            lbOrderLines.Items.Refresh();
            txtTotal.Text = Conversions.ConvertNumericToCurrency(_order.Total());
        }
    }
}
