using NETInterfacesExercise_Models;
using System;
using System.Windows;

namespace NETInterfacesExercise_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Person person = new Person("John Doe", "78122898541");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpenAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            lblOwnership.Content = person.ToString();
        }

        private void btnNewProduct_Click(object sender, RoutedEventArgs e)
        {

        }

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
