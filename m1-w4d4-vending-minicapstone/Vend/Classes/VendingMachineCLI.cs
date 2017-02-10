using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vend.Classes;
using System.Runtime.InteropServices;

namespace Vend.Classes
{
    public class VendingMachineCLI
    {
        private VendMachine vm = new VendMachine();
        public VendingMachineCLI(VendMachine vendingMachine)
        {
            vm = vendingMachine;
        }

        LogWriter lw = new LogWriter();
        SalesReportWriter salesreport = new SalesReportWriter();
        Change ch = new Change();
        double totalBalance = 0.00;

        public void mainMenu()
        {
            totalBalance = vm.getBalance;
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"**************** VENDO-MATIC 500 ****************");
            Console.WriteLine($"*************************************************\n");

            while (true)

            {

                Console.WriteLine($"********* MAIN MENU *********\n");
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase");
                Console.WriteLine("\n9) Exit Program");
                Console.Write($"\nPlease enter either a 1, 2, or 9: ");

                Int16 tempInput;
                int userInput = 0;

                if (Int16.TryParse(Console.ReadLine(), out tempInput))
                {
                    userInput = tempInput;
                }
                else
                {
                    Console.WriteLine($"Invalid selection\n");
                }

                if (tempInput == 1)
                {
                    vm.displayItems();
                }
                else if (tempInput == 2)
                {
                    vm.displayItems();
                    Menu2();
                }
                else if (tempInput == 9)
                {
                    double change1 = ch.MakeChange(vm.getBalance);
                    string msgLog = "Your remaining change is:  $" + change1.ToString("F");
                    lw.LogWriterMethod(msgLog);
                    break;
                }
                else
                {
                    Console.WriteLine($"Not a valid selection. Please try again.\n\n");

                }
            }
        }
        public void Menu2()
        {
            while (true)
            {
                Console.WriteLine($"********* PLEASE MAKE A SELECTION *********\n");
                Console.WriteLine($"Current Balance: ${vm.getBalance.ToString("F")} \n");
                Console.WriteLine("1) Feed Money");
                Console.WriteLine("2) Select Product");
                Console.WriteLine("\n9) Finish Transaction");
                Console.Write($"\nPlease enter either a 1, 2, or 9: ");


                // this if statement will reject non-int invalid inputs
                Int16 tempInput;
                int userInput = 0;

                if (Int16.TryParse(Console.ReadLine(), out tempInput))
                {
                    userInput = tempInput;
                }
                else
                {
                    Console.WriteLine($"Invalid selection\n");
                }


                if (userInput == 1)
                {
                    Console.WriteLine("You entered 1.\n");
                    vm.FeedMoney();
                }
                else if (userInput == 2)
                {
                    // display items available for purchase
                    vm.displayItems();
                    vm.selectProduct();
                    lw.LogWriterMethod(vm.LogFileString);
                }
                else if (userInput == 0)
                {
                    // technician method
                    salesreport.SaleReportWriterMethod(vm.SalesReportDictionary, vm.TotalPurchased);
                }
                else if (userInput == 9)
                {
                    //double change1 = ch.MakeChange(vm.getBalance);
                    //string msgLog = "Your remaining change is: " + change1.ToString();
                    //lw.LogWriterMethod(msgLog);
                    break;
                }
                else
                {
                    Console.WriteLine($"Not a valid selection. Please try again.\n\n");

                }
            }
        }
    }
}

