using System.Collections.Generic;
using System.Linq;

namespace NETEntityFrameworkExercise_DAL
{
    /// <summary>
    /// Provides database operations related to stores, employees, and jobs.
    /// </summary>
    public static class DatabaseOperations
    {
        /// <summary>
        /// Retrieves a list of stores whose names contain the specified string.
        /// </summary>
        /// <param name="name">The name or partial name of the store to search for.</param>
        /// <returns>A list of <see cref="Store"/> objects that match the search criteria.</returns>
        public static List<Store> GetStoresByName(string name)
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Stores
                    .Where(x => x.StoreName.Contains(name))
                    .OrderBy(x => x.StoreName)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of employees filtered by job ID.
        /// </summary>
        /// <param name="jobID">The job ID used to filter employees.</param>
        /// <returns>A list of <see cref="Employee"/> objects with the specified job ID.</returns>
        public static List<Employee> GetEmployeesByJobID(int jobID)
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Employees
                    .Where(x => x.JobID == jobID)
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of all available job positions ordered by job description.
        /// </summary>
        /// <returns>A list of <see cref="Job"/> objects sorted by job description.</returns>
        public static List<Job> GetJobs()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Jobs
                    .OrderBy(x => x.JobDescription)
                    .ToList();
            }
        }
    }
}
