using System;
using System.ComponentModel;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a base class that provides basic validation functionality.
    /// </summary>
    public abstract class BaseClass: IDataErrorInfo
    {
        /// <summary>
        /// Gets the validation error message for the specified property.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public abstract string this[string columnName] { get; }


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
