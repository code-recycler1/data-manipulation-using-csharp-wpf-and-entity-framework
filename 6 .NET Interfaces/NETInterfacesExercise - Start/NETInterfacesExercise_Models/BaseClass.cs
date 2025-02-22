using System;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a base class that provides basic validation functionality.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Gets validation error messages for all properties in the class.
        /// </summary>
        public string Error
        {
            get
            {
                string errorMessages = "";
                foreach (var property in this.GetType().GetProperties())
                {
                    string error = this[property.Name];
                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        errorMessages += error + Environment.NewLine;
                    }
                }
                return errorMessages;
            }
        }

        /// <summary>
        /// Checks if the object is valid based on validation errors.
        /// </summary>
        /// <returns>True if there are no validation errors, otherwise false.</returns>
        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(Error);
        }
    }
}
