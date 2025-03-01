using System;
using System.ComponentModel;

namespace EF_CUD_Example_Models
{
    /// <summary>
    /// An abstract base class implementing IDataErrorInfo for data validation.
    /// </summary>
    public abstract class BaseClass : IDataErrorInfo
    {
        /// <summary>
        /// Abstract indexer to be implemented by derived classes for property validation.
        /// </summary>
        /// <param name="columnName">The name of the property being validated.</param>
        /// <returns>A validation error message if the property is invalid; otherwise, an empty string.</returns>
        public abstract string this[string columnName] { get; }

        /// <summary>
        /// Checks whether the object is valid by verifying if there are any validation errors.
        /// </summary>
        /// <returns>True if the object has no validation errors; otherwise, false.</returns>
        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(Error);
        }

        /// <summary>
        /// Retrieves validation error messages for all properties in the object using reflection.
        /// </summary>
        public string Error
        {
            get
            {
                string errorMessages = "";

                // Iterate over all readable properties using reflection
                foreach (var property in this.GetType().GetProperties())
                {
                    if (property.CanRead)
                    {
                        string error = this[property.Name];
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
