﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Payroll System - Commission Employee
 * Miranda Motter
 * 28 Oct 2016
 * Creates a subclass of Employee for commissioned
 * Professor Masterson, CS 240-1
 */

namespace PayrollSystem
{
    public class CommEmployee : Employee
	{
        private double commRate;
		public double commissionRate
        {
            get
            {
                return commRate;
            }

            set
            {
                commRate = value;
            }
        } 
        

        // Default constructor
        public CommEmployee()
        {
            employee_ID = "0000";
            employee_LName = "Name";
            employee_Address = "Address";
            employee_Paymethod = "PayMethod";
            employee_Type = "Type";
            commRate = 0;
        }

        // Takes parameters to create new employee
        public CommEmployee(String newID, String newName, String newAddress,
            String newPayMethod, double newRate)
        {
            employee_ID = newID;
            employee_LName = newName;
            employee_Address = newAddress;
            employee_Paymethod = newPayMethod;
            employee_Type = "Commission";
            commRate = newRate;
            Console.WriteLine("Commission employee class created.");

        }

        // Union employee
        public CommEmployee(String newID, String newName, String newAddress,
            String newPayMethod, double newRate, Union newUnion)
        {
            employee_ID = newID;
            employee_LName = newName;
            employee_Address = newAddress;
            employee_Paymethod = newPayMethod;
            employee_Type = "Commission-Union";
            commRate = newRate;
            employee_Union = newUnion;
            Console.WriteLine("Commission union employee class created.");
        }

        // Calculate payment from rate and sales
        public double calcPayment(double rate, double salesAmount)
		{
			double payment = commRate * salesAmount;
			return payment;
		}

	    public void printSales(double salesAmount)
	    {
	        Console.WriteLine("Sales: $" + salesAmount);
	    }
	}
}