using NETEntityFrameworkExample_DAL;
using System.Windows;

namespace NETEntityFrameworkExample_WPF
{
    /// <summary>
    /// Interaction logic for the MainWindow. This class provides functionality 
    /// to retrieve and display employee data from the database.
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
        /// Retrieves all employees from the database and displays them in the data grid.
        /// </summary>
        private void btnAllEmployees_Click(object sender, RoutedEventArgs e)
        {
            dataEmployees.ItemsSource = DatabaseOperations.GetEmployees();
        }

        /// <summary>
        /// Retrieves employees by job title and displays them in the data grid.
        /// </summary>
        /// <remarks>
        /// The job title is taken from the <see cref="txtJobTitle"/> text box.
        /// </remarks>
        private void btnFetchEmployeesByJobTitle_Click(object sender, RoutedEventArgs e)
        {
            dataEmployees.ItemsSource = DatabaseOperations.GetEmployeesByJobTitle(txtJobTitle.Text);
        }

        /// <summary>
        /// Retrieves employees by last name and first name and displays them in the data grid.
        /// </summary>
        /// <remarks>
        /// The last name and first name are taken from <see cref="txtLastName"/> and <see cref="txtFirstName"/> text boxes.
        /// </remarks>
        private void btnFetchEmployeeByFullName_Click(object sender, RoutedEventArgs e)
        {
            dataEmployees.ItemsSource = DatabaseOperations.GetEmployeesByLastNameAndFirstName(txtLastName.Text, txtFirstName.Text);
        }

        /// <summary>
        /// Retrieves an employee by their unique employee ID and displays their name in a label.
        /// </summary>
        /// <remarks>
        /// The employee ID is taken from the <see cref="txtEmployeeID"/> text box.
        /// </remarks>
        private void btnFetchEmployeeByEmployeeID_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtEmployeeID.Text, out int employeeID))
            {
                Employee employee = DatabaseOperations.GetEmployeeByID(employeeID);
                if (employee != null)
                {
                    lblEmployee.Content = $"{employee.FirstName} {employee.LastName}";
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Employee Not Found", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid employee ID.", "Invalid Employee ID", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
