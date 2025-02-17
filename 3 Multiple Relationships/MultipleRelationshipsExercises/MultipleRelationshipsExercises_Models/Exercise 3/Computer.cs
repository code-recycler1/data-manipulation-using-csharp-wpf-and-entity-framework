using System.Collections.Generic;

namespace MultipleRelationshipsExercises_Models.Exercise_3
{
    /// <summary>
    /// Represents a computer that can be connected to multiple printers.
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// Gets the list of printers connected to the computer.
        /// </summary>
        public List<Printer> Printers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Computer"/> class.
        /// </summary>
        public Computer()
        {
            Printers = new List<Printer>();
        }

        /// <summary>
        /// Adds a printer to the computer's list of connected printers.
        /// </summary>
        /// <param name="printer">The printer to be added.</param>
        public void AddPrinter(Printer printer)
        {
            Printers.Add(printer);
        }

        /// <summary>
        /// Finds and returns the first available printer that is not busy.
        /// If a free printer is found, it is marked as busy.
        /// </summary>
        /// <returns>The first available <see cref="Printer"/> or null if all printers are busy.</returns>
        public Printer Print()
        {
            foreach (Printer printer in Printers)
            {
                if (!printer.IsBusy)
                {
                    printer.IsBusy = true;
                    return printer;
                }
            }
            return null;
        }
    }
}
