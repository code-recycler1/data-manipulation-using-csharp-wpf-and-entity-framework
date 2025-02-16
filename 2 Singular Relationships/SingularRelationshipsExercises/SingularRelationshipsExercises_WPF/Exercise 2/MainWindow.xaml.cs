using SingularRelationshipsExercises_Models.Exercise_2;
using System.Windows;

namespace SingularRelationshipsExercises_WPF.Exercise_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// This class represents the main UI for a home automation system, 
    /// allowing users to control lights and heating.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Instances of home automation components.
        private Lights kitchenLights = new Lights();
        private Lights livingRoomLights = new Lights();
        private Heating heating = new Heating();
        private PLC automationSystem = null;

        /// <summary>
        /// Initializes the MainWindow and its components.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Window Loaded event.
        /// Initializes the automation system and updates the UI with the current heating temperature.
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            automationSystem = new PLC(livingRoomLights, kitchenLights, heating);
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }

        /// <summary>
        /// Toggles the power state of the kitchen light.
        /// </summary>
        private void btnKitchenLight_Click(object sender, RoutedEventArgs e)
        {
            kitchenLights.Power = !kitchenLights.Power;
            btnKitchenLight.IsChecked = kitchenLights.Power;
        }

        /// <summary>
        /// Toggles the power state of the living room light.
        /// </summary>
        private void btnLivingRoomLight_Click(object sender, RoutedEventArgs e)
        {
            livingRoomLights.Power = !livingRoomLights.Power;
            btnLivingRoomLight.IsChecked = livingRoomLights.Power;
        }

        /// <summary>
        /// Decreases the heating temperature by 1 degree.
        /// </summary>
        private void btnDecreaseTemperature_Click(object sender, RoutedEventArgs e)
        {
            heating.Temperature -= 1;
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }

        /// <summary>
        /// Increases the heating temperature by 1 degree.
        /// </summary>
        private void btnIncreaseTemperature_Click(object sender, RoutedEventArgs e)
        {
            heating.Temperature += 1;
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }

        /// <summary>
        /// Toggles the power state of the heating system.
        /// </summary>
        private void btnHeating_Click(object sender, RoutedEventArgs e)
        {
            heating.Power = btnHeating.IsChecked == true;
        }

        /// <summary>
        /// Turns on the kitchen light using the automation system.
        /// </summary>
        private void btnAutomationKitchenLightOn_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.TurnOnKitchenLights();
            btnKitchenLight.IsChecked = kitchenLights.Power;
        }

        /// <summary>
        /// Turns off the kitchen light using the automation system.
        /// </summary>
        private void btnAutomationKitchenLightOff_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.TurnOffKitchenLights();
            btnKitchenLight.IsChecked = kitchenLights.Power;
        }

        /// <summary>
        /// Turns on the living room light using the automation system.
        /// </summary>
        private void btnAutomationLivingRoomLightOn_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.TurnOnLivingRoomLights();
            btnLivingRoomLight.IsChecked = livingRoomLights.Power;
        }

        /// <summary>
        /// Turns off the living room light using the automation system.
        /// </summary>
        private void btnAutomationLivingRoomLightOff_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.TurnOffLivingRoomLights();
            btnLivingRoomLight.IsChecked = livingRoomLights.Power;
        }

        /// <summary>
        /// Sets the heating system to "Home Mode" with a predefined temperature.
        /// </summary>
        private void btnAutomationHeatingHomeMode_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.SetHeatingToHomeMode();
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }

        /// <summary>
        /// Sets the heating system to "Away Mode" with a predefined temperature.
        /// </summary>
        private void btnAutomationHeatingAwayMode_Click(object sender, RoutedEventArgs e)
        {
            automationSystem.SetHeatingToAwayMode();
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }

        /// <summary>
        /// Sets the heating temperature to a user-specified value.
        /// </summary>
        private void btnAutomationSetTemperature_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtAutomationTempHeating.Text, out double temp))
            {
                automationSystem.AdjustTemperature(temp);
            }
            txtElementHeatingTemp.Text = heating.Temperature.ToString();
        }
    }
}
