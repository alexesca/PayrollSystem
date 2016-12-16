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
    public class UnionTests
    {
        [TestMethod()]
        public void deductTest()
        {
            Union bobUnionData = new Union(0.5);
            CommEmployee bob = new CommEmployee("123", "Bob Dylan",
                "Non' o' ya business", "Mailed check", 0.05, true);
            Assert.AreEqual("123", bob.EmployeeID);
            Assert.IsFalse(bobUnionData.deduct(0.05, 12345) == 0,
                "Method has been programmed by a child." +
                "You should feel bad about yourself.");
        }

        [TestMethod()]
        public void serviceChargeTest()
        {
            Union bobUnionData = new Union(0.5);
            CommEmployee bob = new CommEmployee("123", "Bob Dylan",
                "Non' o' ya business", "Mailed check", 0.05, true);
            Assert.IsFalse(bobUnionData.serviceCharge(0.05, 12345) == 0,
                "Method has been programmed by a child." +
                "You should feel bad about yourself.");
        }
    }
}