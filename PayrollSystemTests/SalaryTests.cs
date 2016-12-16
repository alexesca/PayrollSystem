using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryTests
{
    [TestClass()]
    public class SalaryTests
    {
      

        [TestMethod()]
        public void EmployeeSalaryTest1()
        {
            Employee_Salary testEmployeeSalary = new Employee_Salary("1234", "John Smith", "123 Shadow Wood UT", "Mail",
                0.05, true);
            Assert.AreEqual(testEmployeeSalary.EmployeeLName, "John Smith");
            Assert.AreEqual(testEmployeeSalary.EmployeePaymethod, "Mail");
        }

        [TestMethod()]
        public void EmployeeSalarySalary()
        {
            Employee_Salary testEmployeeSalary = new Employee_Salary("1234", "John Smith", "123 Shadow Wood UT",
                "Pick up", 0.05, true);
            string methodPayment = testEmployeeSalary.EmployeePaymethod;

            Assert.AreEqual( methodPayment, "Pick up");
        }
    }
}