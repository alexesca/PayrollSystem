using System;

namespace PayrollSystem
{
	public class Employee
	{

		public String EmployeeID
		{
			get
			{
				return employee_ID;
			}
			set
			{
				employee_ID = value;
			}
		}

		public String EmployeeFName
		{
			get
			{
				return employee_FName;
			}
			set
			{
				employee_FName = value;
			}

		}

        public String EmployeeLName
        {
            get
            {
                return employee_LName;
            }
            set
            {
                employee_LName = value;
            }

        }

        public String EmployeeAddress
		{
			get
			{
				return employee_Address;
			}

			set
			{
				employee_Address = value;
			}
		}
		public String EmployeePaymethod
		{
			get
			{
				return employee_Paymethod;
			}
			set
			{
				employee_Paymethod = value;
			}
		}

		public String EmployeeType
		{
			get
			{
				return employee_Type;
			}
			set
			{
				employee_Type = value;
			}
		}

        public Boolean EmployeeUnion { get; set; }
        public Double EmployeeTypeRate { get; set; }

        

		protected String employee_ID;
		protected String employee_FName;
        protected string employee_LName;
		protected String employee_Address;
		protected String employee_Paymethod;
		protected String employee_Type;
        protected Boolean employee_Union;
        protected Double employee_Type_Rate;
    }

    // If employee is from union, use the following
    public class Union
    {
        double weeklyDuesRate;

        public Union()
        {
            weeklyDuesRate = 0;
        }

        public Union(double newDueRate)
        {
            weeklyDuesRate = newDueRate;
        }

        // Calculate weekly dues and return new payment
        public double deduct(double rate, double pay)
        {
            double deduction = rate * pay;
            double netPay = pay - deduction;
            return netPay;
        }

        // If service charges apply, call following
        public double serviceCharge (double charge, double nextPay)
        {
            return nextPay - charge;
        }

        public void printRates(double duesRate)
        {
            Console.WriteLine("Dues rate: " + duesRate);
        }
    }
}
