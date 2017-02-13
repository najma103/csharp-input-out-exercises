using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Vend;
using Vend.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendTest.TestClasses
{

    [TestClass]
    public class VendMachineTest
    {
        VendingMachineFileReader reader = new VendingMachineFileReader();
        //VendingMachineItems vmi = new VendingMachineItems();
        VendMachine vm = new VendMachine();
        public Dictionary<string, VendingMachineItems> vmItems = new Dictionary<string, VendingMachineItems>();

        [TestMethod]
        public void TestDisplayProduct()
        {
            vm.VmItems = reader.Items;
            vmItems = reader.Items;
            vm.displayItems();
            Assert.AreEqual(vmItems, vm.VmItems);
        }

        [TestMethod]
        public void TestSelectProduct()
        {
            vm.VmItems = reader.Items;
            vmItems = reader.Items;
            string key = "A1";
            string actual = "Potato Crisps";
            string expected = vm.VmItems[key].Name.ToString();
            CollectionAssert.AllItemsAreUnique(vm.VmItems);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateBalance()
        {
            vm.balance = 40;
            Assert.AreEqual(40, vm.getBalance);
            Assert.AreEqual(15, vm.CalTotal(3.0, 5));

        }
    }
}
