namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents an hourly worker, inheriting from the <see cref="Employee"/> class.
    /// The salary is calculated based on hours worked, with overtime compensation.
    /// </summary>
    public class HourlyWorker : Employee
    {
        /// <summary>
        /// Gets or sets the number of hours worked by the employee.
        /// </summary>
        public double HoursWorked { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HourlyWorker"/> class.
        /// </summary>
        /// <param name="lastName">The last name of the hourly worker.</param>
        /// <param name="firstName">The first name of the hourly worker.</param>
        /// <param name="salary">The hourly wage of the worker.</param>
        /// <param name="hoursWorked">The total number of hours worked.</param>
        public HourlyWorker(string lastName, string firstName, double salary, int hoursWorked)
            : base(lastName, firstName, salary)
        {
            HoursWorked = hoursWorked;
        }

        /// <summary>
        /// Validates the specified property of the hourly worker.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "HoursWorked" && HoursWorked < 0)
            {
                return "Hours worked must be greater than or equal to 0.";
            }

            return base.Validate(propertyName);
        }

        /// <summary>
        /// Calculates the total salary for the hourly worker, including overtime pay.
        /// </summary>
        /// <returns>The total calculated salary.</returns>
        public override double CalculateSalary()
        {
            double totalSalary = Salary * HoursWorked;

            // Overtime pay: additional salary for hours worked beyond 40
            if (HoursWorked > 40)
            {
                totalSalary += (HoursWorked - 40) * Salary;
            }

            return totalSalary;
        }
    }
}
