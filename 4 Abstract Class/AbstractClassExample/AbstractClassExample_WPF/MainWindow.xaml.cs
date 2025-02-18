using AbstractClassExample_DAL;
using AbstractClassExample_Models;
using System;
using System.Windows;

namespace AbstractClassExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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
        /// Event handler for when the window is loaded. 
        /// Loads products from a file into the ListBox and sets the default selection to "Book".
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbProducts.ItemsSource = FileOperations.ReadFile("products.txt");
            rbBook.IsChecked = true;
        }

        /// <summary>
        /// Event handler for when the "Book" radio button is checked.
        /// Displays the extra field with the label "Author".
        /// </summary>
        private void rbBook_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Author";
        }

        /// <summary>
        /// Event handler for when the "Software" radio button is checked.
        /// Displays the extra field with the label "Version".
        /// </summary>
        private void rbSoftware_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Version";
        }

        /// <summary>
        /// Event handler for the "Exit" button click.
        /// Closes the application.
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        /// <summary>
        /// Event handler for the "Add" button click.
        /// Adds a new product (Book or Software) to the file and updates the ListBox.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product product = null;

            if (double.TryParse(txtPrice.Text, out double price))
            {
                if (rbBook.IsChecked == true)
                {
                    product = new Book(txtCode.Text, txtDescription.Text, price, txtExtra.Text);
                }
                else if (rbSoftware.IsChecked == true)
                {
                    product = new Software(txtCode.Text, txtDescription.Text, price, txtExtra.Text);
                }

                if (product.IsValid())
                {
                    // Save the product to the file
                    FileOperations.AddProduct("products.txt", product);

                    // Reload the product list
                    lbProducts.ItemsSource = FileOperations.ReadFile("products.txt");

                    // Clear input fields
                    txtCode.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                    txtExtra.Text = "";
                }
                else
                {
                    // Display validation error messages
                    lblErrors.Content = product.ErrorMessages;
                }
            }
            else
            {
                lblErrors.Content = "Price is a required NUMERIC field!" + Environment.NewLine;
            }
        }
    }
}
