using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class AddCommissionedEmployee : AddEmployeeTransaction
    {
        private readonly double salary, rate;

        public AddCommissionedEmployee(int empId, string name, string address, double salary, double rate) : base(empId, name, address)
        {
            this.salary = salary;
            this.rate = rate;
        }

        protected override PaymentClassification MakeClassification()
        {
            return new CommissionedClassification(rate, salary);
        }

        protected override PaymentSchedule MakeSchedule()
        {
            return new BiweeklySchedule();
        }
    }
}
