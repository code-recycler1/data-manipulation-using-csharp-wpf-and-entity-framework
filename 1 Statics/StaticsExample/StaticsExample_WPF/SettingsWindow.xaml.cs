using StaticsExample_Models;
using System.IO;
using System.Windows;

namespace StaticsExample_WPF
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml.
    /// Allows users to configure the output folder and currency.
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            // Load current settings into the UI
            txtOutputFolder.Text = PersonalSettings.OutputFolder;
            radEuro.IsChecked = PersonalSettings.Currency == "€";
            radDollar.IsChecked = PersonalSettings.Currency == "$";
        }

        /// <summary>
        /// Handles the "Adjust Settings" button click event.
        /// Validates and saves the output folder and currency settings.
        /// </summary>
        private void btnAdjustSettings_Click(object sender, RoutedEventArgs e)
        {
            // Validate and save the output folder
            if (string.IsNullOrWhiteSpace(txtOutputFolder.Text))
            {
                PersonalSettings.OutputFolder = ""; // Default to bin\debug folder
            }
            else if (Directory.Exists(txtOutputFolder.Text))
            {
                PersonalSettings.OutputFolder = txtOutputFolder.Text;
            }
            else
            {
                lblResult.Content = "Folder does not exist! Settings will not be saved.";
                return;
            }

            // Save the selected currency
            PersonalSettings.Currency = radEuro.IsChecked == true ? "€" : "$";

            // Notify the user that settings have been saved
            lblResult.Content = "Settings have been saved!";
        }
    }
}