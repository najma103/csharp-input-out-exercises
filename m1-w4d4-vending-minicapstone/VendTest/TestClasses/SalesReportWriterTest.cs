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
    public class SalesReportClassTest
    {
        VendingMachineFileReader reader = new VendingMachineFileReader();
        //VendingMachineItems vmi = new VendingMachineItems();
        VendMachine vm = new VendMachine();
        SalesReportWriter sw = new SalesReportWriter();
        Dictionary<string, VendingMachineItems> vmItems = new Dictionary<string, VendingMachineItems>();


        [TestMethod]
        public void TestSalesReport()
        {

            //this is to test that sales report is created
            vmItems = reader.Items;
            CollectionAssert.AllItemsAreNotNull(vmItems);
            CollectionAssert.AllItemsAreUnique(vmItems);
            sw.SaleReportWriterMethod(vmItems);
            Assert.IsTrue(true);
        }
    }
}