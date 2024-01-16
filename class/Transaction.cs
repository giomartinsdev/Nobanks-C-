using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBanksCsharp
{
    public class Transaction(Account OriginAccount, Account TargetAccount, float Value)
    {
        public void MakeTransaction(){
            if (Value > OriginAccount.Balance){
                Console.WriteLine("Valor da transferencia nao pode ser maior que o seu saldo");
            }
            else{
                OriginAccount.Withdraw(Value);
                TargetAccount.Deposit(Value);    
            }
        }
    }
}