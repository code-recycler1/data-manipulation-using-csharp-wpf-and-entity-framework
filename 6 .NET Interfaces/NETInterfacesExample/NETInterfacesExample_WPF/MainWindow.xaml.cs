using NETInterfacesExample_DAL;
using NETInterfacesExample_Models;
using System;
using System.Windows;

namespace NETInterfacesExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// This class handles UI interactions, including loading products, adding new ones, 
    /// and handling different product types (Book and Software).
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
        /// Handles the Window Loaded event.
        /// Loads the product list from a file and sets the default product type to "Book".
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbProducts.ItemsSource = FileOperations.ReadFile("products.txt");
            rbBook.IsChecked = true;
        }

        /// <summary>
        /// Handles the Book radio button checked event.
        /// Updates the UI to prompt the user for an author.
        /// </summary>
        private void rbBook_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Author";
        }

        /// <summary>
        /// Handles the Software radio button checked event.
        /// Updates the UI to prompt the user for a software version.
        /// </summary>
        private void rbSoftware_Checked(object sender, RoutedEventArgs e)
        {
            lblExtra.Visibility = Visibility.Visible;
            txtExtra.Visibility = Visibility.Visible;
            lblExtra.Content = "Version";
        }

        /// <summary>
        /// Handles the Exit button click event.
        /// Closes the application.
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        /// <summary>
        /// Handles the Add button click event.
        /// Adds a new product (Book or Software) to the list and updates the UI.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product product = null;

            // Validate that the price input is numeric
            if (double.TryParse(txtPrice.Text, out double price))
            {
                // Determine the type of product to create
                if (rbBook.IsChecked == true)
                {
                    product = new Book(txtCode.Text, txtDescription.Text, price, txtExtra.Text);
                }
                else if (rbSoftware.IsChecked == true)
                {
                    product = new Software(txtCode.Text, txtDescription.Text, price, txtExtra.Text);
                }

                // Validate the product before saving
                if (product.IsValid())
                {
                    FileOperations.AddProduct("products.txt", product);

                    // Refresh product list
                    lbProducts.ItemsSource = FileOperations.ReadFile("products.txt");

                    // Clear input fields
                    txtCode.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                    txtExtra.Text = "";
                }
                else
                {
                    lblErrors.Content = product.Error;
                }
            }
            else
            {
                lblErrors.Content = "Price is a required NUMERIC field!" + Environment.NewLine;
            }
        }

        /// <summary>
        /// Handles the Indexer Example button click event.
        /// Opens the IndexerWindow for demonstration purposes.
        /// </summary>
        private void btnIndexer_Click(object sender, RoutedEventArgs e)
        {
            IndexerWindow indexerWindow = new IndexerWindow();
            indexerWindow.Show();
        }
    }
}
