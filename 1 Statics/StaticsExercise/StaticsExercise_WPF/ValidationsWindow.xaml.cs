using StaticsExercise_Models;
using System.Windows;

namespace StaticsExercise_WPF
{
    /// <summary>
    /// Interaction logic for ValidationsWindow.xaml.
    /// Allows users to validate social security numbers.
    /// </summary>
    public partial class ValidationsWindow : Window
    {
        public ValidationsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Verify Social Security Number" button click event.
        /// Validates the entered social security number using the static Validations class.
        /// </summary>
        private void btnSocialSecurityNumber_Click(object sender, RoutedEventArgs e)
        {
            string socialSecurityNumber = txtSocialSecurityNumber.Text;

            // Validate the social security number
            bool isValid = Validations.IsSocialSecurityNumberValid(socialSecurityNumber);

            // Display the result
            lblResult.Text = isValid ? "This is a valid social security number" : "This is not a valid social security number";
        }
    }
}