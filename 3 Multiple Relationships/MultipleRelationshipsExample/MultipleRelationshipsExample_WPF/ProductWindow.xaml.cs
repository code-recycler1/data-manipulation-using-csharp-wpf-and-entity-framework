using MultipleRelationshipsExample_DAL;
using MultipleRelationshipsExample_Models;
using System;
using System.Windows;

namespace MultipleRelationshipsExample_WPF
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml.
    /// Allows users to add new products (Book, Software, or Generic Product) and view existing products.
    /// </summary>
    public partial class ProductWindow : Window
    {
        /// <summary>
        /// Initializes the product window components.
        /// </summary>
        public ProductWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the window's Loaded event.
        /// Loads products from a file and sets the default selection to "Book."
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
            rbBook.IsChecked = true;
        }

        /// <summary>
        /// Handles the event when the "Book" radio button is checked.
        /// Displays an extra input field for the author's name.
        /// </summary>
        private void rbBook_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Author";
        }

        /// <summary>
        /// Handles the event when the "Software" radio button is checked.
        /// Displays an extra input field for the software version.
        /// </summary>
        private void rbSoftware_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Software Version";
        }

        /// <summary>
        /// Handles the event when the "Generic Product" radio button is checked.
        /// Hides the extra input field since no additional information is needed.
        /// </summary>
        private void rbProduct_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Hidden;
            txtExtra.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Closes the product window when the Exit button is clicked.
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds a new product to the product list.
        /// Validates input, creates the appropriate product type, and saves it to a file.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product product = null;
            string errorMessage = ValidateInput();

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                if (rbBook.IsChecked == true)
                {
                    product = new Book(txtCode.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtExtra.Text);
                }
                else if (rbSoftware.IsChecked == true)
                {
                    product = new Software(txtCode.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtExtra.Text);
                }
                else
                {
                    product = new Product(txtCode.Text, txtDescription.Text, double.Parse(txtPrice.Text));
                }

                FileOperations.AddProduct("doc\\products.txt", product);

                // Refresh the product list
                lbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");

                // Clear input fields
                txtCode.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                txtExtra.Text = "";
            }
            else
            {
                lblErrors.Content = errorMessage;
            }
        }

        /// <summary>
        /// Validates user input for product creation.
        /// Ensures required fields are filled and that the price is numeric.
        /// </summary>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        private string ValidateInput()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                errorMessage += "Code is a required field!" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorMessage += "Description is a required field!" + Environment.NewLine;
            }

            if (!double.TryParse(txtPrice.Text, out _))
            {
                errorMessage += "Price is a required NUMERIC field!" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(txtExtra.Text) && rbProduct.IsChecked == false)
            {
                errorMessage += lblExtra.Content + " is a required field!" + Environment.NewLine;
            }

            return errorMessage;
        }
    }
}
