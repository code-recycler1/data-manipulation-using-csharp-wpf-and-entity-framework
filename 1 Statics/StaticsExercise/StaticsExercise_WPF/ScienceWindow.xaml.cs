using StaticsExercise_Models;
using System.Windows;

namespace StaticsExercise_WPF
{
    /// <summary>
    /// Interaction logic for ScienceWindow.xaml.
    /// Allows users to perform scientific calculations using static methods.
    /// </summary>
    public partial class ScienceWindow : Window
    {
        public ScienceWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Calculate Gravity Force" button click event.
        /// Calculates the gravitational force using the static ScientificFormulas class.
        /// </summary>
        private void btnCalculateGravity_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtGravityMass.Text, out double mass))
            {
                lblResult.Text = "The gravitational force is: " + ScientificFormulas.GravityForce(mass) + "N";
            }
            else
            {
                lblResult.Text = "The mass for gravity force is not numeric";
            }
        }

        /// <summary>
        /// Handles the "Calculate Work" button click event.
        /// Calculates the work using the static ScientificFormulas class.
        /// </summary>
        private void btnCalculateWork_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtWorkForce.Text, out double force) && double.TryParse(txtWorkDisplacement.Text, out double displacement))
            {
                lblResult.Text = "The work is: " + ScientificFormulas.Work(force, displacement) + "J";
            }
            else
            {
                lblResult.Text = "The force or displacement for work is not numeric";
            }
        }

        /// <summary>
        /// Handles the "Calculate Power" button click event.
        /// Calculates the power using the static ScientificFormulas class.
        /// </summary>
        private void btnCalculatePower_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtPowerWork.Text, out double work) && int.TryParse(txtPowerDuration.Text, out int duration))
            {
                lblResult.Text = "The power is: " + ScientificFormulas.Power(work, duration) + "W";
            }
            else
            {
                lblResult.Text = "The work or duration for power is not numeric";
            }
        }

        /// <summary>
        /// Handles the "Calculate Gravitational Potential Energy" button click event.
        /// Calculates the gravitational potential energy using the static ScientificFormulas class.
        /// </summary>
        private void btnCalculateGravEnergy_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtGravEnergyMass.Text, out double mass) && int.TryParse(txtGravEnergyHeight.Text, out int heightInMeters))
            {
                lblResult.Text = "The gravitational potential energy is: " + ScientificFormulas.GravitationalPotentialEnergy(mass, heightInMeters) + "J";
            }
            else
            {
                lblResult.Text = "The mass or height for gravitational potential energy is not numeric";
            }
        }
    }
}