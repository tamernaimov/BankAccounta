using System;
using BankAccounta;

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Иван Иванов", "BG80BNBG96611020345678", 1000);

        Console.WriteLine(account1);
    }
}