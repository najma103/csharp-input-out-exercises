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
        [TestMethod]
        public void ChangeTestMethod()
        {
            Change test1 = new Change();               

            double quarters = 10;

            Assert.AreEqual(quarters, test1.MakeChange(250));
        }
    }
}
