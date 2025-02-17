using System.Windows;

namespace MultipleRelationshipsExercises_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExercise_1_Modelling_Agency_Click(object sender, RoutedEventArgs e)
        {
            ModellingAgencyWindow modellingAgency = new ModellingAgencyWindow();
            modellingAgency.Show();
        }

        private void btnExercise_2_Student_Administration_Click(object sender, RoutedEventArgs e)
        {
            StudentAdministrationWindow studentAdministration = new StudentAdministrationWindow();
            studentAdministration.Show();
        }

        private void btnExercise_3_Printer_Management_Click(object sender, RoutedEventArgs e)
        {
            PrinterManagementWindow printerManagement = new PrinterManagementWindow();
            printerManagement.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
