using NETEntityFrameworkExercise_DAL;
using System.Windows;

namespace NETEntityFrameworkExercise_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.
    /// Handles user interactions related to stores and employees.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler that loads available jobs into the combo box when the window is loaded.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data associated with the event.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbJobs.ItemsSource = DatabaseOperations.GetJobs();
        }

        /// <summary>
        /// Searches for stores by name and displays the results in the data grid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data associated with the event.</param>
        private void btnSearchStores_Click(object sender, RoutedEventArgs e)
        {
            datagridStores.ItemsSource = DatabaseOperations.GetStoresByName(txtStoreName.Text);
        }

        /// <summary>
        /// Searches for employees by selected job and displays the results in the data grid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data associated with the event.</param>
        private void btnSearchEmployees_Click(object sender, RoutedEventArgs e)
        {
            if (cmbJobs.SelectedItem is Job job)
            {
                datagridStores.ItemsSource = DatabaseOperations.GetEmployeesByJobID(job.JobID);
            }
            else
            {
                MessageBox.Show("First select a job!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
