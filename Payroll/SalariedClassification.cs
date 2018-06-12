using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class SalariedClassification : PaymentClassification
    {
        public double Salary { get; private set; }

        public SalariedClassification(double salary)
        {
            Salary = salary;
        }

        public override double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
