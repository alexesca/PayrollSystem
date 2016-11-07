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
    public class CommEmployeeTests
    {
        [TestMethod()]
        public void CommEmployeeTest()
        {
            CommEmployee testEmp = new CommEmployee
                ("1234", "John Smith", "123 Shadow Wood UT", "Mailed check", "Commission", 0.05);
            Assert.AreEqual(testEmp.commRate, 0.05);
            Assert.AreEqual(testEmp.EmployeeName, "John Smith");
        }

        [TestMethod()]
        public void CommEmployeeTest1()
        {
            CommEmployee testEmp = new CommEmployee();
            Assert.AreEqual(testEmp.EmployeeID, "0000");
            Assert.AreEqual(testEmp.commRate, 0);
        }

        [TestMethod()]
        public void calcPaymentTest()
        {
            CommEmployee testEmp = new CommEmployee
                ("1234", "John Smith", "123 Shadow Wood UT", "Mailed check", "Commission", 0.05);

            double expected = 77.3;
            double actual = testEmp.calcPayment(0.05, 1546);

            Assert.AreEqual(expected, Math.Round(actual,1));
        }
    }
}