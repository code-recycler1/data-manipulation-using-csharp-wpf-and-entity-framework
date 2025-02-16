namespace SingularRelationshipsExercises_Models.Exercise_1
{
    /// <summary>
    /// Represents a car with a brand, chassis number, and an engine.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the brand of the car.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the unique chassis number of the car.
        /// </summary>
        public string ChassisNumber { get; set; }

        /// <summary>
        /// Gets or sets the engine associated with the car.
        /// </summary>
        public Engine Engine { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class with the specified brand, chassis number, and engine.
        /// </summary>
        /// <param name="brand">The brand of the car.</param>
        /// <param name="chassisNumber">The unique chassis number of the car.</param>
        /// <param name="engine">The engine assigned to the car.</param>
        public Car(string brand, string chassisNumber, Engine engine)
        {
            Brand = brand;
            ChassisNumber = chassisNumber;
            Engine = engine;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current car based on the chassis number.
        /// </summary>
        /// <param name="obj">The object to compare with the current car.</param>
        /// <returns><c>true</c> if the specified object is a <see cref="Car"/> with the same chassis number; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Car car && ChassisNumber == car.ChassisNumber;
        }

        /// <summary>
        /// Returns a hash code for this car based on its chassis number.
        /// </summary>
        /// <returns>An integer representing the hash code.</returns>
        public override int GetHashCode()
        {
            return ChassisNumber.GetHashCode();
        }

        /// <summary>
        /// Returns a formatted string representing the car's details, including its brand, chassis number, and engine specifications.
        /// </summary>
        /// <returns>A string describing the car.</returns>
        public override string ToString()
        {
            return $"The {Brand} with chassis number {ChassisNumber} has the following specifications:\n{Engine}";
        }
    }
}
