using MultipleRelationshipsExercises_Models.Exercise_1;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MultipleRelationshipsExercises_WPF
{
    /// <summary>
    /// Interaction logic for ModellingAgencyWindow.xaml
    /// </summary>
    public partial class ModellingAgencyWindow : Window
    {
        public ModellingAgencyWindow()
        {
            InitializeComponent();
        }

        List<ModellingAgency> modellingAgencies = new List<ModellingAgency>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnAddModel.IsEnabled = false;
            lbAgencies.ItemsSource = modellingAgencies;
        }

        private void btnCreateAgency_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModellingAgency agency = new ModellingAgency(txtAgencyName.Text);
                modellingAgencies.Add(agency);
                lbAgencies.Items.Refresh();
                btnAddModel.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddModel_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = ValidateInput();

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                try
                {
                    ModellingAgency agency = lbAgencies.SelectedItem as ModellingAgency;
                    agency.Add(txtName.Text, double.Parse(txtWrist.Text), double.Parse(txtHeight.Text));
                    txtName.Text = "";
                    txtWrist.Text = "";
                    txtHeight.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                lbAgencies.Items.Refresh();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnShowSlimModels_Click(object sender, RoutedEventArgs e)
        {
            if (lbAgencies.SelectedItem is ModellingAgency agency)
            {
                MessageBox.Show(agency.PrintSlimModels(), "Slim Models", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a modeling agency first!");
            }
        }

        private string ValidateInput()
        {
            string errorMessage = "";
            if (lbAgencies.SelectedItem == null)
            {
                errorMessage += "Please select a modeling agency first!";
            }
            if (!double.TryParse(txtHeight.Text, out double height))
            {
                errorMessage += "- Model height must be a numeric value" + Environment.NewLine;
            }
            if (!double.TryParse(txtWrist.Text, out double wrist))
            {
                errorMessage += "- Wrist circumference must be a numeric value" + Environment.NewLine;
            }
            return errorMessage;
        }
    }
}
