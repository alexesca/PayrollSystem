using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Hourly_classes
{
    public class reportHourly
    {
        private DateTime workedDate;
        private double hourWorked;

        public reportHourly(double workedHour)
        {
            workedDate = DateTime.Now;
            this.hourWorked = workedHour;
        }

        public DateTime getWorkedDate()
        {
            return workedDate;
        }

        public double getHourWorked()
        {
            return hourWorked;
        }
    }
}
