using System;
using System.Collections.Generic;

namespace NETInterfacesExercise_Models
{
    public class BankAccount : BaseClass
    {
        /// <summary>
        /// Gets or sets the IBAN (International Bank Account Number) for the account.
        /// </summary>
        public string IBAN { get; set; }

        /// <summary>
        /// Gets the current balance of the account.
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Gets the minimum allowable balance for the account.
        /// </summary>
        public double MinimumBalance { get; }

        /// <summary>
        /// Validates property values based on business rules.
        /// Returns an error message if validation fails; otherwise, an empty string.
        /// </summary>
        public override string this[string columnName]
        {
            get
            {
                if (columnName == nameof(IBAN) && string.IsNullOrWhiteSpace(IBAN))
                {
                    return "IBAN is a required field!";
                }
                else if (columnName == nameof(Balance) && Balance < MinimumBalance)
                {
                    return $"Balance cannot go below the minimum of {MinimumBalance}!";
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class with the specified IBAN.
        /// Sets the minimum balance to -100.
        /// </summary>
        /// <param name="iban">The IBAN number of the account.</param>
        public BankAccount(string iban)
        {
            IBAN = iban;
            MinimumBalance = -100;
        }

        /// <summary>
        /// Withdraws an amount from the account if it does not cause the balance to drop below the minimum balance.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <returns><c>true</c> if the withdrawal is successful; otherwise, <c>false</c>.</returns>
        public bool Withdraw(double amount)
        {
            double newBalance = Balance - amount;
            if (newBalance < MinimumBalance)
            {
                return false;
            }
            Balance = newBalance;
            return true;
        }

        /// <summary>
        /// Deposits the specified amount into the account.
        /// The deposit amount is treated as a positive value.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        public void Deposit(double amount)
        {
            Balance += Math.Abs(amount);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current bank account.
        /// Two bank accounts are considered equal if they have the same IBAN.
        /// </summary>
        /// <param name="obj">The object to compare with the current account.</param>
        /// <returns><c>true</c> if the accounts are equal; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is BankAccount account &&
                   IBAN == account.IBAN;
        }

        /// <summary>
        /// Returns a hash code for the bank account.
        /// </summary>
        /// <returns>A hash code based on the IBAN.</returns>
        public override int GetHashCode()
        {
            return 1502289438 + EqualityComparer<string>.Default.GetHashCode(IBAN);
        }

        /// <summary>
        /// Returns a string representation of the bank account, including the IBAN and current balance.
        /// </summary>
        /// <returns>A string describing the account's balance.</returns>
        public override string ToString()
        {
            return $"The balance of account {IBAN} is {Conversions.ConvertNumericToCurrency(Balance)}.";
        }
    }
}
