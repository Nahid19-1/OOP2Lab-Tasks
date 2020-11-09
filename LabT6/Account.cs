using System;
using System.Collections.Generic;
using System.Text;

namespace LabT6
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acid;

        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account() { 
        }
        public Account(string accName, string acid,int balance )
        {
            this.accName=accName;
            this.acid = acid;
            this.balance = balance;

        }
        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        virtual public void Deposit(int amount)
        {
            balance += amount;
        }

        
        private int receiver;

        public int Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }

        private int source;

        public int Source
        {
            get { return source; }
            set { source = value; }
        }


        public void Transfer(Account receiver, Account source,int amount)
        {

            this.source = source.balance;
            this.receiver = receiver.balance;

            if (this.source > amount)
            {
                this.source -= amount;
                this.receiver += amount;
            }
            else
                Console.WriteLine("Insufficient Balance");

        }




    }
}
