using System;

namespace MultipleRelationshipsExercises_Models.Exercise_2
{
    /// <summary>
    /// Represents a student who stays in a dormitory.
    /// </summary>
    public class DormStudent : Student
    {
        /// <summary>
        /// Gets or sets the name of the landlord of the dormitory.
        /// </summary>
        private string Landlord { get; set; }

        /// <summary>
        /// Gets or sets the address of the dormitory.
        /// </summary>
        private string DormAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DormStudent"/> class.
        /// </summary>
        /// <param name="studentNumber">The unique student number.</param>
        /// <param name="studentName">The name of the student.</param>
        /// <param name="landlord">The name of the landlord managing the dormitory.</param>
        /// <param name="boardingAddress">The address of the dormitory.</param>
        public DormStudent(string studentNumber, string studentName, string landlord, string boardingAddress)
            : base(studentNumber, studentName)
        {
            Landlord = landlord;
            DormAddress = boardingAddress;
        }

        /// <summary>
        /// Returns a string representation of the dorm student.
        /// </summary>
        /// <returns>A string indicating that the student is a dormitory resident.</returns>
        public override string ToString()
        {
            return base.ToString() + " (dorm student)";
        }

        /// <summary>
        /// Returns detailed information about the dorm student.
        /// </summary>
        /// <returns>A string containing the dorm student's details, including address and landlord.</returns>
        public override string GetDetails()
        {
            return base.GetDetails() + Environment.NewLine +
                   new string(' ', 15) + "Dorm Address: " + DormAddress + " (Landlord: " + Landlord + ")";
        }
    }
}
