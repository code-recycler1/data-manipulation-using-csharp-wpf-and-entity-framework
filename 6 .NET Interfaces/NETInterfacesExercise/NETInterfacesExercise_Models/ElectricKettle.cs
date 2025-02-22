using System;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents an electric kettle, which is a type of electrical appliance with a specific water capacity.
    /// </summary>
    public class ElectricKettle : ElectricalAppliance
    {
        /// <summary>
        /// Gets or sets the water capacity in liters.
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Constructor for ElectricKettle.
        /// </summary>
        /// <param name="code">Product code</param>
        /// <param name="description">Product description</param>
        /// <param name="price">Product price</param>
        /// <param name="brand">Brand of the kettle</param>
        /// <param name="model">Model type</param>
        /// <param name="capacity">Capacity in liters</param>
        public ElectricKettle(string code, string description, double price,
                              string brand, string model, double capacity)
            : base(code, description, price, brand, model)
        {
            this.Capacity = capacity;
        }

        /// <summary>
        /// Returns a compact string representation of the object.
        /// </summary>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + this.Capacity;
        }

        /// <summary>
        /// Validates the specified property for the capacity value.
        /// </summary>
        /// <param name="columnName">The name of the property to validate.</param>
        /// <returns>
        /// An error message if the capacity value is invalid; otherwise, an empty string.
        /// </returns>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Capacity" && Capacity < 0)
                {
                    return "Capacity must be greater than or equal to 0!";
                }

                return base[columnName];
            }
        }

        /// <summary>
        /// Returns a string representation of the object including its capacity.
        /// </summary>
        /// <returns>A formatted string representing the object and its capacity.</returns>
        public override string ToString()
        {
            string text = base.ToString() + $"Capacity: {Capacity}" + Environment.NewLine;
            return text;
        }
    }
}
