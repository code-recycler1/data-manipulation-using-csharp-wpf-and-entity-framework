using System;
using System.Collections.Generic;
using System.Text;

namespace NETInterfacesExercise_Models
{
    /// <summary>
    /// Represents a person with a name, national register number, 
    /// a collection of owned electric appliances and books, and a bank account.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the national register number of the person.
        /// </summary>
        public string NationalRegisterNumber { get; set; }

        /// <summary>
        /// Gets the list of electric appliances owned by the person.
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
        /// Initializes a new instance of the <see cref="Person"/> class.
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
        /// Attempts to purchase a product if the person has sufficient balance.
        /// </summary>
        /// <param name="product">The product to be purchased.</param>
        /// <returns>True if the purchase is successful, otherwise false.</returns>
        public bool BuyProduct(Product product)
        {
            if (BankAccount?.Withdraw(product.Price) == true)
            {
                if (product is ElectricalAppliance electricAppliance)
                {
                    ElectricalAppliances.Add(electricAppliance);
                }
                else if (product is Book book)
                {
                    Books.Add(book);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deposits a specified amount into the person's bank account.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <returns>True if the deposit is successful, otherwise false.</returns>
        public bool Deposit(double amount)
        {
            if (BankAccount != null)
            {
                BankAccount.Deposit(amount);
                return true;
            }
            return false;
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
            return BankAccount?.Withdraw(amount);
        }

        /// <summary>
        /// Returns a formatted string representation of the person's owned products.
        /// </summary>
        /// <returns>A string listing all the electric appliances and books owned by the person.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder appliances = new StringBuilder();
            StringBuilder books = new StringBuilder();
            stringBuilder.AppendLine($"{Name} with National Register Number {NationalRegisterNumber} owns the following:");

            foreach (var item in ElectricalAppliances)
            {
                appliances.Append("- " + item.ToString());
            }

            foreach (var item in Books)
            {
                books.Append("- " + item.ToString());
            }

            if (appliances.Length > 0)
            {
                stringBuilder.AppendLine("Electric Appliances:");
                stringBuilder.AppendLine(appliances.ToString());
            }
            if (books.Length > 0)
            {
                stringBuilder.AppendLine("Books:");
                stringBuilder.AppendLine(books.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}