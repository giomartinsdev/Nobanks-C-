using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBanksCsharp
{
    public class Transaction
    {
        public Account OriginAccount { get; set; }
        public Account TargetAccount{ get; set; }
        public float Value { get; set; }

        public void MakeTransaction(){
            if (Value >= TargetAccount.Balance){
                OriginAccount.Withdraw(Value);
                TargetAccount.Deposit(Value);
            }
            else{
                Console.WriteLine("Valor da transferencia nao pode ser maior que o seu saldo");
            }

        }

    }
}