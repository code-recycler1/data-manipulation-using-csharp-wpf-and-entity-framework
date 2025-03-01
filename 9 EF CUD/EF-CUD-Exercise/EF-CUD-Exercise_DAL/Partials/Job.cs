namespace EF_CUD_Exercise_DAL
{
    /// <summary>
    /// Represents a Job entity with custom equality comparison logic.
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Determines whether the specified object is equal to the current Job instance.
        /// Two Job objects are considered equal if they have the same JobID.
        /// </summary>
        /// <param name="obj">The object to compare with the current Job instance.</param>
        /// <returns>True if the specified object is a Job and has the same JobID; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   JobID == job.JobID;
        }

        /// <summary>
        /// Returns a hash code for the Job instance.
        /// The hash code is based on the JobID property.
        /// </summary>
        /// <returns>An integer hash code representing the Job instance.</returns>
        public override int GetHashCode()
        {
            return 1420596828 + JobID.GetHashCode();
        }
    }
}
