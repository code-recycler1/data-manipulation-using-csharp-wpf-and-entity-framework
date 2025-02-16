namespace SingularRelationshipsExercises_Models.Exercise_2
{
    /// <summary>
    /// Represents a Programmable Logic Controller (PLC) that manages lights and heating in a home.
    /// </summary>
    public class PLC
    {
        /// <summary>
        /// Gets the living room lights.
        /// </summary>
        public Lights LivingRoomLights { get; private set; }

        /// <summary>
        /// Gets the kitchen lights.
        /// </summary>
        public Lights KitchenLights { get; private set; }

        /// <summary>
        /// Gets the heating system.
        /// </summary>
        public Heating Heating { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PLC"/> class with specified lights and heating.
        /// </summary>
        /// <param name="livingRoomLights">The lights in the living room.</param>
        /// <param name="kitchenLights">The lights in the kitchen.</param>
        /// <param name="heating">The heating system.</param>
        public PLC(Lights livingRoomLights, Lights kitchenLights, Heating heating)
        {
            LivingRoomLights = livingRoomLights;
            KitchenLights = kitchenLights;
            Heating = heating;
        }

        /// <summary>
        /// Adjusts the heating temperature to a specified value.
        /// </summary>
        /// <param name="degrees">The temperature to set.</param>
        public void AdjustTemperature(double degrees)
        {
            Heating.Temperature = degrees;
        }

        /// <summary>
        /// Sets the heating system to "Away Mode" with a predefined temperature of 18°C.
        /// </summary>
        public void SetHeatingToAwayMode()
        {
            Heating.Temperature = 18;
        }

        /// <summary>
        /// Sets the heating system to "Home Mode" with a predefined temperature of 21°C.
        /// </summary>
        public void SetHeatingToHomeMode()
        {
            Heating.Temperature = 21;
        }

        /// <summary>
        /// Turns on the living room lights.
        /// </summary>
        public void TurnOnLivingRoomLights()
        {
            LivingRoomLights.Power = true;
        }

        /// <summary>
        /// Turns off the living room lights.
        /// </summary>
        public void TurnOffLivingRoomLights()
        {
            LivingRoomLights.Power = false;
        }

        /// <summary>
        /// Turns on the kitchen lights.
        /// </summary>
        public void TurnOnKitchenLights()
        {
            KitchenLights.Power = true;
        }

        /// <summary>
        /// Turns off the kitchen lights.
        /// </summary>
        public void TurnOffKitchenLights()
        {
            KitchenLights.Power = false;
        }
    }
}
