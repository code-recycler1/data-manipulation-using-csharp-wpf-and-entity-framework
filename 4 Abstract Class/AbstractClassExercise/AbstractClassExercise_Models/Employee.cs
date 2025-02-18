using System.Collections.Generic;

namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents an abstract base class for employees, providing common properties 
    /// and methods related to employee information and validation.
    /// </summary>
    public abstract class Employee : BaseClass
    {
        /// <summary>
        /// Gets or sets the first name of the employee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the employee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the base salary of the employee.
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with the specified details.
        /// </summary>
        /// <param name="lastName">The last name of the employee.</param>
        /// <param name="firstName">The first name of the employee.</param>
        /// <param name="salary">The base salary of the employee.</param>
        public Employee(string lastName, string firstName, double salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        /// <summary>
        /// Calculates the salary of the employee. Must be implemented by derived classes.
        /// </summary>
        /// <returns>The calculated salary of the employee.</returns>
        public abstract double CalculateSalary();

        /// <summary>
        /// Returns a formatted string representation of the employee's details.
        /// </summary>
        /// <returns>A string containing the employee type, name, and salary.</returns>
        public override string ToString()
        {
            return this.GetType().Name.PadRight(18) + ":"
                + LastName.PadRight(20) + FirstName.PadRight(15) + " "
                + CalculateSalary().ToString("c").PadLeft(10);
        }

        /// <summary>
        /// Validates a specific property of the employee.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "LastName" && string.IsNullOrWhiteSpace(LastName))
            {
                return "Last Name is a required field!";
            }
            if (propertyName == "FirstName" && string.IsNullOrWhiteSpace(FirstName))
            {
                return "First Name is a required field!";
            }
            if (propertyName == "Salary" && Salary < 0)
            {
                return "Salary must be greater than or equal to 0.";
            }

            return "";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current employee.
        /// Two employees are considered equal if they have the same first and last name.
        /// </summary>
        /// <param name="obj">The object to compare with the current employee.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName;
        }

        /// <summary>
        /// Serves as the default hash function for the employee class.
        /// </summary>
        /// <returns>A hash code for the current employee instance.</returns>
        public override int GetHashCode()
        {
            var hashCode = 692177586;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            return hashCode;
        }
    }
}
