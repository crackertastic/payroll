using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class BiweeklySchedule : PaymentSchedule
    {
        public bool IsPayday(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
