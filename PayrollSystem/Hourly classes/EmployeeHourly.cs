using PayrollSystem.Hourly_classes;
using System;
using System.Collections.Generic;

namespace PayrollSystem
{
	public class EmployeeHourly : Employee
	{
		private double   hourlyPay;
		private double   hoursWorked;
		private double   totalHoursWorked;
		private double periodPaymentAmount;
        private List<reportHourly> reportCalendar;
		

		public EmployeeHourly()
		{
			this.hourlyPay           = 7.20;
			this.hoursWorked         = 0;
			this.periodPaymentAmount = 0;
            this.EmployeeType        = "Hourly";
		}

        public EmployeeHourly(String name, String ID, String address, String paymentMethod, Double hourlyPay)
        {
            this.employee_LName          = name;
            this.employee_ID            = ID;
            this.employee_Address       = address;
            this.employee_Paymethod     = paymentMethod;
            this.hourlyPay              = hourlyPay;
            this.periodPaymentAmount    = 0;
            this.totalHoursWorked       = 0;
            this.EmployeeType           = "Hourly";
        }

		public double HourlyPay
		{
			get
			{
				return hourlyPay;
			}

			set
			{
				hourlyPay = value;
			}
		}

		public double HoursWorked
		{
			get
			{
				return hoursWorked;
			}

			set
			{
				hoursWorked = value;
				totalHoursWorked += hoursWorked;
				calculatePayment();
			}
		}

		public double PeriodPaymentAmount
		{
			get
			{
				return periodPaymentAmount;
			}

			set
			{
				periodPaymentAmount = value;
			}
		}

		public double calculatePayment()
		{
			return employee_Balance = hourlyPay * totalHoursWorked;
		}

		public double addTime(double timeWorked)
		{
            totalHoursWorked += timeWorked;
            calculatePayment();
            //reportCalendar.Add(new reportHourly(timeWorked)); *********
            return periodPaymentAmount;
			
		}

        //public string getReport()
        //{
        //    if (reportCalendar != null)
        //        return reportCalendar;
        //    else
        //        return "No report to show yet.";
        //}

	}
}
