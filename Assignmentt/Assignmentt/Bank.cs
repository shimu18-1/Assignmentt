using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    class Bank
    {


        private string bankName;
        public Account[] accounts;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[size];
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }

        }

        public void DeleteAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    Console.WriteLine(accounts[i].AccountNumber);
                    break;
                }
            }
            Console.WriteLine("Account number missing.");
        }

        public void PrintAcountDetails(int accountNumber)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    accounts[i].ShowAccountInformation();
                    break;
                }

            }

        }





    }
}
