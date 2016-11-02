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

		public String EmployeeName
		{
			get
			{
				return employee_Name;
			}
			set
			{
				employee_Name = value;
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

		protected String employee_ID;
		protected String employee_Name;
		protected String employee_Address;
		protected String employee_Paymethod;
		protected String employee_Type;


	}
}
