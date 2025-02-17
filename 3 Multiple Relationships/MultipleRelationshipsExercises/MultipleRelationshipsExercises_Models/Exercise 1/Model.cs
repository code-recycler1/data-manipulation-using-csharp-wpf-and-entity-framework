using System;
using System.Collections.Generic;

namespace MultipleRelationshipsExercises_Models.Exercise_1
{
    /// <summary>
    /// Represents a fashion model with attributes for name, wrist circumference, and height.
    /// </summary>
    public class Model
    {
        private string _name;
        private double _wrist;
        private double _height;

        /// <summary>
        /// Gets or sets the height of the model in cm.
        /// Ensures the height is within the valid range (170-195 cm).
        /// </summary>
        /// <exception cref="Exception">Thrown when the height is outside the valid range.</exception>
        public double Height
        {
            get { return _height; }
            set
            {
                if (value >= 170 && value <= 195)
                {
                    _height = value;
                }
                else
                {
                    throw new Exception("The ideal height is between 170 and 195 cm.");
                }
            }
        }

        /// <summary>
        /// Gets or sets the wrist circumference of the model in cm.
        /// Ensures the wrist circumference is within the valid range (10-20 cm).
        /// </summary>
        /// <exception cref="Exception">Thrown when the wrist circumference is outside the valid range.</exception>
        public double Wrist
        {
            get { return _wrist; }
            set
            {
                if (value >= 10 && value <= 20)
                {
                    _wrist = value;
                }
                else
                {
                    throw new Exception("The ideal wrist circumference is between 10 and 20 cm.");
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the model.
        /// Ensures the name is not empty or whitespace.
        /// </summary>
        /// <exception cref="Exception">Thrown when the name is null or whitespace.</exception>
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Model name cannot be empty!");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model"/> class.
        /// </summary>
        /// <param name="name">The name of the model.</param>
        /// <param name="wrist">The wrist circumference in cm.</param>
        /// <param name="height">The height in cm.</param>
        public Model(string name, double wrist, double height)
        {
            this.Name = name;
            this.Wrist = wrist;
            this.Height = height;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current model.
        /// Two models are considered equal if they have the same name.
        /// </summary>
        /// <param name="obj">The object to compare with the current model.</param>
        /// <returns>True if the models are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Model model && Name == model.Name;
        }

        /// <summary>
        /// Returns a hash code for the model based on its name.
        /// </summary>
        /// <returns>A hash code for the model.</returns>
        public override int GetHashCode()
        {
            return -1386946022 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        /// <summary>
        /// Calculates the ideal weight of the model using a formula.
        /// Formula: (Height + 4 * Wrist - 100) / 2
        /// </summary>
        /// <returns>The ideal weight in kg.</returns>
        public double IdealWeight()
        {
            return (this.Height + 4 * this.Wrist - 100) / 2;
        }

        /// <summary>
        /// Returns a formatted string representing the model.
        /// </summary>
        /// <returns>A string containing the model's name, height, wrist, and ideal weight.</returns>
        public override string ToString()
        {
            return Name.PadRight(15) + Height.ToString().PadLeft(6)
                + Wrist.ToString().PadLeft(10) + IdealWeight().ToString("0.0").PadLeft(10) + Environment.NewLine;
        }
    }
}
