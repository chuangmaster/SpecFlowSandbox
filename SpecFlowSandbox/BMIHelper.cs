using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSandbox
{
    public class BMIHelper
    {
        public string GetBMIHint(float centimeter, float kilogram)
        {
            string hint = string.Empty;
            float meter = centimeter / 100;
            float bmi = kilogram / (meter * meter);
            if (bmi < 18.5)
            {
                hint = "體重過輕";
            }
            else if (18.5 <= bmi && bmi < 24)
            {
                hint = "正常";
            }
            else if (24 <= bmi && bmi < 27)
            {
                hint = "過重";
            }
            else if (27 <= bmi && bmi < 30)
            {
                hint = "輕度肥胖";
            }
            else if (30 <= bmi && bmi < 35)
            {
                hint = "中度肥胖";
            }
            else if (bmi >= 35)
            {
                hint = "重度肥胖";
            }

            return hint;
        }
    }
}
