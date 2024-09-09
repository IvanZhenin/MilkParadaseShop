using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public static class CheckTryConverter
    {
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
