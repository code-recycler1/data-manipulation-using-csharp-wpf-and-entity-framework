using System;

namespace AbstractClassExercise_Models
{
    /// <summary>
    /// Represents the base class for all objects that require validation.
    /// Provides an abstract method for validation and a mechanism to check errors.
    /// </summary>
    public abstract class BaseClass
    {
        /// <summary>
        /// Validates a specific property based on its name.
        /// Implemented by derived classes to enforce custom validation rules.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public abstract string Validate(string propertyName);

        /// <summary>
        /// Determines if the object is valid by checking for error messages.
        /// </summary>
        /// <returns>True if there are no errors, otherwise false.</returns>
        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(ErrorMessages);
        }

        /// <summary>
        /// Retrieves all validation error messages for the object's properties.
        /// Uses reflection to validate all readable properties dynamically.
        /// </summary>
        public string ErrorMessages
        {
            get
            {
                string errors = "";

                // Iterate over all readable properties of the derived class.
                foreach (var property in this.GetType().GetProperties())
                {
                    if (property.CanRead)
                    {
                        string error = Validate(property.Name);
                        if (!string.IsNullOrWhiteSpace(error))
                        {
                            errors += error + Environment.NewLine;
                        }
                    }
                }
                return errors;
            }
        }
    }
}
