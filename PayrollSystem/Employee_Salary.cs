using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
   public class Employee_Salary : Employee
    {
        private string payment { get; set; }

        public Employee_Salary()
        {

        }

        private string PayCheckMethod(string paymethod)
        {
            if (paymethod == "Pick up")
            {
                payment = "Your payment is held by the paymaster to pick up";
                return payment;
            }
            if (paymethod == "Mail")
            {
                payment = "Your check will be sent to " + employee_Address;
                return payment;
            }
            if (paymethod == "DirectDeposite")
            {
                payment = "Your check will sent to your direct deposit";
                return payment;
            }
            else
            {
                return payment = "You didn't select a payment method";
            }
        }
    }
}

