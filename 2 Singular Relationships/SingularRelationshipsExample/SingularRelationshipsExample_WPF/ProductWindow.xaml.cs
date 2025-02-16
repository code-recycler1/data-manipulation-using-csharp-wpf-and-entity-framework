using SingularRelationshipsExample_DAL;
using SingularRelationshipsExample_Models;
using System;
using System.Windows;

namespace SingularRelationshipsExample_WPF
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml.
    /// Allows users to add new products to the system.
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Loads products from a file and binds them to the ListBox.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
            rbBook.IsChecked = true;
        }

        /// <summary>
        /// Handles the "Book" radio button checked event.
        /// Shows the extra field for the author.
        /// </summary>
        private void rbBook_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Author";
        }

        /// <summary>
        /// Handles the "Software" radio button checked event.
        /// Shows the extra field for the version.
        /// </summary>
        private void rbSoftware_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Version";
        }

        /// <summary>
        /// Handles the "Product" radio button checked event.
        /// Hides the extra field.
        /// </summary>
        private void rbProduct_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Hidden;
            txtExtra.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the "Exit" button click event.
        /// Closes the window.
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the "Add Product" button click event.
        /// Validates input and adds a new product to the file.
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
                lbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");

                ClearFields();
            }
            else
            {
                lblErrors.Content = errorMessage;
            }
        }

        /// <summary>
        /// Validates user input for product fields.
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
                errorMessage += "Price is a mandatory NUMERIC field!" + Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(txtExtra.Text) && rbProduct.IsChecked == false)
            {
                errorMessage += lblExtra.Content + " is a required field!" + Environment.NewLine;
            }

            return errorMessage;
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        private void ClearFields()
        {
            txtCode.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtExtra.Text = "";
        }
    }
}