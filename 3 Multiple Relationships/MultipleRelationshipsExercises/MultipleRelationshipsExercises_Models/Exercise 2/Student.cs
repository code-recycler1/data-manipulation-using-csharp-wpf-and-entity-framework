using System.Collections.Generic;

namespace MultipleRelationshipsExercises_Models.Exercise_2
{
    /// <summary>
    /// Represents a student with a unique student number, name, and department.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique student number.
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Gets or sets the department the student belongs to.
        /// Default department is "Tech&IT".
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with a student number and name.
        /// The default department is set to "Tech&IT".
        /// </summary>
        /// <param name="studentNumber">The unique student number.</param>
        /// <param name="studentName">The name of the student.</param>
        public Student(string studentNumber, string studentName)
        {
            StudentNumber = studentNumber;
            StudentName = studentName;
            Department = "Tech&IT";
        }

        /// <summary>
        /// Returns the student's name in uppercase format.
        /// </summary>
        /// <returns>The student's name in uppercase.</returns>
        public override string ToString()
        {
            return StudentName.ToUpper();
        }

        /// <summary>
        /// Returns a formatted string containing the student number and name.
        /// </summary>
        /// <returns>A string displaying the student's number and name.</returns>
        public virtual string GetDetails()
        {
            return StudentNumber.PadRight(15) + StudentName;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current student.
        /// Two students are considered equal if they have the same student number.
        /// </summary>
        /// <param name="obj">The object to compare with the current student.</param>
        /// <returns>True if the specified object is a student with the same student number; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Student student && StudentNumber == student.StudentNumber;
        }

        /// <summary>
        /// Returns a hash code for the student based on the student number.
        /// </summary>
        /// <returns>A hash code for the student.</returns>
        public override int GetHashCode()
        {
            return 41853580 + EqualityComparer<string>.Default.GetHashCode(StudentNumber);
        }
    }
}
