using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vend.Classes;

namespace Vend
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachineFileReader reader = new VendingMachineFileReader();
            VendMachine vendingMachine = new VendMachine(reader.Items);
            VendingMachineCLI vending = new VendingMachineCLI(vendingMachine);

            vending.VendMethod();
        }
    }
}