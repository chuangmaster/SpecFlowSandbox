using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSandbox
{
    public class DateTimeHelper
    {
        public bool IsChristmasEve(DateTime date)
        {
            if (date.Month == 12 && date.Day == 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
