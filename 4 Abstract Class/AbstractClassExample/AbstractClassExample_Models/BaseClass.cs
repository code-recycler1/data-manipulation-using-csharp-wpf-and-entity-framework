using System;

namespace AbstractClassExample_Models
{
    /// <summary>
    /// Represents an abstract base class that provides validation functionality for derived classes.
    /// </summary>
    public abstract class BaseClass
    {
        /// <summary>
        /// Validates a specific property of the derived class.
        /// </summary>
        /// <param name="propertyName">The name of the property to validate.</param>
        /// <returns>A validation error message if invalid; otherwise, an empty string.</returns>
        public abstract string Validate(string propertyName);

        /// <summary>
        /// Determines whether the object is valid based on its validation rules.
        /// </summary>
        /// <returns>True if the object is valid (no validation errors); otherwise, false.</returns>
        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(ErrorMessages);
        }

        /// <summary>
        /// Retrieves all validation error messages for the object.
        /// </summary>
        public string ErrorMessages
        {
            get
            {
                string errorMessages = "";

                // Iterate through all readable properties of the object
                foreach (var property in this.GetType().GetProperties())
                {
                    if (property.CanRead)
                    {
                        // Validate the property and collect error messages
                        string error = Validate(property.Name);
                        if (!string.IsNullOrWhiteSpace(error))
                        {
                            errorMessages += error + Environment.NewLine;
                        }
                    }
                }
                return errorMessages;
            }
        }
    }
}
