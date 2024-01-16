
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using NoBanksCsharp;

Owner owner = new()
{
    Name = "Rafael",
    Email = "rafa@gmail.com",
    DocumentNumber = "123456789",
    Address = "Rua dos bobos, 0"
};

Account account1 = new Account("123456789", "123456", "checking", 1234, "NoBanks", 854.25F, DateTime.Now);
Account account2 = new Account("987654321", "654321", "savings", 4321, "NoBanks", 444.35F, DateTime.Now);
owner.LinkAccountToPerson(account1);
owner.LinkAccountToPerson(account2);

bool menu = true;
while (menu == true)
{
    Console.WriteLine("Digite uma opcão para realizar uma ação: (1 = Transferir valor entre elas | 2 = mostrar dados das contas): ");
    String unparsedInputChoice = Console.ReadLine();
    int inputChoice = Int32.Parse(unparsedInputChoice);

    if (inputChoice == 1){
        Console.WriteLine("Entre com o valor a ser transferido: ");
        String unparsedValueOfTransaction = Console.ReadLine();
        int ValueOfTransaction = Int32.Parse(unparsedValueOfTransaction);
        Transaction transaction1 = new()
    {
        OriginAccount = account1,
        TargetAccount = account2,
        Value = ValueOfTransaction
    };
        transaction1.MakeTransaction();
    }
    else if (inputChoice == 2)
    {
        owner.DisplayAccounts();
        menu = false;   
    }
}

















