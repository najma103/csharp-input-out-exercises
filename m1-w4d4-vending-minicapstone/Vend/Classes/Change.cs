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

        public double MakeChange()
        {
            Console.Write($"Please enter a value: ");
            string userInput = Console.ReadLine();
            totalBalance = double.Parse(userInput);
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
            

            Console.WriteLine($"\n\nQuarters: {quarters}\nDimes: {dimes}\nNickels: {nickels}");
            Console.ReadKey();


            return totalBalance;
        }


    }
}
