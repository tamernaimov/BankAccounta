using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounta
{
    internal class BankAccount
    {
        private string ownerName;
        private double balance;
        private string iban;

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Името на собственика не може да бъде празно.");
                ownerName = value;
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Балансът не може да бъде отрицателен.");
                balance = value;
            }
        }

        public string IBAN
        {
            get { return iban; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 22)
                    throw new ArgumentException("IBAN трябва да е точно 22 символа.");
                iban = value;
            }
        }

        public BankAccount(string ownerName, string iban, double balance = 0)
        {
            OwnerName = ownerName;
            IBAN = iban;
            Balance = balance;
        }
        public override string ToString()
        {
            return $"Собственик: {OwnerName}, IBAN: {IBAN}, Баланс: {Balance:F2} лв.";
        }
    }
}
