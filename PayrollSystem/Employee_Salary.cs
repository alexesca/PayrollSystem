using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Employee_Salary : Employee
    {
        private string payMethod { get; set; }

        Employee_Salary()
        {

        }

        public string PaymentMethod (String payMethod)
        {
            if (employee_Paymethod == "Email")
            {
                return payMethod= "It will sent to this addres";
            }
            if (employee_Paymethod == "Direct Deposit")
            {
                return payMethod = "Sent to Back";
            }
            return payMethod;
        }

      
    }
}



