using MilkParadiseShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Helpers
{
    public class NamesCollector
    {
        public static readonly List<string> WorkingOrderStatusList = new List<string>
        {
            "В ожидании",
            "Выполняется",
            "Выполнен",
            "Отменен"
        };

        public static readonly List<string> WorkingOrderTypeList = new List<string>
        {
            "Самовывоз",
            "Доставка",
        };

        public static readonly List<string> WorkingOrderArchiveTypeList = new List<string>
        {
            "Не в архиве",
            "Архивирован",
        };

        public static readonly List<string> WorkersGenderTypeList = new List<string>
        {
            "Мужской",
            "Женский",
        };
        public static List<string> CategoriesNames()
        {
            List<string> categoriesName = new List<string>();
            using (BaseContext baseContext = new BaseContext())
            {
                foreach (var category in baseContext.Categories)
                    categoriesName.Add(category.Name);
            }
            return categoriesName;
        }
        public static List<string> GetSearchList(List<string> targetList, bool maleOrientation)
        {
            List<string> currentList = new List<string>();
            if (maleOrientation)
            {
                currentList.Add("Любой");
            }    
            else
            {
                currentList.Add("Любая");
            }

            foreach (string status in targetList)
                currentList.Add(status);

            return currentList;
        }
    }
}