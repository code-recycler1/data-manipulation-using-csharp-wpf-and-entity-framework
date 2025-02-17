using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleRelationshipsExercises_Models.Exercise_1
{
    /// <summary>
    /// Represents a modeling agency that manages a collection of models.
    /// </summary>
    public class ModellingAgency
    {
        private string _companyName;

        /// <summary>
        /// Gets the list of models associated with the agency.
        /// </summary>
        public List<Model> Models { get; }

        /// <summary>
        /// Gets or sets the company name of the modeling agency.
        /// Ensures the company name is not empty or whitespace.
        /// </summary>
        /// <exception cref="Exception">Thrown when the company name is null or whitespace.</exception>
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _companyName = value;
                }
                else
                {
                    throw new Exception("Company name cannot be empty!");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModellingAgency"/> class.
        /// </summary>
        /// <param name="companyName">The name of the modeling agency.</param>
        public ModellingAgency(string companyName)
        {
            this.CompanyName = companyName;
            this.Models = new List<Model>();
        }

        /// <summary>
        /// Adds a new model to the agency using individual attributes.
        /// </summary>
        /// <param name="name">The name of the model.</param>
        /// <param name="wrist">The wrist circumference of the model in cm.</param>
        /// <param name="height">The height of the model in cm.</param>
        public void Add(string name, double wrist, double height)
        {
            Add(new Model(name, wrist, height));
        }

        /// <summary>
        /// Adds an existing <see cref="Model"/> object to the agency.
        /// </summary>
        /// <param name="model">The model to be added.</param>
        public void Add(Model model)
        {
            Models.Add(model);
        }

        /// <summary>
        /// Calculates the average ideal weight of all models in the agency.
        /// </summary>
        /// <returns>The average ideal weight in kg.</returns>
        public double AverageWeight()
        {
            double sum = 0;

            Models.ForEach(x => sum += x.IdealWeight());

            return sum / Models.Count;
        }

        /// <summary>
        /// Returns a formatted string representing the agency and its models.
        /// </summary>
        /// <returns>A string containing the agency name and its models.</returns>
        public override string ToString()
        {
            string text = "Agency " + CompanyName + Environment.NewLine;

            Models.ForEach(x => text += x.ToString());

            return text;
        }

        /// <summary>
        /// Returns a list of models with an ideal weight below 60 kg.
        /// </summary>
        /// <returns>A string listing the names of models considered super slim.</returns>
        public string PrintSlimModels()
        {
            string text = CompanyName + " has the following super slim models:" + Environment.NewLine;

            Models.Where(x => x.IdealWeight() < 60)
                .ToList().ForEach(x => text += x.Name + Environment.NewLine);

            return text;
        }
    }
}
