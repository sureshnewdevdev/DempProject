using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCDemoMuishMulla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoMuishMulla.Tests
{
    [TestClass()]
    public class LogicLibTests
    {
        LogicLib lib = new LogicLib();

        [TestMethod()]
        public void GetPageTileTest()
        {
            Assert.AreEqual("ABC Company", lib.GetPageTile());
        }

        [TestMethod()]
        public void GetMonthTest()
        {
            string dt = "10/10/2023";
            DateTime date= DateTime.Parse(dt);
            string monthNumber = lib.GetMonth(date);
            Assert.AreEqual("10", monthNumber);
        }
    }
}