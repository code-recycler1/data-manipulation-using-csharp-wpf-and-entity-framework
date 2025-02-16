using System.Windows;

namespace StaticsExercise_WPF
{
    /// <summary>
    /// Main window for the application. Demonstrates the use of static classes and methods.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Scientific Formulas" button click event.
        /// Opens the ScienceWindow to perform scientific calculations.
        /// </summary>
        private void btnScience_Click(object sender, RoutedEventArgs e)
        {
            ScienceWindow scienceWindow = new ScienceWindow();
            scienceWindow.Show();
        }

        /// <summary>
        /// Handles the "Validations" button click event.
        /// Opens the ValidationsWindow to validate social security numbers.
        /// </summary>
        private void btnValidations_Click(object sender, RoutedEventArgs e)
        {
            ValidationsWindow validationsWindow = new ValidationsWindow();
            validationsWindow.Show();
        }
    }
}