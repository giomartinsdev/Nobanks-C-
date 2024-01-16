using System;
using NoBanksCsharp;

class Program
{
    static void Main() {
        Account account1 = new("123456789", "123456", "checking", 1234, "NoBanks", 854.25F, DateTime.Now);
        Account account2 = new("987654321", "654321", "savings", 4321, "NoBanks", 444.35F, DateTime.Now);
        Owner owner = new("Rafael", "rafa@gmail.com", "123456789", "21999999999", "Rua dos bobos, 0");
        owner.LinkAccountToPerson(account1);
        owner.LinkAccountToPerson(account2);

        bool menu = true;
        do
        {
            Console.WriteLine("Digite uma opcão para realizar uma ação: ");
            Console.WriteLine("(1) Transferir valor entre as contas \n(2) Mostrar dados das contas \n(3) Terminar aplicacao");

            // pega o input do usario e tenta transformar em int, armazenando na variavel inputChoice, caso de errado ele roda o else la em baixo
            if (int.TryParse(Console.ReadLine(), out int inputChoice)) {
                switch (inputChoice) {
                    case 1:
                        Console.WriteLine("Entre com o valor a ser transferido: ");
                        if (int.TryParse(Console.ReadLine(), out int valueOfTransaction)) {
                            Transaction transaction1 = new(account1, account2, valueOfTransaction);
                            transaction1.MakeTransaction();
                        }
                        else {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                        }
                        break;
                    case 2:
                        owner.DisplayAccounts();
                        break;
                    case 3:
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    }
            }
            else {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

        } while (menu);
    }
}
