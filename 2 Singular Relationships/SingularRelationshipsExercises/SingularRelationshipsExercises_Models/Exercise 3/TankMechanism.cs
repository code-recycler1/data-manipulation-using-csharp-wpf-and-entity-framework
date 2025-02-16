namespace SingularRelationshipsExercises_Models.Exercise_3
{
    /// <summary>
    /// Represents the tank mechanism responsible for managing fuel requests and controlling the pump.
    /// </summary>
    public class TankMechanism
    {
        /// <summary>
        /// The amount of fuel (in liters) requested by the user.
        /// </summary>
        public int RequestedAmount { get; set; }

        /// <summary>
        /// The pump instance used for dispensing fuel.
        /// </summary>
        public Pump Pump { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TankMechanism"/> class.
        /// Sets the requested fuel amount to zero and creates a new pump instance.
        /// </summary>
        public TankMechanism()
        {
            RequestedAmount = 0;
            Pump = new Pump();
        }

        /// <summary>
        /// Retrieves the current status of the fueling process.
        /// Stops the pump if the requested fuel amount has been reached.
        /// </summary>
        /// <returns>A string describing the current status of the pump.</returns>
        public string GetStatus()
        {
            int currentLevel = Pump.GetStatus();

            if (!Pump.IsActive)
            {
                return "Pump has not started.";
            }
            else if (currentLevel >= RequestedAmount)
            {
                Pump.Stop();
                return $"Sufficient fuel dispensed, pump stopped after {currentLevel} liters.";
            }
            else
            {
                return $"Pump is running: {currentLevel} liters dispensed.";
            }
        }

        /// <summary>
        /// Starts the fuel dispensing process by activating the pump.
        /// </summary>
        public void Start()
        {
            Pump.Start();
        }
    }
}