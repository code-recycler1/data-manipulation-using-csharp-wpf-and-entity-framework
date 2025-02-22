using NETInterfacesExercise_DAL;
using NETInterfacesExercise_Models;
using System;
using System.Windows;

namespace NETInterfacesExercise_WPF
{
    /// <summary>
    /// Interaction logic for ApplianceWindow.xaml
    /// </summary>
    public partial class ApplianceWindow : Window
    {
        public ApplianceWindow()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = ValidateProduct();
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                double.TryParse(txtPrice.Text, out double price);
                Book book = new Book(txtCode.Text, txtDescription.Text, price, txtAuthor.Text);

                if (book.IsValid())
                {
                    FileOperations.AddProduct(book);
                }
                else
                {
                    MessageBox.Show(book.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        private void btnAddTV_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = ValidateTelevision();
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                double.TryParse(txtPrice.Text, out double price);
                int.TryParse(txtRefreshRate.Text, out int hertz);
                int.TryParse(txtScreenSize.Text, out int screenSize);
                Television television = new Television(txtCode.Text, txtDescription.Text, price, txtBrand.Text, txtType.Text, hertz, screenSize);

                if (television.IsValid())
                {
                    FileOperations.AddProduct(television);
                }
                else
                {
                    MessageBox.Show(television.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        private void btnAddKettle_Click(object sender, RoutedEventArgs e)
        {
            string errorMessages = ValidateKettle();
            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                double.TryParse(txtPrice.Text, out double price);
                double.TryParse(txtCapacity.Text, out double capacity);
                ElectricKettle kettle = new ElectricKettle(txtCode.Text, txtDescription.Text, price, txtBrand.Text, txtType.Text, capacity);

                if (kettle.IsValid())
                {
                    FileOperations.AddProduct(kettle);
                }
                else
                {
                    MessageBox.Show(kettle.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages);
            }
        }

        private string ValidateProduct()
        {
            string errorMessages = "";

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                errorMessages += "Price is a required NUMERIC field!" + Environment.NewLine;
            }

            return errorMessages;
        }

        private string ValidateTelevision()
        {
            string errorMessages = ValidateProduct();

            if (!double.TryParse(txtRefreshRate.Text, out double hertz))
            {
                errorMessages += "Refresh rate is a required NUMERIC field!" + Environment.NewLine;
            }
            if (!double.TryParse(txtScreenSize.Text, out double screenSize))
            {
                errorMessages += "Screen size is a required NUMERIC field!" + Environment.NewLine;
            }
            return errorMessages;
        }

        private string ValidateKettle()
        {
            string errorMessages = ValidateProduct();

            if (!double.TryParse(txtCapacity.Text, out double capacity))
            {
                errorMessages += "Capacity is a required NUMERIC field!" + Environment.NewLine;
            }

            return errorMessages;
        }
    }
}
