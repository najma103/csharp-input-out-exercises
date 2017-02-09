using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendingMachineCLI
    {
        public void VendMethod()
        {
            VendMachine vendMethod = new VendMachine();
            Change balance = new Change();

            VendMachine tempBalance = new VendMachine();
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"**************** VENDO-MATIC 500 ****************");
            Console.WriteLine($"*************************************************\n");

            while (true)

            {
                double totalBalance = vendMethod.getBalance();
                Console.WriteLine($"********* PLEASE MAKE A SELECTION *********\n");
                Console.WriteLine($"Current Balance: ${totalBalance.ToString("F")} \n");
                Console.WriteLine("1) Feed Money");
                Console.WriteLine("2) Purchase Items");
                Console.WriteLine("\n9) Exit Menu");
                Console.Write($"\nPlease enter either a 1 or 2: ");


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
