using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SavingsAccount saver1 = new SavingsAccount(2000);
            SavingsAccount saver2 = new SavingsAccount(3000);
            SavingsAccount.ModifyInterestRate(4);
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            Console.WriteLine(saver1.SavingBalance);





        }
    }
}
