using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class CreateEmployeeObjects
    {
        private DataSet tableset;
        private EmployeeFactory factory = new EmployeeFactory();
        private List<DataRow> employeesInfoTB = new List<DataRow>();
        private List<DataRow> hourlyEmployeeTB = new List<DataRow>();
        private List<DataRow> salaryEmployeeTB = new List<DataRow>();
        private List<DataRow> commisionEmployeeTB = new List<DataRow>();
        private List<Employee> employeeList = new List<Employee>();
        public CreateEmployeeObjects(DataSet table)
        {
            this.tableset = table;
        }

        public CreateEmployeeObjects()
        {
  
        }
        private void DataTableToList()
        {
            int i = 0;
            foreach (DataTable dt in tableset.Tables)
            {
                if (i == 0)
                {
                    employeesInfoTB = dt.AsEnumerable().ToList();
                }
                else if (i == 1)
                {
                    hourlyEmployeeTB = dt.AsEnumerable().ToList();
                }
                else if (i == 2)
                {
                    salaryEmployeeTB = dt.AsEnumerable().ToList();
                }
                else if (i == 3)
                {
                    commisionEmployeeTB = dt.AsEnumerable().ToList();
                }
                i++;
            }
        }

        public List<Employee> convertTableToEmployee()
        {
            //Convert tables into genetic list 
            DataTableToList();

            //extract all the info to create the employee object
            for(int i = 0; i < employeesInfoTB.Count; i++)
            {
                String id               = employeesInfoTB[i][0].ToString();
                String FName            = employeesInfoTB[i][1].ToString();
                String LName            = employeesInfoTB[i][2].ToString();
                String address          = employeesInfoTB[i][3].ToString();
                String paymentMethod    = employeesInfoTB[i][4].ToString();
                String type             = employeesInfoTB[i][5].ToString();
                String union            = employeesInfoTB[i][6].ToString();

                //Employee newEmployee    = factory.getEmployee(type);
                Employee newEmployee = new Employee();

                newEmployee.EmployeeID          = id;
                newEmployee.EmployeeFName       = FName;
                newEmployee.EmployeeLName       = LName;
                newEmployee.EmployeePaymethod   = paymentMethod;
                newEmployee.EmployeeAddress     = address;
                newEmployee.EmployeeType        = type;
                
                if( type == "Hourly" )
                {
                    completeHourly(newEmployee, type, id);
                }
                else if( type == "Salary" )
                {
                    completeSalary(newEmployee, type, id);
                }
                else if( type == "Commission")
                {
                    completeComission(newEmployee, type, id);
                }

            }

            // return the list of employee
            return employeeList;
        }
        
        public void completeHourly(Employee newEmployee, String type, String id)
        {
            EmployeeHourly hourly = new EmployeeHourly();
            
            for(int i = 0; i < hourlyEmployeeTB.Count; i++)
            {
                if(id == hourlyEmployeeTB[i][0].ToString())
                {
                    hourly.PeriodPaymentAmount  = Double.Parse(hourlyEmployeeTB[i][2].ToString());
                    hourly.HoursWorked          = Double.Parse(hourlyEmployeeTB[i][1].ToString());
                }
            }

            hourly.EmployeeID           = newEmployee.EmployeeID;
            hourly.EmployeeFName        = newEmployee.EmployeeFName;
            hourly.EmployeeLName        = newEmployee.EmployeeLName;
            hourly.EmployeePaymethod    = newEmployee.EmployeePaymethod;
            hourly.EmployeeAddress      = newEmployee.EmployeeAddress;
            hourly.EmployeeType         = newEmployee.EmployeeType;

            employeeList.Add(hourly);
        }

        public void completeSalary(Employee newEmployee, String type, String id)
        {
            Employee_Salary salary = new Employee_Salary();

            for (int i = 0; i < salaryEmployeeTB.Count; i++)
            {
                if (id == salaryEmployeeTB[i][0].ToString())
                {
                    salary.SalaryAmount = Double.Parse(salaryEmployeeTB[i][1].ToString());
                }
            }

            salary.EmployeeID           = newEmployee.EmployeeID;
            salary.EmployeeFName        = newEmployee.EmployeeFName;
            salary.EmployeeLName        = newEmployee.EmployeeLName;
            salary.EmployeePaymethod    = newEmployee.EmployeePaymethod;
            salary.EmployeeAddress      = newEmployee.EmployeeAddress;
            salary.EmployeeType         = newEmployee.EmployeeType;

            employeeList.Add(salary);

        }

        public void completeComission(Employee newEmployee, String type, String id)
        {
            CommEmployee commission = new CommEmployee();

            for (int i = 0; i < commisionEmployeeTB.Count; i++)
            {
                if (id == commisionEmployeeTB[i][0].ToString())
                {
                    commission.Commission       = Double.Parse(commisionEmployeeTB[i][1].ToString());
                    commission.commissionRate   = Double.Parse(commisionEmployeeTB[i][2].ToString());
                }
            }

            commission.EmployeeID           = newEmployee.EmployeeID;
            commission.EmployeeFName        = newEmployee.EmployeeFName;
            commission.EmployeeLName        = newEmployee.EmployeeLName;
            commission.EmployeePaymethod    = newEmployee.EmployeePaymethod;
            commission.EmployeeAddress      = newEmployee.EmployeeAddress;
            commission.EmployeeType         = newEmployee.EmployeeType;

            employeeList.Add(commission);

        }
    }
}
