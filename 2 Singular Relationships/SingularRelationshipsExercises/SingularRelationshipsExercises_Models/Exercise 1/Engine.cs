namespace SingularRelationshipsExercises_Models.Exercise_1
{
    /// <summary>
    /// Represents a car engine with cylinder capacity and horsepower.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Gets or sets the cylinder capacity of the engine (measured in cubic centimeters).
        /// </summary>
        public int CylinderCapacity { get; set; }

        /// <summary>
        /// Gets or sets the horsepower (HP) of the engine.
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class with specified cylinder capacity and horsepower.
        /// </summary>
        /// <param name="cylinderCapacity">The cylinder capacity of the engine in cubic centimeters (cc).</param>
        /// <param name="hp">The horsepower (HP) of the engine.</param>
        public Engine(int cylinderCapacity, int hp)
        {
            CylinderCapacity = cylinderCapacity;
            HP = hp;
        }

        /// <summary>
        /// Returns a formatted string representation of the engine.
        /// </summary>
        /// <returns>A string describing the engine's cylinder capacity and horsepower.</returns>
        public override string ToString()
        {
            return $"Cylinder Capacity: {CylinderCapacity} cc - HP: {HP}";
        }
    }

}
