using System.Collections.Generic;

namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents a company that contains a list of employees.
    /// Inherits validation functionality from <see cref="BaseClass"/>.
    /// </summary>
    public class Company : BaseClass
    {
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets the list of employees working in the company.
        /// </summary>
        public List<Employee> Employees { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class with the specified company name.
        /// </summary>
        /// <param name="companyName">The name of the company.</param>
        public Company(string companyName)
        {
            CompanyName = companyName;
            Employees = new List<Employee>();
        }

        /// <summary>
        /// Adds an employee to the company if they are not already present.
        /// </summary>
        /// <param name="employee">The employee to add.</param>
        /// <returns><c>true</c> if the employee was successfully added; otherwise, <c>false</c>.</returns>
        public bool AddEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
            {
                Employees.Add(employee);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates the specified property of the company.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string Validate(string propertyName)
        {
            if (propertyName == "CompanyName" && string.IsNullOrWhiteSpace(CompanyName))
            {
                return "Company name is a required field.";
            }
            return "";
        }

        /// <summary>
        /// Returns a string representation of the company.
        /// </summary>
        /// <returns>The company name.</returns>
        public override string ToString()
        {
            return CompanyName;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current company.
        /// </summary>
        /// <param name="obj">The object to compare with the current company.</param>
        /// <returns><c>true</c> if the specified object is equal to the current company; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Company company &&
                   CompanyName == company.CompanyName;
        }

        /// <summary>
        /// Returns the hash code for the company.
        /// </summary>
        /// <returns>A hash code for the company.</returns>
        public override int GetHashCode()
        {
            return 1025954773 + EqualityComparer<string>.Default.GetHashCode(CompanyName);
        }
    }
}
