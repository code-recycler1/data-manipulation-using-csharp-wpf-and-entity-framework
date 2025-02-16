using SingularRelationshipsExercises_DAL;
using SingularRelationshipsExercises_Models.Exercise_1;
using System;
using System.Windows;

namespace SingularRelationshipsExercises_WPF.Exercise_1
{
    /// <summary>
    /// Interaction logic for EngineWindow.xaml.
    /// This window allows the user to add a new engine.
    /// </summary>
    public partial class EngineWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineWindow"/> class.
        /// </summary>
        public EngineWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Loads the list of available engines from a file and displays them in the ListBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the loaded event.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbEngines.ItemsSource = FileOperations.ReadEnginesFile("doc\\engines.txt");
        }

        /// <summary>
        /// Handles the Add Engine button click event.
        /// Validates input, adds a new engine to the file, and refreshes the engine list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the button click event.</param>
        private void btnAddEngine_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = ValidateInput();

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                // Create a new engine using user input
                Engine engine = new Engine(int.Parse(txtCylinderCapacity.Text), int.Parse(txtHP.Text));

                // Save the engine to file
                FileOperations.AddEngine("doc\\engines.txt", engine);

                // Refresh engine list to display the newly added engine
                lbEngines.ItemsSource = FileOperations.ReadEnginesFile("doc\\engines.txt");

                // Clear input fields after successful addition
                txtCylinderCapacity.Text = "";
                txtHP.Text = "";
            }
            else
            {
                lblErrors.Content = errorMessage;
            }
        }

        /// <summary>
        /// Validates user input to ensure the cylinder capacity and horsepower are numeric values.
        /// </summary>
        /// <returns>A string containing error messages, or an empty string if valid.</returns>
        private string ValidateInput()
        {
            string errorMessage = "";

            if (!int.TryParse(txtCylinderCapacity.Text, out int cylinderCapacity))
            {
                errorMessage += "Cylinder capacity is a required NUMERIC field!" + Environment.NewLine;
            }

            if (!int.TryParse(txtHP.Text, out int horsepower))
            {
                errorMessage += "Horsepower is a required NUMERIC field!" + Environment.NewLine;
            }

            return errorMessage;
        }
    }
}