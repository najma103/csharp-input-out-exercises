using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vend.Classes
{
    public class VendMachine
    {

        Change changeBalance = new Change();
        public double balance = 0.00;
        public double getBalance
        {
            get { return balance; }
        }

        Dictionary<string, VendingMachineItems> machine = new Dictionary<string, VendingMachineItems>();

        public VendMachine()
        {

        }
        public VendMachine(Dictionary<string, VendingMachineItems> items)
        {
            machine = items;
        }

        public string DisplayItems()
        {

        }
        public double FeedMoney()
        {
            Console.Write("Please enter a valid dollar amount (in 0.00 format): ");
            double tempBalance = 0.00;
            try { 

            tempBalance = double.Parse(Console.ReadLine());
            balance += tempBalance;

            }
            catch
            {
                Console.WriteLine("Not a valid dollar amount. Use dollar.cents format");
                FeedMoney();
            }

            Console.WriteLine($"You added ${tempBalance.ToString("F")} to your account. You now have ${balance.ToString("F")} available.\n\n");
            return balance;

        }
    }
}
