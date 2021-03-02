using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Agrani Bank", 10);
            Address acc1 = new Address("03"," 5 / 21", "Dhaka","Bangladesh");
            Address acc2 = new Address("04", "7 / 30", "Tongi","Bangladesh");
            Address acc3 = new Address("05", "9 / 75", "Uttara","Bamgladesh");



            Account A1 = new Account("Sanjida", 1, 20000, acc1);
            Account A2 = new Account("Afroz", 2, 50000, acc2);
            Account A3 = new Account("Shimu", 3, 80000, acc3);

            bank.AddAccount(A1);
            bank.PrintAcountDetails(1);

            

            Console.ReadLine();

        }
    }
}
