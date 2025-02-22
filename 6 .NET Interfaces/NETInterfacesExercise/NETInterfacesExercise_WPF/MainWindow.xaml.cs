using NETInterfacesExercise_DAL;
using NETInterfacesExercise_Models;
using System;
using System.Windows;

namespace NETInterfacesExercise_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// Manages the user interface for handling products, bank account operations, and purchases.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Represents the person using the application.
        /// </summary>
        Person person = new Person("John Doe", "78122898541");

        /// <summary>
        /// Handles the Window Loaded event.
        /// Loads the list of products from the file and populates the product combo box.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
        }

        /// <summary>
        /// Handles the click event for the "Open Account" button.
        /// Creates and validates a new bank account, updating the UI accordingly.
        /// </summary>
        private void btnOpenAccount_Click(object sender, RoutedEventArgs e)
        {
            BankAccount bankAccount = new BankAccount(txtIBAN.Text);
            if (bankAccount.IsValid())
            {
                person.BankAccount = bankAccount;
                lblBankAccount.Content = bankAccount.ToString();
                txtIBAN.Text = "";
                txtAmount.Text = "";
            }
            else
            {
                lblBankAccount.Content = bankAccount.Error;
            }
        }

        /// <summary>
        /// Handles the click event for the "Deposit" button.
        /// Deposits a specified amount into the person's bank account.
        /// </summary>
        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = ValidateBankAccount();
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                bool success = person.Deposit(double.Parse(txtAmount.Text));
                if (success)
                {
                    lblBankAccount.Content = person.BankAccount.ToString();
                }
                else
                {
                    lblBankAccount.Content = "This person does not have a bank account.";
                }
            }
            else
            {
                lblBankAccount.Content = "The amount must be a numeric value!";
            }
        }

        /// <summary>
        /// Handles the click event for the "Withdraw" button.
        /// Withdraws a specified amount from the person's bank account.
        /// </summary>
        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = ValidateBankAccount();
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                bool? success = person.Withdraw(double.Parse(txtAmount.Text));
                if (success == true)
                {
                    lblBankAccount.Content = person.BankAccount.ToString();
                }
                else if (success == false)
                {
                    lblBankAccount.Content = "You do not have enough money in your account!";
                }
                else if (success == null)
                {
                    lblBankAccount.Content = "This person does not have a bank account.";
                }
            }
            else
            {
                lblBankAccount.Content = "The amount must be a numeric value!";
            }
        }

        /// <summary>
        /// Handles the click event for the "Buy" button.
        /// Attempts to purchase a selected product and updates the UI based on the transaction result.
        /// </summary>
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            bool success = false;
            if (cmbProducts.SelectedItem is Product product)
            {
                success = person.BuyProduct(product);
                if (success)
                {
                    lblBankAccount.Content = person.BankAccount.ToString();
                }
                else
                {
                    MessageBox.Show("Insufficient balance in your bank account", "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a product", "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            lblOwnership.Content = person.ToString();
        }

        /// <summary>
        /// Handles the click event for the "New Product" button.
        /// Opens a new ApplianceWindow for entering product information and refreshes the product list.
        /// </summary>
        private void btnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ApplianceWindow applianceWindow = new ApplianceWindow();
            applianceWindow.ShowDialog();
            cmbProducts.ItemsSource = FileOperations.ReadFile("doc\\products.txt");
        }

        /// <summary>
        /// Validates that the bank account amount input is numeric.
        /// </summary>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        private string ValidateBankAccount()
        {
            string errorMessages = "";

            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                errorMessages += "Amount is a required NUMERIC field!" + Environment.NewLine;
            }

            return errorMessages;
        }
    }
}
