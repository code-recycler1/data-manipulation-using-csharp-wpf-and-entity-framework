namespace MultipleRelationshipsExercises_Models.Exercise_3
{
    /// <summary>
    /// Represents a printer that can process print jobs.
    /// </summary>
    public class Printer
    {
        /// <summary>
        /// Gets or sets a value indicating whether the printer is currently busy with a print job.
        /// </summary>
        public bool IsBusy { get; set; }

        /// <summary>
        /// Gets or sets the name of the printer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Printer"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the printer.</param>
        public Printer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Resets the printer's status to not busy.
        /// </summary>
        public void Reset()
        {
            IsBusy = false;
        }

        /// <summary>
        /// Returns a string representation of the printer, indicating whether it is busy or waiting for a job.
        /// </summary>
        /// <returns>A string describing the printer's status.</returns>
        public override string ToString()
        {
            return IsBusy
                ? $"{Name}: currently processing a print job"
                : $"{Name}: waiting for a print job";
        }
    }
}
