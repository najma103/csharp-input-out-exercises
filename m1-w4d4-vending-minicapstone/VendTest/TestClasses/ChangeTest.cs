using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vend.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendTest.TestClasses
{
    [TestClass]
    public class ChangeTest
    {
        Change test1 = new Change();

        [TestMethod]
        public void ChangeTestMethod()
        {
            test1.Quarters = 10;
            double quarter = test1.Quarters;
            test1.Dimes = 5;
            double dimes = test1.Dimes;
            //double change = test1.MakeChange(2.50);
            Assert.AreEqual(dimes, test1.Dimes);
            Assert.AreEqual(quarter, test1.Quarters);
        }
    }
}
