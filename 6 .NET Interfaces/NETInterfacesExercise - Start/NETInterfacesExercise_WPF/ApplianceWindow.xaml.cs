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

        }

        private void btnAddTV_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddKettle_Click(object sender, RoutedEventArgs e)
        {

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
