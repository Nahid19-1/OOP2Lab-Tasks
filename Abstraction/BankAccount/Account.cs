using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    abstract class Account
    {
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        protected double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int Tran { get; set; }
        public Account()
        {

        }
        public Account(string accNo, string accName, double balance,int Tran)
        {
            this.accNo = accNo;
            this.accName = accName;
            this.balance = balance;
            this.Tran = Tran;
        }

   
        abstract public void Withdraw(double amount);

        virtual public void Overdraft(double balance)
        {
            this.balance = balance;
        }
       
        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc  Name :" + accName);
            Console.WriteLine("Acc  No :" + accNo);
            Console.WriteLine("Balance:" + balance);
            Console.WriteLine("Number of Transaction:" + Tran);
        }

    }
}
