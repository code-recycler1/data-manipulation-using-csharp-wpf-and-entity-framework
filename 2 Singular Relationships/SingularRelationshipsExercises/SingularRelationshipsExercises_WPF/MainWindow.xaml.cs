using System.Windows;

namespace SingularRelationshipsExercises_WPF
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

        private void btnExercise_1_Car_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1.MainWindow car = new Exercise_1.MainWindow();
            car.Show();
        }

        private void btnExercise_2_Home_Automation_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2.MainWindow homeAutomation = new Exercise_2.MainWindow();
            homeAutomation.Show();
        }

        private void btnExercise_3_Gas_Pump_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3.MainWindow gasPump = new Exercise_3.MainWindow();
            gasPump.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
