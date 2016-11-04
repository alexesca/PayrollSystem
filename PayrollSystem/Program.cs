using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee_Hourly Axan = new Employee_Hourly();
            CommEmployee Miranda = new CommEmployee();

            Console.WriteLine(Axan.EmployeeID);

            Console.ReadLine();
        }
    }
}
