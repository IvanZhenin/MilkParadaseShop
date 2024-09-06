using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public static class UniqueId
    {
        public static int GetNewNumId(List<int> collection)
        {
            int newId = 1;
            collection.Sort();
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == newId)
                {
                    newId++;
                }
                else
                {
                    break;
                }
            }

            return newId;
        }
    }
}