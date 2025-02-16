using StaticsExercise_DAL;
using System;

namespace StaticsExercise_Models
{
    /// <summary>
    /// Static class for validation methods.
    /// </summary>
    public static class Validations
    {
        /// <summary>
        /// Validates a social security number.
        /// </summary>
        public static bool IsSocialSecurityNumberValid(string socialSecurityNumber)
        {
            try
            {
                // Remove hyphens and spaces
                socialSecurityNumber = socialSecurityNumber.Replace("-", "").Replace(" ", "");

                // Check if the length is 11 characters
                if (socialSecurityNumber.Length == 11)
                {
                    // Extract the first 9 digits and the control number
                    int first9 = int.Parse(socialSecurityNumber.Substring(0, 9));
                    int controlNumber = int.Parse(socialSecurityNumber.Substring(9, 2));

                    // Validate the control number
                    if ((97 - (first9 % 97)) == controlNumber)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                // Log the error
                FileOperations.LogErrors(ex);
                return false;
            }
        }
    }
}