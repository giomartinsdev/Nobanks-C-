using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NoBanksCsharp
{
    public class Account
    {
        // Campos da classe
        public string AccountNumber;
        public string Password;
        public string Type;
        public int Agency;
        public string Bank;
        public float Balance;
        public DateTime CreatedAt;

        // Construtor da classe
        public Account(string AccountNumber, string Password, string Type, int Agency, string Bank, float Balance, DateTime CreatedAt)
        {
            this.AccountNumber = AccountNumber;
            this.Password = Password;
            this.Type = Type;
            this.Agency = Agency;
            this.Bank = Bank;
            this.Balance = Balance;
            this.CreatedAt = CreatedAt;
        }

        // Métodos da classe
        public void Deposit(float value) => Balance += value;

        public void Withdraw(float value) => Balance -= value;

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Password: " + Password);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Agency: " + Agency);
            Console.WriteLine("Bank: " + Bank);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("Created At: " + CreatedAt);
            Console.WriteLine("\n");
        }
    }
}