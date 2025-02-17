using MultipleRelationshipsExercises_Models.Exercise_2;
using System;
using System.Windows;

namespace MultipleRelationshipsExercises_WPF
{
    /// <summary>
    /// Interaction logic for StudentAdministrationWindow.xaml
    /// </summary>
    public partial class StudentAdministrationWindow : Window
    {
        public StudentAdministrationWindow()
        {
            InitializeComponent();
        }

        private ClassGroup currentClass = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbStudent.IsChecked = true;
        }

        private void btnCreateClass_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                currentClass = new ClassGroup(txtClassName.Text);
            }
            else
            {
                MessageBox.Show("Class name is required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rbStudent_Checked(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void rbDormStudent_Checked(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student;
            string errorMessage = ValidateInputs();

            try
            {
                if (string.IsNullOrWhiteSpace(errorMessage))
                {
                    if (rbStudent.IsChecked == true)
                    {
                        student = new Student(txtStudentNumber.Text, txtStudentName.Text);
                    }
                    else
                    {
                        student = new DormStudent(txtStudentNumber.Text, txtStudentName.Text, txtDormManager.Text, txtDormAddress.Text);
                    }
                    currentClass.AddStudent(student);
                    DisplayClassData();
                    ResetFields();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cbShowDetails_Click(object sender, RoutedEventArgs e)
        {
            DisplayClassData();
        }

        private string ValidateInputs()
        {
            if (currentClass == null)
            {
                return "Please create a class first!";
            }

            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                errorMessage += "Student number is required\n";
            }
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                errorMessage += "Student name is required\n";
            }
            if (rbDormStudent.IsChecked == true)
            {
                if (string.IsNullOrWhiteSpace(txtDormManager.Text))
                {
                    errorMessage += "Dorm manager is required\n";
                }
                if (string.IsNullOrWhiteSpace(txtDormAddress.Text))
                {
                    errorMessage += "Dorm address is required\n";
                }
            }

            return errorMessage;
        }

        private void DisplayClassData()
        {
            txtDetails.Text = cbShowDetails.IsChecked == true ? currentClass?.GetDetailedList() : currentClass?.GetList();
        }

        private void ResetFields()
        {
            Visibility visibility = rbStudent.IsChecked == true ? Visibility.Hidden : Visibility.Visible;
            txtDormAddress.Visibility = visibility;
            txtDormManager.Visibility = visibility;

            txtStudentName.Clear();
            txtStudentNumber.Clear();
            txtDormManager.Clear();
            txtDormAddress.Clear();
        }
    }
}
