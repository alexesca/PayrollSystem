using System;
namespace PayrollSystem
{
	public class EmployeeHourly : Employee
	{
		private double   hourlyPay;
		private double   hoursWorked;
		private double   totalHoursWorked;
		private DateTime periodStarted;
		private DateTime periodEnded;
		private String   reportCalendar;
		private double   periodPaymentAmount;
		

		public EmployeeHourly()
		{
			this.hourlyPay           = 7.25;
			this.hoursWorked         = 0;
			this.periodStarted       = DateTime.Now;
			this.periodEnded         = DateTime.Now;
			this.periodPaymentAmount = 0;
            this.EmployeeType        = "Hourly";
		}

        public EmployeeHourly(String name, String ID, String address, String paymentMethod, Double hourlyPay)
        {
            this.employee_Name      = name;
            this.employee_ID        = ID;
            this.employee_Address   = address;
            this.employee_Paymethod = paymentMethod;
            this.hourlyPay          = hourlyPay;
            this.EmployeeType       = "Hourly";
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
			return periodPaymentAmount = hourlyPay * totalHoursWorked;
		}

		public void addTime(double timeWorked)
		{
            totalHoursWorked += timeWorked;
			reportCalendar += DateTime.Now + " :\t" + timeWorked + "\n";
		}

        public string getReport()
        {
            if (reportCalendar != null)
                return reportCalendar;
            else
                return "No report to show yet.";
        }

		public void payEmployee()
		{
			//ToDo
			//1- check that the periodPayment Amount is different than 0
			//2- Create an object payment
			//3- Base on the payment method choose a payment function.
		}
	}
}
