using MultipleRelationshipsExercises_Models.Exercise_3;
using System.Windows;

namespace MultipleRelationshipsExercises_WPF
{
    /// <summary>
    /// Interaction logic for PrinterManagementWindow.xaml
    /// </summary>
    public partial class PrinterManagementWindow : Window
    {
        public PrinterManagementWindow()
        {
            InitializeComponent();
        }

        private Computer _computer = new Computer();
        private Printer _printer1 = new Printer("Printer 1");
        private Printer _printer2 = new Printer("Printer 2");
        private Printer _printer3 = new Printer("Printer 3");
        private Printer _printer4 = new Printer("Printer 4");

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _computer.AddPrinter(_printer1);
            _computer.AddPrinter(_printer2);
            _computer.AddPrinter(_printer3);
            _computer.AddPrinter(_printer4);
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            Printer printer = _computer.Print();
            if (printer != null)
            {
                UpdateUI();
            }
            else
            {
                MessageBox.Show("No printer available.");
            }
        }

        private void btnResetPrinter1_Click(object sender, RoutedEventArgs e)
        {
            _printer1.Reset();
            UpdateUI();
        }

        private void btnResetPrinter2_Click(object sender, RoutedEventArgs e)
        {
            _printer2.Reset();
            UpdateUI();
        }

        private void btnResetPrinter3_Click(object sender, RoutedEventArgs e)
        {
            _printer3.Reset();
            UpdateUI();
        }

        private void btnResetPrinter4_Click(object sender, RoutedEventArgs e)
        {
            _printer4.Reset();
            UpdateUI();
        }

        private void UpdateUI()
        {
            btnPrinter1.IsChecked = _printer1.IsBusy;
            btnPrinter1.ToolTip = _printer1.ToString();
            btnPrinter2.IsChecked = _printer2.IsBusy;
            btnPrinter2.ToolTip = _printer2.ToString();
            btnPrinter3.IsChecked = _printer3.IsBusy;
            btnPrinter3.ToolTip = _printer3.ToString();
            btnPrinter4.IsChecked = _printer4.IsBusy;
            btnPrinter4.ToolTip = _printer4.ToString();
        }
    }
}
