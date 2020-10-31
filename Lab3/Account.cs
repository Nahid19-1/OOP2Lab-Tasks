using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Account
    {
        string accName;
        string acId;
        int balance;

        public string AccName
        {
            get
            {
                return accName;
            }
            set
            {
               accName = value;

            }
        }

        public string AcId
        { 
            get
            {
                return acId;
            }
            set
            {
                acId = value;

            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;

            }
        }
        internal void Showinfo()
        {

            Console.WriteLine("Account Name is :  " + accName);
            Console.WriteLine("Account Id is :  " + acId);
            Console.WriteLine("Account balance :  " + balance);



        }
       /* internal void Deposit()
        {
            balance += 
        }

        internal void Withdraw()
        {
            balance -=
        }
       */
    }
}
