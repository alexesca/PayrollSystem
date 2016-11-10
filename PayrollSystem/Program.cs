using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static public List<Employee> listOfEmployee = new List<Employee>();
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select what you want to do:");
                Console.WriteLine("1: Add new employee");
                Console.WriteLine("2: Display all the employees");
                Console.WriteLine("0: Finish Program");

                var selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        {
                            var name = "";
                            var type = "";
                            var address = "";
                            var paymethod = "";
                            var id = "";
                            EmployeeFactory factory = new EmployeeFactory();
                            Console.WriteLine("Please add the employee name");
                            name = Console.ReadLine();
                            Console.WriteLine("Please add the employee address");
                            address = Console.ReadLine();
                            Console.WriteLine("Please select the employee type:");
                            Console.WriteLine("1. Comission");
                            Console.WriteLine("2. Hourly");
                            Console.WriteLine("3. Salary");
                            type = Console.ReadLine();
                            switch (type)
                            {
                                case "1":
                                    type = "commission";
                                    break;
                                case "2":
                                    type = "hourly";
                                    break;
                                case "3":
                                    type = "salary";
                                    break;
                                default:
                                    type = "hourly";
                                    break;

                            }
                            Console.WriteLine("Please add the employee id");
                            id = Console.ReadLine();
                            Console.WriteLine("Please add the employee paymethod");
                            paymethod = Console.ReadLine();

                            Employee newEmployee = factory.getEmployee(type);
                            newEmployee.EmployeeName = name;
                            newEmployee.EmployeeID = id;
                            newEmployee.EmployeeAddress = address;
                            newEmployee.EmployeeType = type;
                            newEmployee.EmployeePaymethod = paymethod;

                            listOfEmployee.Add(newEmployee);

                        }
                        break;
                    case "2":
                        {
                            if (listOfEmployee.Count < 1)
                            {
                                Console.WriteLine("There are not employees in the list");
                            }
                            else
                            {
                                Console.WriteLine("There are: " + listOfEmployee.Count + " employees in the system");
                                Console.WriteLine("Here is their information");
                                foreach (Employee employee in listOfEmployee)
                                {
                                    Console.WriteLine("Employee's name: " + employee.EmployeeName);
                                    Console.WriteLine("Employee's address: " + employee.EmployeeAddress);
                                    Console.WriteLine("Employee's ID: " + employee.EmployeeID);
                                    Console.WriteLine("Employee's type: " + employee.EmployeeType);
                                    Console.WriteLine("Employee's paymethod: " + employee.EmployeePaymethod);
                                }

                            }


                        }
                        break;
                    case "0":
                        {
                            flag = false;
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
