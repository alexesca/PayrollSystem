using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
   public class Employee_Salary : Employee
    {
        private string paymentSalary { get; set; }

        //Defoult Employ Constructor
        public Employee_Salary()
        {
            this.paymentSalary = "No Payment Method has been selected";
        }
        //Crete an employ 
        public Employee_Salary(String newID, String newName, String newAddress,
          String newPayMethod, double newRate, Union newEmployeeUnion)
        // protected Union employee_Union;
        {
            employee_ID = newID;
            employee_Name = newName;
            employee_Address = newAddress;
            employee_Paymethod = newPayMethod;
            employee_Type = "Commission";
            employee_Union = newEmployeeUnion;
        }

        private string PayCheckMethod(string paymethod)
        {
            if (paymethod == "Pick up")
            {
                paymentSalary = "Your payment is held by the paymaster to pick up";
                return paymentSalary;
            }
            if (paymethod == "Mail")
            {
                paymentSalary = "Your check will be sent to " + employee_Address;
                return paymentSalary;
            }
            if (paymethod == "DirectDeposite")
            {
               
                paymentSalary = "Your check will sent to your direct deposit";
                return paymentSalary;
            }
            else
            {
                return paymentSalary = "You didn't select a payment method";
            }
        }
    }
}

