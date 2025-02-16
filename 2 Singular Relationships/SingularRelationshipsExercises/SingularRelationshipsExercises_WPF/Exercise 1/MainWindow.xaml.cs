using SingularRelationshipsExercises_DAL;
using SingularRelationshipsExercises_Models.Exercise_1;
using System.Collections.Generic;
using System.Windows;

namespace SingularRelationshipsExercises_WPF.Exercise_1
{
    /// <summary>
    /// Interaction logic for the MainWindow.xaml.
    /// Represents the main window for managing car entries.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// A list containing all added cars.
        /// </summary>
        private List<Car> carList = new List<Car>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Initializes the UI elements with data from external files.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the loaded event.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbCars.ItemsSource = carList;
            cmbBrands.ItemsSource = FileOperations.ReadBrandsFile("doc\\brands.txt");
            cmbEngines.ItemsSource = FileOperations.ReadEnginesFile("doc\\engines.txt");
        }

        /// <summary>
        /// Opens the EngineWindow to allow the user to add a new engine.
        /// Refreshes the engine list after adding.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the button click event.</param>
        private void btnAddEngine_Click(object sender, RoutedEventArgs e)
        {
            EngineWindow engineWindow = new EngineWindow();
            engineWindow.ShowDialog();

            // Refresh engines list after a new engine is added
            cmbEngines.ItemsSource = FileOperations.ReadEnginesFile("doc\\engines.txt");
        }

        /// <summary>
        /// Handles the Add Car button click event.
        /// Validates input and adds a new car to the list if valid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the button click event.</param>
        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            lblErrors.Content = "";
            string errorMessage = ValidateInput();

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Engine selectedEngine = cmbEngines.SelectedItem as Engine;
                string selectedBrand = cmbBrands.SelectedItem as string;
                Car car = new Car(selectedBrand, txtChassisNumber.Text, selectedEngine);

                // Ensure the car is not duplicated based on chassis number
                if (!carList.Contains(car))
                {
                    carList.Add(car);
                    lbCars.Items.Refresh();
                }
                else
                {
                    lblErrors.Content = "This car has already been added!";
                }
            }
            else
            {
                lblErrors.Content = errorMessage;
            }
        }

        /// <summary>
        /// Validates the user input for adding a new car.
        /// Ensures a brand, engine, and chassis number are selected/provided.
        /// </summary>
        /// <returns>A string containing error messages, or an empty string if valid.</returns>
        private string ValidateInput()
        {
            string errorMessage = "";

            if (!(cmbBrands.SelectedItem is string))
            {
                errorMessage += "Select a brand!\n";
            }

            if (!(cmbEngines.SelectedItem is Engine))
            {
                errorMessage += "Select an engine!\n";
            }

            if (string.IsNullOrWhiteSpace(txtChassisNumber.Text))
            {
                errorMessage += "Chassis number is required!\n";
            }

            return errorMessage;
        }
    }
}