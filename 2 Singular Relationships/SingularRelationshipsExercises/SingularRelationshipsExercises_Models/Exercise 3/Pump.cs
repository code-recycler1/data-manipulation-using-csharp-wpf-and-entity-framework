using System;

namespace SingularRelationshipsExercises_Models.Exercise_3
{
    /// <summary>
    /// Represents a fuel pump that dispenses fuel over time.
    /// </summary>
    public class Pump
    {
        /// <summary>
        /// The time when the pump started dispensing fuel.
        /// </summary>
        private DateTime StartTime { get; set; }

        /// <summary>
        /// The rate at which fuel flows, measured in liters per second.
        /// </summary>
        private int FlowRate { get; set; }

        /// <summary>
        /// Indicates whether the pump is currently active.
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pump"/> class.
        /// Randomly sets the flow rate to a value between 1 and 2 liters per second.
        /// </summary>
        public Pump()
        {
            Random random = new Random();
            FlowRate = random.Next(1, 3); // Reduced for testing purposes
        }

        /// <summary>
        /// Calculates the time elapsed since the pump started, in seconds.
        /// </summary>
        /// <returns>The total elapsed time in seconds.</returns>
        private int TimeElapsedInSeconds()
        {
            TimeSpan elapsed = DateTime.Now - StartTime;
            return elapsed.Hours * 3600 + elapsed.Minutes * 60 + elapsed.Seconds;
        }

        /// <summary>
        /// Gets the current status of the pump, returning the total fuel dispensed so far.
        /// </summary>
        /// <returns>The amount of fuel dispensed in liters.</returns>
        public int GetStatus()
        {
            return IsActive ? TimeElapsedInSeconds() * FlowRate : 0;
        }

        /// <summary>
        /// Starts the pump, recording the start time.
        /// </summary>
        public void Start()
        {
            IsActive = true;
            StartTime = DateTime.Now;
        }

        /// <summary>
        /// Stops the pump and returns the total fuel dispensed.
        /// </summary>
        /// <returns>The amount of fuel dispensed before stopping.</returns>
        public int Stop()
        {
            IsActive = false;
            return GetStatus();
        }
    }
}