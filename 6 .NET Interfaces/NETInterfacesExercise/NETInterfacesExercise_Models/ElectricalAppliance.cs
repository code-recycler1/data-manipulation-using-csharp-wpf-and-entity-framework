using System;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents an electrical appliance product with additional details such as brand and model.
    /// Inherits from <see cref="Product"/>.
    /// </summary>
    public abstract class ElectricalAppliance : Product
    {
        /// <summary>
        /// Gets or sets the brand of the electrical appliance.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the electrical appliance.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalAppliance"/> class with the specified parameters.
        /// </summary>
        /// <param name="code">The product code.</param>
        /// <param name="description">The product description.</param>
        /// <param name="price">The product price.</param>
        /// <param name="brand">The brand of the appliance.</param>
        /// <param name="model">The model of the appliance.</param>
        protected ElectricalAppliance(string code, string description, double price,
            string brand, string model) : base(code, description, price)
        {
            Brand = brand;
            Model = model;
        }

        /// <summary>
        /// Validates the specified property and returns an error message if validation fails.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>An error message if validation fails; otherwise, an empty string.</returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Brand" && string.IsNullOrWhiteSpace(Brand))
                {
                    return "Brand is a required field!";
                }
                else if (columnName == "Model" && string.IsNullOrWhiteSpace(Model))
                {
                    return "Model is a required field!";
                }
                return base[columnName];
            }
        }

        /// <summary>
        /// Returns a formatted string representation of the electrical appliance, including its brand and model.
        /// </summary>
        /// <returns>A string containing the product details, brand, and model.</returns>
        public override string ToString()
        {
            string text = base.ToString() + $"Brand: {Brand}" + Environment.NewLine;
            text += $"Model: {Model}" + Environment.NewLine;
            return text;
        }

        /// <summary>
        /// Returns a compact string representation of the electrical appliance.
        /// </summary>
        /// <returns>A semicolon-separated string containing the product details, brand, and model.</returns>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + this.Brand + ";" + this.Model;
        }
    }
}
