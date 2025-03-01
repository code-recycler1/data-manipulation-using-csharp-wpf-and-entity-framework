using EF_CUD_Exercise_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_CUD_Exercise_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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

        private void btnNavigationProperties_Click(object sender, RoutedEventArgs e)
        {
            NavigationPropertiesWindow navigationProperties = new NavigationPropertiesWindow();
            navigationProperties.Show();
        }

        private void btnCudOperations_Click(object sender, RoutedEventArgs e)
        {
            CUDWindow cudWindow = new CUDWindow();
            cudWindow.Show();
        }
    }
}
