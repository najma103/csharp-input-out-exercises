using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class Change
    {
        VendingMachineItems remainingBalance = new VendingMachineItems();

        private double quarters = 0;
        private double dimes = 0;
        private double nickels = 0;

        public double Quarters
        {
            get { return quarters; }
        }
        public double Dimes
        {
            get { return dimes; }
        }
        public double Nickels
        {
            get { return nickels; }
        }

        public double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void UpdateBalance(double balance)
        {
            this.balance += balance;
        }

        public double totalBalance = 0;

        public double MakeChange(double remainingBalance)
        {
            totalBalance = remainingBalance;
            totalBalance *= 100;

            while (totalBalance >= 25)
            {
                quarters++;
                totalBalance -= 25;
            }
            while (totalBalance >= 10)
            {
                dimes++;
                totalBalance -= 10;
            }
            while (totalBalance >= 5)
            {
                nickels++;
                totalBalance -= 5;
            }
            Console.WriteLine($"\nYour change is: ");
            Console.WriteLine($"Quarters: {quarters} Dimes: {dimes} Nickels: {nickels}");
            Console.WriteLine($"\n************************************************************");
            Console.WriteLine($"********** PLEASE PRESS ANY KEY TO EXIT PROGRAM **********");
            Console.ReadKey();

            return totalBalance;
        }
    }
}
