using System;
using System.Collections.Generic;

namespace MultipleRelationshipsExercises_Models.Exercise_2
{
    /// <summary>
    /// Represents a class group containing students.
    /// </summary>
    public class ClassGroup
    {
        /// <summary>
        /// Gets or sets the name of the class group.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets the list of students in the class group.
        /// </summary>
        public List<Student> Students { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassGroup"/> class.
        /// </summary>
        /// <param name="className">The name of the class group.</param>
        public ClassGroup(string className)
        {
            ClassName = className;
            Students = new List<Student>();
        }

        /// <summary>
        /// Adds a student to the class group.
        /// </summary>
        /// <param name="student">The student to be added.</param>
        /// <exception cref="Exception">Thrown if the student is already in the class.</exception>
        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
            else
            {
                throw new Exception("Student has already been added!");
            }
        }

        /// <summary>
        /// Returns a formatted list of all students in the class.
        /// </summary>
        /// <returns>A string representing the student list.</returns>
        public string GetList()
        {
            string text = "Student list for " + ClassName + Environment.NewLine;
            Students.ForEach(s => text += s.ToString() + Environment.NewLine);
            return text;
        }

        /// <summary>
        /// Returns a detailed list of all students in the class.
        /// </summary>
        /// <returns>A string representing the detailed student list.</returns>
        public string GetDetailedList()
        {
            string text = "Detailed student list for " + ClassName + Environment.NewLine;
            Students.ForEach(s => text += s.GetDetails() + Environment.NewLine);
            return text;
        }
    }
}
