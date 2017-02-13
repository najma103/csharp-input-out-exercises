using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;

namespace VendTest.TestClasses
{
    [TestClass]
    public class VendMachineTest
    {
        [TestMethod]
        public void DisplayItemTestMethod()
        {
            VendMachine test1 = new VendMachine();

            //string testoutput = "testoutput";
            //string displayItems = "";


            //Assert.AreEqual(testoutput, test1.displayItems());
        }
    }
}


//public void displayItems()
//{
//    Console.WriteLine("Slot #\t Desc\t\t Price\t \tQuantity\t");
//    foreach (var key in vmItems.Keys)
//    {
//        Console.Write("{0}: \t{1}\t ${2}\t", key, VmItems[key].Name.ToString(),
//            VmItems[key].Price.ToString());
//        if (VmItems[key].Quantity == 0)
//        {
//            Console.Write("\t**SOLD OUT**");
//        }
//        else
//        {
//            Console.Write("\t" + VmItems[key].Quantity.ToString());
//        }
//        Console.WriteLine();
//    }
