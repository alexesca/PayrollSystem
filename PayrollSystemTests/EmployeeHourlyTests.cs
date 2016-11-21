using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Tests
{
    [TestClass()]
    public class EmployeeHourlyTests
    {
        [TestMethod()]
        public void EmployeeHourlyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EmployeeHourlyTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void calculatePaymentTest()
        {
            EmployeeHourly testEmp = new EmployeeHourly("Juan Perez", "12345", "Nunnya business", "Mailed check", 7.5);
            
            Assert.AreEqual(testEmp.PeriodPaymentAmount, 0);
        }

        [TestMethod()]
        public void addTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getReportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void payEmployeeTest()
        {
            Assert.Fail();
        }
    }
}