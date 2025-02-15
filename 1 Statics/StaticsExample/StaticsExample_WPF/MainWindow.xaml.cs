using StaticsExample_DAL;
using StaticsExample_Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace StaticsExample_WPF
{
    /// <summary>
    /// Main window for the application. Demonstrates the use of static classes and methods.
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileOperations _fileOperations = new FileOperations();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Read File" button click event.
        /// Reads amounts from a file, converts them, and displays the results.
        /// </summary>
        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Text = ""; // Clear previous results
            double total = 0;

            try
            {
                // Read amounts from file
                List<double> amountList = _fileOperations.ReadFile("doc\\amounts.txt");

                // Process each amount
                foreach (var item in amountList)
                {
                    double conversion = Conversions.ConvertAmount(item); // Convert amount based on currency
                    total += conversion; // Accumulate total
                    lblResult.Text += $"{PersonalSettings.Currency} {conversion:0.00}{Environment.NewLine}"; // Display converted amount
                }

                // Display total
                lblResult.Text += $"{Environment.NewLine}Total to be paid: {Conversions.ConvertNumericToCurrency(total)}{Environment.NewLine}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the "Settings" button click event.
        /// Opens the settings window to configure output folder and currency.
        /// </summary>
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog(); // Use ShowDialog to make it modal
        }
    }
}