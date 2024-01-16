using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBanksCsharp
{
    public class Owner(string Name, string Email, string DocumentNumber, string Cellphone, string Address)
    {  
        private List<Account> accounts = new();
        public int CreditScore { get; set; }
        public float CrossBalance => accounts.Sum(a => a.Balance);
        
        public void LinkAccountToPerson(Account account){
            accounts.Add(account);
        }

        public void DisplayAccounts(){
            Console.WriteLine("---------------Accounts Info---------------");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("DocumentNumber: " + DocumentNumber);
                Console.WriteLine("Cellphone: " + Cellphone);
                Console.WriteLine("Address: " + Address);
                Console.WriteLine("\n");
            
            foreach (var account in accounts)
            {
                Console.WriteLine("Dados referentes a conta de número: " + account.AccountNumber);

                account.DisplayAccountInfo();
            }
            Console.WriteLine("Cross Balance: " + CrossBalance);
        }
    }
}