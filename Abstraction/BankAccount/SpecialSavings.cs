using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
     class SpecialSavings : Account
    {
        public SpecialSavings()
        {

        }
        public SpecialSavings(string accNo, string accName, double balance, int Tra) : base(accNo, accName, balance,Tra)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= amount*.2)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance less than 20%");
        }
        public override void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("This is  SpecialSavings info");
            base.ShowInfo();
            
            
        }
    }
}

