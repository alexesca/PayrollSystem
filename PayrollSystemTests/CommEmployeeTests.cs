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
                ("1234", "John Smith", "123 Shadow UT", "Mailed check", 0.05);
            Assert.AreEqual(testEmp.commRate, 0.05);
            Assert.AreEqual(testEmp.EmployeeName, "John Smith");
            Assert.AreEqual(testEmp.EmployeeAddress, "123 Shadow UT");
            Assert.AreEqual(testEmp.EmployeeID, "1234");
            Assert.AreEqual(testEmp.EmployeePaymethod, "Mailed check");
            Assert.AreEqual(testEmp.commRate, 0.05);
        }

        [TestMethod()]
        public void CommEmployeeTest1()
        {
            CommEmployee testEmp = new CommEmployee();
            Assert.AreEqual(testEmp.EmployeeID, "0000");
            Assert.AreEqual(testEmp.EmployeeAddress, "Address");
            Assert.AreEqual(testEmp.EmployeeName, "Name");
            Assert.AreEqual(testEmp.commRate, 0);
        }

        [TestMethod()]
        public void calcPaymentTest()
        {
            CommEmployee testEmp = new CommEmployee
                ("1234", "John Smith", "123 Shadow UT", "Mailed check", 0.05);

            double expected = 77.3;
            double actual = testEmp.calcPayment(0.05, 1546);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, Math.Round(actual,1));
            
        }
    }
}