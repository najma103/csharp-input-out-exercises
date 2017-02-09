using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vend.Classes;

namespace Vend.Classes
{
    public class VendingMachineCLI
    {
        VendMachine vendMethod = new VendMachine();
        Change balance = new Change();
        VendMachine tempBalance = new VendMachine();
        double totalBalance = 0.00;
        

        public void VendMethod()
        {
            totalBalance = vendMethod.getBalance;
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"**************** VENDO-MATIC 500 ****************");
            Console.WriteLine($"*************************************************\n");

            while (true)

            {

                Console.WriteLine($"********* PLEASE MAKE A SELECTION *********\n");
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase");
                Console.WriteLine("\n9) Exit Menu");
                Console.Write($"\nPlease enter either a 1 or 2: ");

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

                }
                else if(tempInput == 2)
                {
                    Menu2();
                }
                else if (tempInput == 9)
                {
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
                Console.WriteLine($"Current Balance: ${vendMethod.getBalance.ToString("F")} \n");
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
                    vendMethod.FeedMoney();
                }
                else if (userInput == 2)
                {
                    // purchase items method
                }
                else if (userInput == 0)
                {
                    // technician method
                }
                else if (userInput == 9)
                {
                    // exit loop
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
