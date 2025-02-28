using System.Collections.Generic;
using System.Linq;

namespace NETEntityFrameworkExample_DAL
{
    /// <summary>
    /// Provides methods for retrieving employee data from the SalesManagement database.
    /// </summary>
    public static class DatabaseOperations
    {
        /// <summary>
        /// Retrieves a list of all employees, ordered by last name and first name.
        /// </summary>
        /// <returns>A list of employees sorted by last name and first name.</returns>
        public static List<Employee> GetEmployees()
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Employees
                               .Include("Orders")
                               .OrderBy(x => x.LastName)
                               .ThenBy(x => x.FirstName);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of employees filtered by a specific job title, ordered by last name and first name.
        /// </summary>
        /// <param name="jobTitle">The job title to filter employees by.</param>
        /// <returns>A list of employees who hold the specified job title, sorted by last name and first name.</returns>
        public static List<Employee> GetEmployeesByJobTitle(string jobTitle)
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Employees
                                .Include("Orders")
                                .Where(x => x.JobTitle == jobTitle)
                                .OrderBy(x => x.LastName)
                                .ThenBy(x => x.FirstName);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of employees filtered by last name and first name, ordered alphabetically.
        /// </summary>
        /// <param name="lastName">The last name (or partial last name) to filter employees by.</param>
        /// <param name="firstName">The first name (or partial first name) to filter employees by.</param>
        /// <returns>A list of employees matching the provided last and first name criteria, sorted alphabetically.</returns>
        public static List<Employee> GetEmployeesByLastNameAndFirstName(string lastName, string firstName)
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Employees
                                .Include("Orders")
                                .Where(x => x.LastName.Contains(lastName) && x.FirstName.Contains(firstName))
                                .OrderBy(x => x.LastName)
                                .ThenBy(x => x.FirstName);
                return query.ToList();
            }
        }

        /// <summary>
        /// Retrieves a specific employee based on their unique employee ID.
        /// </summary>
        /// <param name="employeeID">The unique identifier of the employee.</param>
        /// <returns>The employee with the specified ID, or null if no match is found.</returns>
        public static Employee GetEmployeeByID(int employeeID)
        {
            using (SalesManagementEntities entities = new SalesManagementEntities())
            {
                var query = entities.Employees
                                .Include("Orders")
                                .Where(x => x.EmployeeID == employeeID);
                return query.SingleOrDefault();
            }
        }
    }

}
