using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class HourlyClassification : PaymentClassification
    {
        public double HourlyRate { get; private set; }

        public HourlyClassification(double rate)
        {
            HourlyRate = rate;
        }

        public override double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
