using AbstractClassExercise_Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AbstractClassExercise_WPF
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
        /// List to store the created companies.
        /// </summary>
        private List<Company> companies = new List<Company>();

        /// <summary>
        /// Handles the window's Loaded event.
        /// Initializes UI elements and sets the data source for the companies combo box.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbCommissionWorker.IsChecked = true;
            cmbCompanies.ItemsSource = companies;
        }

        /// <summary>
        /// Handles the click event for the "Create Company" button.
        /// Creates a new company and adds it to the list if valid.
        /// </summary>
        private void btnCreateCompany_Click(object sender, RoutedEventArgs e)
        {
            Company company = new Company(txtCompany.Text);

            if (company.IsValid())
            {
                if (!companies.Contains(company))
                {
                    companies.Add(company);
                    cmbCompanies.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("This company already exists!", "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(company.ErrorMessages, "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the Checked event for the "Commission Worker" radio button.
        /// Clears input fields and makes the commission field visible.
        /// </summary>
        private void rbCommissionWorker_Checked(object sender, RoutedEventArgs e)
        {
            ClearInputs();
            txtCommission.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Checked event for the "Piece Worker" radio button.
        /// Clears input fields.
        /// </summary>
        private void rbPieceWorker_Checked(object sender, RoutedEventArgs e)
        {
            ClearInputs();
        }

        /// <summary>
        /// Handles the Checked event for the "Hourly Worker" radio button.
        /// Clears input fields.
        /// </summary>
        private void rbHourlyWorker_Checked(object sender, RoutedEventArgs e)
        {
            ClearInputs();
        }

        /// <summary>
        /// Handles the click event for the "Add Employee" button.
        /// Creates a new employee and adds them to the selected company if valid.
        /// </summary>
        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = null;
            string errorMessages = ValidateInputs();

            if (string.IsNullOrWhiteSpace(errorMessages))
            {
                Company selectedCompany = cmbCompanies.SelectedItem as Company;
                double.TryParse(txtSalary.Text, out double salary);
                double.TryParse(txtCommission.Text, out double commission);
                int.TryParse(txtExtra.Text, out int extra);

                if (rbCommissionWorker.IsChecked == true)
                {
                    employee = new CommissionWorker(txtLastName.Text, txtFirstName.Text, salary, commission, extra);
                }
                else if (rbPieceWorker.IsChecked == true)
                {
                    employee = new PieceWorker(txtLastName.Text, txtFirstName.Text, salary, extra);
                }
                else if (rbHourlyWorker.IsChecked == true)
                {
                    employee = new HourlyWorker(txtLastName.Text, txtFirstName.Text, salary, extra);
                }

                if (employee.IsValid())
                {
                    if (selectedCompany.AddEmployee(employee))
                    {
                        lbEmployees.Items.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("This employee already exists!", "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show(employee.ErrorMessages, "Object Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessages, "Error Messages", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the selection change event for the company combo box.
        /// Updates the employee list box based on the selected company.
        /// </summary>
        private void cmbCompanies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCompanies.SelectedItem is Company selectedCompany)
            {
                lbEmployees.ItemsSource = selectedCompany.Employees;
            }
        }

        /// <summary>
        /// Validates user input fields before adding an employee.
        /// </summary>
        /// <returns>An error message string if validation fails; otherwise, an empty string.</returns>
        private string ValidateInputs()
        {
            string errorMessages = "";

            if (cmbCompanies.SelectedItem == null)
            {
                errorMessages += "Please select a company first!" + Environment.NewLine;
            }

            if (!double.TryParse(txtSalary.Text, out double salary))
            {
                errorMessages += "Salary is a required NUMERIC field!" + Environment.NewLine;
            }

            if (!int.TryParse(txtExtra.Text, out int extra))
            {
                if (rbCommissionWorker.IsChecked == true)
                {
                    errorMessages += "Quantity is a required NUMERIC field!" + Environment.NewLine;
                }
                else if (rbPieceWorker.IsChecked == true)
                {
                    errorMessages += "Number of Units is a required NUMERIC field!" + Environment.NewLine;
                }
                else if (rbHourlyWorker.IsChecked == true)
                {
                    errorMessages += "Number of Hours is a required NUMERIC field!" + Environment.NewLine;
                }
            }

            if (!double.TryParse(txtCommission.Text, out double commission) && rbCommissionWorker.IsChecked == true)
            {
                errorMessages += "Commission is a required NUMERIC field!" + Environment.NewLine;
            }

            return errorMessages;
        }

        /// <summary>
        /// Clears all input fields and hides the commission field.
        /// </summary>
        private void ClearInputs()
        {
            txtCommission.Visibility = Visibility.Hidden;
            txtExtra.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSalary.Text = "";
            txtCommission.Text = "";
        }
    }
}
