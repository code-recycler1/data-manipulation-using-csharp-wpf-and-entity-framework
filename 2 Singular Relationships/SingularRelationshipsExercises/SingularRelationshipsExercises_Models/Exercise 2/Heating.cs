namespace SingularRelationshipsExercises_Models.Exercise_2
{
    /// <summary>
    /// Represents a heating system with power control and adjustable temperature.
    /// </summary>
    public class Heating
    {
        /// <summary>
        /// Gets or sets a value indicating whether the heating system is powered on.
        /// </summary>
        public bool Power { get; set; }

        private double _temperature;

        /// <summary>
        /// Gets or sets the temperature of the heating system.
        /// Temperature can only be set when the heating is powered on and the value is non-negative.
        /// </summary>
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (this.Power && value >= 0)
                {
                    _temperature = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heating"/> class with power turned off by default.
        /// </summary>
        public Heating()
        {
            Power = false;
        }
    }
}
