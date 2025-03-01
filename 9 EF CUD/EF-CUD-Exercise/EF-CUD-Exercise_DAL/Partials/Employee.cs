using EF_CUD_Exercise_Models;

namespace EF_CUD_Exercise_DAL
{
    /// <summary>
    /// Represents an Employee entity, inheriting validation functionality from BaseClass.
    /// Implements validation for required fields such as FirstName and LastName.
    /// </summary>
    public partial class Employee : BaseClass
    {
        /// <summary>
        /// Validates specific properties of the Employee entity.
        /// Ensures that the FirstName and LastName fields are not empty or null.
        /// </summary>
        /// <param name="columnName">The name of the property being validated.</param>
        /// <returns>A validation error message if the field is invalid; otherwise, an empty string.</returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "FirstName" && string.IsNullOrWhiteSpace(FirstName))
                {
                    return "First name is a required field!";
                }
                if (columnName == "LastName" && string.IsNullOrWhiteSpace(LastName))
                {
                    return "Last name is a required field!";
                }
                return "";
            }
        }
    }
}
