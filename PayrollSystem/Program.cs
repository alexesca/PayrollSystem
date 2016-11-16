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
        static private IDGenerator createID = new IDGenerator();
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
                            Console.WriteLine("\nPlease add the employee name");
                            name = Console.ReadLine();
                            Console.WriteLine("\nPlease add the employee address");
                            address = Console.ReadLine();
                            Console.WriteLine("\nPlease select the employee type:");
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
                            id = createID.generateID(listOfEmployee);
                            Console.WriteLine("\nGenerated ID: " + id);
                            Console.WriteLine("\nPlease add the employee paymethod");
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
                                Console.WriteLine("Choose the table you want to show:\n1.All\n2.Salaried\n3.Hourly\n4.Commission");
                                string choice = Console.ReadLine();
                                switch (choice)
                                {
                                    case "1":
                                        {
                                            new DisplayEmployee().displayTableAllEmployees(listOfEmployee);
                                            break;
                                        }
                                    case "2":
                                        {
                                            new DisplayEmployee().displaySalariedEmployee(listOfEmployee);
                                            break;
                                        }
                                    case "3":
                                        {
                                            new DisplayEmployee().displayHourlyEmployee(listOfEmployee);
                                            break;
                                        }
                                    case "4":
                                        {
                                            new DisplayEmployee().displayCommissionEmployee(listOfEmployee);
                                            break;
                                        }
                                    default:
                                        {
                                            new DisplayEmployee().displayHourlyEmployee(listOfEmployee);
                                            break;
                                        }
                                     
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
