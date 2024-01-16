using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBanksCsharp
{
    public class Owner
    {  
        private List<Account> accounts = new();
        public String Name { get; set; }
        public String Email { get; set; }
        public String DocumentNumber { get; set; }
        public String Cellphone { get; set;}
        public String Address { get; set; }
        public int CreditScore { get; set; }
        public float CrossBalance => accounts.Sum(a => a.Balance);
        
        public void LinkAccountToPerson(Account account){
            accounts.Add(account);
        }

        public void DisplayAccounts(){
            Console.WriteLine("---------------Accounts Info---------------");
            foreach (var account in accounts)
            {
                Console.WriteLine("Dados referentes a conta de número -> " + account.AccountNumber);
                account.DisplayAccountInfo();
            }
            Console.WriteLine("Cross Balance: " + CrossBalance);
        }
    }
}