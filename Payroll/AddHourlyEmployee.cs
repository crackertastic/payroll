using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class AddHourlyEmployee : AddEmployeeTransaction
    {
        public readonly double rate;

        public AddHourlyEmployee(int empid, string name, string address, double rate) : base (empid, name, address)
        {
            this.rate = rate;
        }

        protected override PaymentClassification MakeClassification()
        {
            return new HourlyClassification(rate);
        }

        protected override PaymentSchedule MakeSchedule()
        {
            return new WeeklySchedule();
        }
    }
}
