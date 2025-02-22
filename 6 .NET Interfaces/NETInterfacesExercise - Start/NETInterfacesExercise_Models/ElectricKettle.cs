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
    }
}
