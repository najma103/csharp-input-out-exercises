using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vend.Classes
{
    public class VendMachine
    {
        VendingMachineItems vmi = new VendingMachineItems();
        //dictionary for sales report
        private Dictionary<string, int> salesReportDictionary = new Dictionary<string, int>();
        public Dictionary<string,int> SalesReportDictionary
        {
            get { return salesReportDictionary; }
            set { salesReportDictionary = value; }
        }

        //Change changeBalance = new Change();
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
            Console.WriteLine("Slot #\t Desc\t\t Price\t Quantity\t");
            foreach (var key in vmItems.Keys)
            {
                Console.WriteLine("{0}: \t{1}\t ${2}\t {3}", key, VmItems[key].Name.ToString(),
                    VmItems[key].Price.ToString(), VmItems[key].Quantity.ToString());
            }
        }

        public void selectProduct()
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
                else if (balance < calTotal(price, tempQuantity))
                {
                    Console.WriteLine($"\nInsufficient funds. Please insert more money to machine.");
                }
                else if (tempQuantity > 0 && tempQuantity <= 5 && (VmItems[choice].Quantity >= tempQuantity))
                {
                    Console.WriteLine("You have purchased " + tempQuantity + " "
                        + VmItems[choice].Name.ToString() + " and your total is: "
                        + "$" + calTotal(price, tempQuantity).ToString("F"));
                    UpdateRemainingQuantity(choice, tempQuantity);
                    UpdateRemainingBalance(calTotal(price, tempQuantity));

                    //build string for logwriter 
                    PrintLogFile(choice, tempQuantity, price);

                    // Add to the Sales report dictionary
                    PrintSalesReport(choice, tempQuantity, price);
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
                //+ VmItems[choice].Price.ToString()
                + VmItems[choice].Price.ToString()
                + " :: Total purchased  $" + calTotal(price, quantity);
        }

        public void PrintSalesReport(string choice, int quantity, double price)
        {
  
            foreach (var key in vmItems.Keys)
            {
                if (VmItems[key].Quantity == 5)
                {
                    SalesReportDictionary[VmItems[choice].Name] = 0;
                }
                else
                {
                    SalesReportDictionary[VmItems[choice].Name] =  quantity;
                    UpdateTotalPurchased(calTotal(price, quantity));

                }
            }
        }
        public double calTotal(double price, int quantity)
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

            Console.WriteLine($"You added ${tempBalance.ToString("F")} to your account. You now have ${balance.ToString("F")} available.\n\n");
            return balance;

        }
    }
}
