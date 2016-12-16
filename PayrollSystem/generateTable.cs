using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class GenerateTable
    {
        public GenerateTable()
        {

        }
        public DataTable toDataTable(List<Employee> employeeList)
        {
            List<Employee> employeeBalance = new List<Employee>();

            foreach(Employee t in employeeList)
            {
                if(t.EmployeeBalance > 0)
                {
                    employeeBalance.Add(t);
                }
            }

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            DataRow row;
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Balance");
            int i = 0;
            foreach (Employee employee in employeeBalance)
            {
                row = dt.NewRow();
                row[0] = employee.EmployeeID;
                row[1] = employee.EmployeeFName + " " + employee.EmployeeLName;
                row[2] = employee.EmployeeBalance;
                dt.Rows.Add(row);

            }

            return dt;

        }
           
    }
}
