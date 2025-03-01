using EF_CUD_Exercise_DAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EF_CUD_Exercise_WPF
{
    /// <summary>
    /// Interaction logic for CUDWindow.xaml
    /// </summary>
    public partial class CUDWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CUDWindow"/> class.
        /// </summary>
        public CUDWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.  
        /// Populates the publishers and jobs combo boxes with data from the database.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPublishers.ItemsSource = DatabaseOperations.GetPublishers();
            cmbPublishers.DisplayMemberPath = "Name";
            cmbJobs.ItemsSource = DatabaseOperations.GetJobs();
            cmbJobs.DisplayMemberPath = "JobDescription";
        }

        /// <summary>
        /// Handles the selection change event for the publishers combo box.  
        /// Loads employees associated with the selected publisher.
        /// </summary>
        private void cmbPublishers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string errorMessage = Validate("cmbPublishers");

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Publisher publisher = cmbPublishers.SelectedItem as Publisher;
                datagridEmployees.ItemsSource = DatabaseOperations.GetEmployeesByPublisherID(publisher.PublisherID);
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Handles the selection change event for the employees data grid.  
        /// Populates the input fields with the selected employee's data.
        /// </summary>
        private void datagridEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagridEmployees.SelectedItem is Employee employee)
            {
                txtEmployeeID.Text = employee.EmployeeID;
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                cmbJobs.SelectedItem = employee.Job;
                txtEmployeeID.IsEnabled = false;
            }
        }

        /// <summary>
        /// Deletes the selected employee from the database.
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = Validate("Employee");

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Employee employee = datagridEmployees.SelectedItem as Employee;
                string publisherID = employee.PublisherID;

                int result = DatabaseOperations.DeleteEmployee(employee);
                if (result > 0)
                {
                    datagridEmployees.ItemsSource = DatabaseOperations.GetEmployeesByPublisherID(publisherID);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Employee was not deleted!");
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Updates the selected employee's information in the database.
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = Validate("Employee");
            errorMessage += Validate("cmbJobs");

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Job job = cmbJobs.SelectedItem as Job;
                Employee employee = datagridEmployees.SelectedItem as Employee;

                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.JobID = job.JobID;
                employee.Job = job;

                if (employee.IsValid())
                {
                    int result = DatabaseOperations.UpdateEmployee(employee);
                    if (result > 0)
                    {
                        datagridEmployees.ItemsSource = DatabaseOperations.GetEmployeesByPublisherID(employee.PublisherID);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Employee was not updated!");
                    }
                }
                else
                {
                    MessageBox.Show(employee.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Adds a new employee to the database.
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = Validate("cmbPublishers");
            errorMessage += Validate("cmbJobs");

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                Job job = cmbJobs.SelectedItem as Job;
                Publisher publisher = cmbPublishers.SelectedItem as Publisher;

                Employee employee = new Employee
                {
                    EmployeeID = txtEmployeeID.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    HireDate = DateTime.Now,
                    JobID = job.JobID,
                    PublisherID = publisher.PublisherID
                };

                if (employee.IsValid())
                {
                    int result = DatabaseOperations.AddEmployee(employee);
                    if (result > 0)
                    {
                        datagridEmployees.ItemsSource = DatabaseOperations.GetEmployeesByPublisherID(publisher.PublisherID);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Employee was not added!");
                    }
                }
                else
                {
                    MessageBox.Show(employee.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Cancels the current operation and clears all input fields.
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Clears all input fields and resets selections.
        /// </summary>
        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbJobs.SelectedIndex = -1;
            txtEmployeeID.IsEnabled = true;
            datagridEmployees.SelectedIndex = -1;
        }

        /// <summary>
        /// Validates required fields based on the specified column name.
        /// </summary>
        /// <param name="columnName">The name of the column to validate.</param>
        /// <returns>A validation error message if the field is invalid; otherwise, an empty string.</returns>
        private string Validate(string columnName)
        {
            if (columnName == "cmbPublishers" && cmbPublishers.SelectedItem == null)
            {
                return "Select a publisher!" + Environment.NewLine;
            }
            if (columnName == "cmbJobs" && cmbJobs.SelectedItem == null)
            {
                return "Select a job!" + Environment.NewLine;
            }
            if (columnName == "Employee" && datagridEmployees.SelectedItem == null)
            {
                return "Select an employee!" + Environment.NewLine;
            }
            return "";
        }
    }
}
