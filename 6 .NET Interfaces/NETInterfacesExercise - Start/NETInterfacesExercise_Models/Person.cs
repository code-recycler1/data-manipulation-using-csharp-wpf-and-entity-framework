using System;
using System.Collections.Generic;
using System.Text;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a person with personal information and owned assets.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the person's national register number.
        /// </summary>
        public string NationalRegisterNumber { get; set; }

        /// <summary>
        /// Gets the list of electronic devices owned by the person.
        /// </summary>
        public List<ElectricalAppliance> ElectricalAppliances { get; }

        /// <summary>
        /// Gets the list of books owned by the person.
        /// </summary>
        public List<Book> Books { get; }

        /// <summary>
        /// Gets or sets the person's bank account.
        /// </summary>
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the specified name and national register number.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="nationalRegisterNumber">The person's national register number.</param>
        public Person(string name, string nationalRegisterNumber)
        {
            Name = name;
            NationalRegisterNumber = nationalRegisterNumber;
            ElectricalAppliances = new List<ElectricalAppliance>();
            Books = new List<Book>();
        }

        /// <summary>
        /// Attempts to purchase a product.
        /// </summary>
        /// <param name="product">The product to purchase.</param>
        /// <returns><c>true</c> if the purchase was successful; otherwise, <c>false</c>.</returns>
        public bool BuyProduct(Product product)
        {
            // TODO: Implement logic for purchasing a product.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deposits a specified amount into the bank account.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <returns><c>true</c> if the deposit was successful; otherwise, <c>false</c>.</returns>
        public bool Deposit(double amount)
        {
            // TODO: Implement logic for depositing money.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdraws a specified amount from the bank account.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <returns>
        /// <c>true</c> if withdrawal was successful, <c>false</c> if unsuccessful,
        /// or <c>null</c> if the transaction is invalid.
        /// </returns>
        public bool? Withdraw(double amount)
        {
            // TODO: Implement logic for withdrawing money.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a formatted string representation of the person's assets, including electronic devices and books.
        /// </summary>
        /// <returns>A string listing the person's name, national register number, and owned assets.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder devices = new StringBuilder();
            StringBuilder books = new StringBuilder();

            result.AppendLine($"{Name} with National Register Number {NationalRegisterNumber} owns the following:");

            // Append electronic devices if any exist
            foreach (var device in ElectricalAppliances)
            {
                devices.AppendLine($"- {device}");
            }

            // Append books if any exist
            foreach (var book in Books)
            {
                books.AppendLine($"- {book}");
            }

            if (devices.Length > 0)
            {
                result.AppendLine("Electronic Devices:");
                result.Append(devices);
            }

            if (books.Length > 0)
            {
                result.AppendLine("Books:");
                result.Append(books);
            }

            return result.ToString();
        }
    }
}
