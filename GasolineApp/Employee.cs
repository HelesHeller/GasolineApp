using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_SalaryCalculator.Models
{
    internal class Employee
    {
        public string FullName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal Payment { get; set; }
        public Employee(string name, decimal hours, decimal rate)
        {
            FullName = name;
            HoursWorked = hours;
            HourlyRate = rate;

            if (HoursWorked > 144)
            {
                decimal overtimeHours = HoursWorked - 144;
                decimal regularPayment = 144 * HourlyRate;
                decimal overtimePayment = overtimeHours * HourlyRate * 2;

                decimal totalPayment = regularPayment + overtimePayment;
                decimal taxedPayment = totalPayment * (decimal)0.88;

                Payment = taxedPayment;
            }
            else
            {
                decimal totalPayment = HoursWorked * HourlyRate;
                decimal taxedPayment = totalPayment * (decimal)0.88;

                Payment = taxedPayment;
            }
        }
    }
}
