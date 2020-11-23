using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
     class Overdraft : Account
    {
        public Overdraft()
        {

        }
        public Overdraft(string accNo, string accName, double balance, int Tra) : base(accNo, accName, balance, Tra)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= amount)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance less than 20%");
        }
       /* public override void Overdraft(double balance)
        {
            base.Overdraft();
        }
       */
        public override void ShowInfo()
        {
            Console.WriteLine();
            base.ShowInfo();
            Console.WriteLine("With Overdraft Balance :"+ (balance+500));

       
        }
    }
}
