﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vend.Classes
{
    public class VendMachine
    {

        private double totalPurchased = 0.0;
        public double TotalPurchased
        {
            get { return totalPurchased; }
            set { totalPurchased = value; }
        }
        private string logFileString = "";
        public string LogFileString
        {
            get { return logFileString; }
            set { logFileString = value; }
        }
        public double balance = 0.00;
        public double getBalance
        {
            get { return balance; }
            set { balance = value; }
        }
        public VendMachine()
        {
            VendingMachineItems vmi = new VendingMachineItems();
            
        }

        private Dictionary<string, VendingMachineItems> vmItems = new Dictionary<string, VendingMachineItems>();
        public Dictionary<string, VendingMachineItems> VmItems
        {
            get { return vmItems; }
            set { vmItems = value; }
        }
        public VendMachine(Dictionary<string, VendingMachineItems> items)
        {
            VmItems = items;
        }

        public void displayItems()
        {
            Console.WriteLine("Slot #\t Desc\t\t Price\t \tQuantity\t");
            foreach (var key in vmItems.Keys)
            {
                Console.Write("{0}: \t{1}\t ${2}\t", key, VmItems[key].Name.ToString(),
                    VmItems[key].Price.ToString() );
                if (VmItems[key].Quantity == 0)
                {
                    Console.Write("\t**SOLD OUT**");
                }
                else
                {
                    Console.Write("\t"+VmItems[key].Quantity.ToString());
                }
                Console.WriteLine();
            }
        }

        public void SelectProduct()
        {

            Console.WriteLine("Please choose a product");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            if ((VmItems.ContainsKey(choice)))
            {
                Console.WriteLine("You have chosen " + VmItems[choice].Name.ToString());
                Console.Write("How many would you like? ");
                double price = double.Parse(VmItems[choice].Price.ToString());

                int tempQuantity = Int32.Parse(Console.ReadLine());

                if (VmItems[choice].Quantity == 0)
                {
                    Console.Write($"SOLD OUT. Please select a different item.\n");
                }
                else if (balance < CalTotal(price, tempQuantity))
                {
                    Console.WriteLine($"\nInsufficient funds. Please insert more money to machine.");
                }
                else if (tempQuantity > 0 && tempQuantity <= 5 && (VmItems[choice].Quantity >= tempQuantity))
                {
                    Console.WriteLine("You have purchased " + tempQuantity + " "
                        + VmItems[choice].Name.ToString() + " and your total is: "
                        + "$" + CalTotal(price, tempQuantity).ToString("F"));
                    UpdateRemainingQuantity(choice, tempQuantity);
                    UpdateRemainingBalance(CalTotal(price, tempQuantity));

                    //build string for logwriter 
                    PrintLogFile(choice, tempQuantity, price);
                }
                else
                {
                    Console.WriteLine("Sorry we do are unable to sell this quanity");
                }
            }
            else
            {
                Console.WriteLine($"Invalid selection. Please try again.\n");
            }
        }

        public void PrintLogFile(string choice, int quantity, double price)
        {
            //build string for logwriter 
            logFileString = choice + "\t"
                + VmItems[choice].Name + "\t "
                + quantity.ToString() + "\t"
                + VmItems[choice].Price.ToString()
                + "\t :: Total purchased \t $" + CalTotal(price, quantity);
        }

        public double CalTotal(double price, int quantity)
        {
            double total = price * quantity;
            return total;
        }
        public void UpdateRemainingBalance(double total)
        {
            getBalance -= total;
        }
        public void UpdateRemainingQuantity(string key, int tempQuantity)
        {
            VmItems[key].Quantity -= tempQuantity;
        }
        public void UpdateTotalPurchased(double totalPurchased)
        {
            TotalPurchased += totalPurchased;
        }
        public double FeedMoney()
        {
            Console.Write("Please enter a valid dollar amount (in 0.00 format): ");
            double tempBalance = 0.00;
            try
            {

                tempBalance = double.Parse(Console.ReadLine());
                balance += tempBalance;

            }
            catch
            {
                Console.WriteLine("Not a valid dollar amount. Use dollar.cents format");
                FeedMoney();
            }
            string msg = $"You added ${tempBalance.ToString("F")} to your account. You now have ${balance.ToString("F")} available.\n\n";
            
            Console.WriteLine(msg);
            return balance;

        }
    }
}
