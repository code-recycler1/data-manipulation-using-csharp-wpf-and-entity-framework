namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents an electrical appliance product with additional details such as brand and model.
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
        /// Initializes a new instance of the ElectricalAppliance class.
        /// </summary>
        /// <param name="code">Product code</param>
        /// <param name="description">Product description</param>
        /// <param name="price">Product price</param>
        /// <param name="brand">Brand of the appliance</param>
        /// <param name="model">Model type</param>
        protected ElectricalAppliance(string code, string description, double price,
                                      string brand, string model)
            : base(code, description, price)
        {
            Brand = brand;
            Model = model;
        }

        /// <summary>
        /// Returns a compact string representation of the object.
        /// </summary>
        public override string ToCompactString()
        {
            return base.ToCompactString() + ";" + this.Brand + ";" + this.Model;
        }
    }
}
