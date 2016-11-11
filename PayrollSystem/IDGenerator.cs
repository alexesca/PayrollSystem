using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class IDGenerator
    {
        public IDGenerator()
        {

        }

        public string generateID(List<Employee> employees)
        {
            return "emp"+employees.Count;
        }
    }
}
