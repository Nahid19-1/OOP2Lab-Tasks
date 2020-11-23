using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new FixedAccount("1237", "kajol K", 50000.00, 25, 2015,5);
            a1.ShowInfo();
            Account a2 = new SpecialSavings("325", "Nahid", 500, 20);
            a2.ShowInfo();
            Account a3 = new Overdraft("007", "Sakib", 500, 20);
            a3.ShowInfo();
        }
    }
}
