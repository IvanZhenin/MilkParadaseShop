using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public static class ValueValidator
    {
        public static bool CheckNullOrEmptyParams(params string[] values) => values.Any(String.IsNullOrEmpty);
    }
}