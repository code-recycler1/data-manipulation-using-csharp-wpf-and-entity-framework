﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EF_CUD_Exercise_DAL
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

        /// <summary>
        /// Retrieves a list of employees from the database, including their associated publishers and job details.
        /// The list is ordered by last name and then by first name.
        /// </summary>
        /// <returns>A list of employees with related publisher and job data.</returns>
        public static List<Employee> GetEmployees()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Employees
                    .Include(x => x.Publisher)
                    .Include(x => x.Job)
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of titles from the database, including their associated authors.
        /// The list is ordered alphabetically by title name.
        /// </summary>
        /// <returns>A list of titles with their related authors.</returns>
        public static List<Title> GetTitles()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Titles
                    .Include(x => x.TitleAuthors.Select(y => y.Author))
                    .OrderBy(x => x.Name)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of publishers from the database, including their associated titles and authors.
        /// The list is ordered alphabetically by publisher name.
        /// </summary>
        /// <returns>A list of publishers with their related titles and authors.</returns>
        public static List<Publisher> GetPublishers()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Publishers
                    .Include(x => x.Titles.Select(y => y.TitleAuthors.Select(z => z.Author)))
                    .OrderBy(x => x.Name)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of stores from the database, including their associated sales and titles.
        /// The list is ordered alphabetically by store name.
        /// </summary>
        /// <returns>A list of stores with their related sales and titles.</returns>
        public static List<Store> GetStores()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Stores
                    .Include(x => x.Sales.Select(y => y.Title))
                    .OrderBy(x => x.StoreName)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of employees associated with a specific publisher ID.
        /// </summary>
        /// <param name="pubID">The publisher ID to filter employees.</param>
        /// <returns>A list of employees sorted by last name and first name.</returns>
        public static List<Employee> GetEmployeesByPublisherID(string pubID)
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Employees
                    .Include(x => x.Job)
                    .Where(x => x.PublisherID == pubID)
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName)
                    .ToList();
            }
        }

        /// <summary>
        /// Adds a new employee to the database.
        /// </summary>
        /// <param name="employee">The employee object to add.</param>
        /// <returns>The number of rows affected. Returns 0 if an error occurs.</returns>
        public static int AddEmployee(Employee employee)
        {
            try
            {
                using (PublishersEntities publishersEntities = new PublishersEntities())
                {
                    publishersEntities.Employees.Add(employee);
                    return publishersEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }

        /// <summary>
        /// Updates an existing employee in the database.
        /// </summary>
        /// <param name="employee">The employee object with updated details.</param>
        /// <returns>The number of rows affected. Returns 0 if an error occurs.</returns>
        public static int UpdateEmployee(Employee employee)
        {
            try
            {
                using (PublishersEntities publishersEntities = new PublishersEntities())
                {
                    publishersEntities.Entry(employee).State = EntityState.Modified;
                    return publishersEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }

        /// <summary>
        /// Deletes an employee from the database.
        /// </summary>
        /// <param name="employee">The employee object to delete.</param>
        /// <returns>The number of rows affected. Returns 0 if an error occurs.</returns>
        public static int DeleteEmployee(Employee employee)
        {
            try
            {
                using (PublishersEntities publishersEntities = new PublishersEntities())
                {
                    publishersEntities.Entry(employee).State = EntityState.Deleted;
                    return publishersEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.LogError(ex);
                return 0;
            }
        }
    }
}
