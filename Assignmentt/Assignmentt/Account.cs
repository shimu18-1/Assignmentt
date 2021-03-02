using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(string accountName, int accountNumber, double balance, Address address)
        {   this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount; ;
            }
            else { Console.WriteLine("Insufficient Balance!"); }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            else { Console.WriteLine("Invalid amount!"); }
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",
                               this.accountNumber, this.accountName, this.balance);

            Console.WriteLine("Address: " + address.GetAddress());
        }

        ~Account()
        {
            this.balance = 0;
        }

    }
}
