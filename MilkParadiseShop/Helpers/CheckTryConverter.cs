using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public static class CheckTryConverter
    {
        public static bool ConvertToDecimal(string value)
        {
            try
            {
                Convert.ToDecimal(value);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool ConvertToDouble(string value)
        {
            try
            {
                Convert.ToDouble(value);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static string ConvertStringToDecimalFormat(string value)
        {
            string newValue = string.Empty;
            foreach (char c in value)
            {
                if (c == '.')
                {
                    newValue += ',';
                }
                else
                {
                    newValue += c;
                }
            }
            return newValue;
        }
    }
}
