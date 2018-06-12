using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class CommissionedClassification : PaymentClassification
    {
        public double CommissionRate { get; private set; }
        public double Salary { get; private set; }

        public CommissionedClassification(double rate, double salary)
        {
            CommissionRate = rate;
            Salary = salary;
        }

        public override double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
