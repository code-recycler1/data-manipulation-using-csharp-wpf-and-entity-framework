namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents a piece worker, inheriting from the <see cref="Employee"/> class.
    /// The salary is calculated based on the number of items produced and the wage per item.
    /// </summary>
    public class PieceWorker : Employee
    {
        /// <summary>
        /// Gets or sets the number of items produced by the piece worker.
        /// </summary>
        public int ItemsProduced { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieceWorker"/> class.
        /// </summary>
        /// <param name="lastName">The last name of the piece worker.</param>
        /// <param name="firstName">The first name of the piece worker.</param>
        /// <param name="wagePerItem">The wage earned per item produced.</param>
        /// <param name="itemsProduced">The total number of items produced.</param>
        public PieceWorker(string lastName, string firstName, double wagePerItem, int itemsProduced)
            : base(lastName, firstName, wagePerItem)
        {
            ItemsProduced = itemsProduced;
        }

        /// <summary>
        /// Validates the specified property of the piece worker.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "ItemsProduced" && ItemsProduced < 0)
            {
                return "Number of items produced must be greater than or equal to 0.";
            }

            return base.Validate(propertyName);
        }

        /// <summary>
        /// Calculates the total salary for the piece worker based on items produced.
        /// </summary>
        /// <returns>The total calculated salary.</returns>
        public override double CalculateSalary()
        {
            return ItemsProduced * Salary;
        }
    }
}
