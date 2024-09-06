using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public static class InputValidator
    {
        public static bool CheckRussianLetters(string text)
        {
            if (text.Any(c => c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я'))
                return true;
            return false;
        }
    }
}