namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents a commission-based worker, inheriting from the <see cref="Employee"/> class.
    /// The salary is calculated based on a base salary plus commission per sale.
    /// </summary>
    public class CommissionWorker : Employee
    {
        /// <summary>
        /// Gets or sets the commission rate per sale.
        /// </summary>
        public double CommissionRate { get; set; }

        /// <summary>
        /// Gets or sets the number of sales made by the worker.
        /// </summary>
        public int SalesCount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionWorker"/> class.
        /// </summary>
        /// <param name="lastName">The last name of the commission worker.</param>
        /// <param name="firstName">The first name of the commission worker.</param>
        /// <param name="baseSalary">The base salary of the worker.</param>
        /// <param name="commissionRate">The commission earned per sale.</param>
        /// <param name="salesCount">The total number of sales made.</param>
        public CommissionWorker(string lastName, string firstName, double baseSalary, double commissionRate, int salesCount)
            : base(lastName, firstName, baseSalary)
        {
            CommissionRate = commissionRate;
            SalesCount = salesCount;
        }

        /// <summary>
        /// Calculates the total salary for the commission worker.
        /// </summary>
        /// <returns>The total calculated salary, including base salary and commission.</returns>
        public override double CalculateSalary()
        {
            return Salary + (CommissionRate * SalesCount);
        }

        /// <summary>
        /// Validates the specified property of the commission worker.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "SalesCount" && SalesCount < 0)
            {
                return "Sales count must be greater than or equal to 0.";
            }
            if (propertyName == "CommissionRate" && CommissionRate < 0)
            {
                return "Commission rate must be greater than or equal to 0.";
            }
            return base.Validate(propertyName);
        }
    }
}
