using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem.Hourly_classes;
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
            //Assert.Fail();
        }

        [TestMethod()]
        public void EmployeeHourlyTest1()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void calculatePaymentTest()
        {
            EmployeeHourly testEmp = new EmployeeHourly("Juan Perez", "Emp1", "560 Idaho Avenue, Provo UT", "Mailed check", 7.5);
            Assert.AreEqual(testEmp.EmployeeName, "Juan Perez");
            Assert.AreEqual(testEmp.EmployeeID, "Emp1");
            Assert.AreEqual(testEmp.EmployeePaymethod, "Mailed check");
            Assert.AreEqual(testEmp.EmployeeAddress, "560 Idaho Avenue, Provo UT");
            Assert.AreEqual(testEmp.HourlyPay, 7.5);
            Assert.AreEqual(testEmp.PeriodPaymentAmount, 0);
        }

        [TestMethod()]
        public void addTimeTest()
        {
            EmployeeHourly testEmp = new EmployeeHourly("Juan Perez", "Emp1", "560 Idaho Avenue, Provo UT", "Mailed check", 7.5);
            double time = 5;
            double  amount = testEmp.addTime(time);
            Assert.AreEqual(testEmp.PeriodPaymentAmount, 37.5);
        }

        [TestMethod()]
        public void getReportTest()
        {
            //Assert.Fail();
        }

    }
}