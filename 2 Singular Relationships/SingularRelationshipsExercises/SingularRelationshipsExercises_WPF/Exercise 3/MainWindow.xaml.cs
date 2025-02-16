using SingularRelationshipsExercises_Models.Exercise_3;
using System;
using System.Windows;
using System.Windows.Threading;

namespace SingularRelationshipsExercises_WPF.Exercise_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// This class represents the main UI for controlling a tank fueling mechanism.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Instance of the fueling mechanism that manages fuel requests.
        /// </summary>
        private TankMechanism fueling = new TankMechanism();

        /// <summary>
        /// Timer to periodically update the fueling status in the UI.
        /// </summary>
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        /// <summary>
        /// Initializes the MainWindow and its components.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Configures and starts a timer to update the fueling status.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ConfigureTimer();
        }

        /// <summary>
        /// Starts the fueling process when the user enters a valid amount.
        /// Displays an error message if the input is not numeric.
        /// </summary>
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtAmountLiters.Text, out int amount))
            {
                fueling.RequestedAmount = amount;
                fueling.Start();
            }
            else
            {
                MessageBox.Show("Amount must be numeric!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Updates the UI with the current fueling status.
        /// </summary>
        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            txtStatus.Text = fueling.GetStatus();
        }

        /// <summary>
        /// Timer tick event handler.
        /// Updates the fueling status in the UI every second.
        /// </summary>
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            txtStatus.Text = fueling.GetStatus();
        }

        /// <summary>
        /// Configures and starts a timer to update the fueling status at regular intervals.
        /// </summary>
        private void ConfigureTimer()
        {
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Start();
        }
    }
}