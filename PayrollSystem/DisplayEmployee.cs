using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class DisplayEmployee
    {
        public void displayTableAllEmployees(List<Employee> listOfEmployee)
        {
            if (listOfEmployee.Count < 1)
            {
                Console.WriteLine("There are not employees in the list");
            }
            else
            {
                string h = "Name";
                string l = "ID";
                string r = "Address";
                string t = "Type";
                string p = "Payment method";

                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| " + String.Format("   {0,-10}|", l) + String.Format("   {0,-20}|", h) +
                                String.Format("   {0,-10}|", t) + String.Format("   {0, -20}|", p) +
                                String.Format("   {0,-30}|", r));
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                foreach (Employee employee in listOfEmployee)
                {
                    Console.WriteLine("|" + String.Format(" {0,-13}|", employee.EmployeeID) + String.Format(" {0,-22}|", employee.EmployeeLName) +
                                 String.Format(" {0,-12}|", employee.EmployeeType) + String.Format(" {0, -22}|", employee.EmployeePaymethod) +
                                 String.Format(" {0,-32}|", employee.EmployeeAddress));
                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            }
        }

        public void displaySalariedEmployee(List<Employee> listOfEmployee)
        {
            List<Employee> salaried = new List<Employee>();
            // get the salaried employees first
            foreach (Employee employee in listOfEmployee)
            {
                if (employee.EmployeeType == "salary")
                {
                    salaried.Add(employee);
                }
            }


            string h = "Name";
            string l = "ID";
            string r = "Address";
            string t = "Type";
            string p = "Payment method";

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| " + String.Format("   {0,-10}|", l) + String.Format("   {0,-20}|", h) +
                            String.Format("   {0,-10}|", t) + String.Format("   {0, -20}|", p) +
                            String.Format("   {0,-30}|", r));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            foreach (Employee employee in salaried)
            {
                Console.WriteLine("|" + String.Format(" {0,-13}|", employee.EmployeeID) + String.Format(" {0,-22}|", employee.EmployeeLName) +
                             String.Format(" {0,-12}|", employee.EmployeeType) + String.Format(" {0, -22}|", employee.EmployeePaymethod) +
                             String.Format(" {0,-32}|", employee.EmployeeAddress));
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }

        public void displayHourlyEmployee(List<Employee> listOfEmployee)
        {
            List<Employee> hourly = new List<Employee>();
            // get the salaried employees first
            foreach (Employee employee in listOfEmployee)
            {
                if (employee.EmployeeType == "hourly")
                {
                    hourly.Add(employee);
                }
            }


            string h = "Name";
            string l = "ID";
            string r = "Address";
            string t = "Type";
            string p = "Payment method";

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| " + String.Format("   {0,-10}|", l) + String.Format("   {0,-20}|", h) +
                            String.Format("   {0,-10}|", t) + String.Format("   {0, -20}|", p) +
                            String.Format("   {0,-30}|", r));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            foreach (Employee employee in hourly)
            {
                Console.WriteLine("|" + String.Format(" {0,-13}|", employee.EmployeeID) + String.Format(" {0,-22}|", employee.EmployeeLName) +
                             String.Format(" {0,-12}|", employee.EmployeeType) + String.Format(" {0, -22}|", employee.EmployeePaymethod) +
                             String.Format(" {0,-32}|", employee.EmployeeAddress));
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }

        public void displayCommissionEmployee(List<Employee> listOfEmployee)
        {
            List<Employee> commission = new List<Employee>();
            // get the salaried employees first
            foreach (Employee employee in listOfEmployee)
            {
                if (employee.EmployeeType == "commission")
                {
                    commission.Add(employee);
                }
            }


            string h = "Name";
            string l = "ID";
            string r = "Address";
            string t = "Type";
            string p = "Payment method";

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| " + String.Format("   {0,-10}|", l) + String.Format("   {0,-20}|", h) +
                            String.Format("   {0,-10}|", t) + String.Format("   {0, -20}|", p) +
                            String.Format("   {0,-30}|", r));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            foreach (Employee employee in commission)
            {
                Console.WriteLine("|" + String.Format(" {0,-13}|", employee.EmployeeID) + String.Format(" {0,-22}|", employee.EmployeeLName) +
                             String.Format(" {0,-12}|", employee.EmployeeType) + String.Format(" {0, -22}|", employee.EmployeePaymethod) +
                             String.Format(" {0,-32}|", employee.EmployeeAddress));
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }


}
