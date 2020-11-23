using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
     class FixedAccount : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, double balance, int Tran, int createYear, int tenureYear) : base(accNo, accName, balance, Tran)
        {
            this.tenureYear = tenureYear;
            this.createYear = createYear;
        }
        public override void Withdraw(double amount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);
            if ((cyear - createYear) >= tenureYear)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Your account tenure year is not reach");

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }


    }
}

