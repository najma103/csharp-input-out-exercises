using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Vend;
using Vend.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendTest.TestClasses
{
    /// <summary>
    /// Summary description for LogWritterClassTest
    /// </summary>
    [TestClass]
    public class LogWritterClassTest
    {
        LogWriter logWriter = new LogWriter();

        string strMsg = "This is to test that a log file is created. ";


        [TestMethod]
        public void CreateLogFile()
        {
            logWriter.LogWriterMethod(strMsg);
            Assert.IsTrue(true);
        }
    }
}