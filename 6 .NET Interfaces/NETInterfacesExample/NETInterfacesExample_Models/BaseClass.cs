using System;
using System.ComponentModel;

namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Provides a base class that implements IDataErrorInfo for validation support.
    /// </summary>
    public abstract class BaseClass : IDataErrorInfo
    {
        /// <summary>
        /// Gets the validation error message for the specified property.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public abstract string this[string columnName] { get; }

        /// <summary>
        /// Determines whether the object is valid by checking for validation errors.
        /// </summary>
        /// <returns>True if the object has no validation errors; otherwise, false.</returns>
        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(Error);
        }

        /// <summary>
        /// Gets a concatenated string of all validation errors.
        /// </summary>
        public string Error
        {
            get
            {
                string errorMessages = "";

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
