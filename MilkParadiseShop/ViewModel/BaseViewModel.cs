using MilkParadiseShop.Model;
using MilkParadiseShop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.ViewModel
{
    public class BaseViewModel
    {
        public static List<string> GetMarketPointsNames()
        {
            List<string> names = new List<string>();
            using (BaseContext baseContext = new BaseContext())
            {
                foreach (MarketPoint address in baseContext.MarketPoints)
                {
                    names.Add(address.Address);
                }
            }
            return names;
        }
        public static decimal GetTotalPrice()
        {
            decimal price = 0;
            using (BaseContext baseContext = new BaseContext())
            {
                foreach (ClientProduct pos in baseContext.ClientProducts.Where(p => p.ClientId == ClientLogin.NumId))
                {
                    price += pos.TotalPriceForProduct;
                }
            }

            return price * (1 - (decimal)ClientLogin.Discount / 100);
        }

        public static List<Product> UpdateDataGridProductsWithSearch(string nameProd,
            string categoryName, string minPrice, string maxPrice)
        {
            using (BaseContext context = new BaseContext())
            {
                var newList = context.Products.ToList();
                if (nameProd != null && nameProd != string.Empty)
                    newList = newList.Where(p => p.Name.ToLower().Contains(nameProd.ToLower())).ToList();
                if (categoryName != null && categoryName != string.Empty)
                    newList = newList.Where(p => p.CategoryName == categoryName).ToList();
                if (Decimal.TryParse(minPrice, out decimal checkMinPrice))
                {
                    if (checkMinPrice > 0)
                        newList = newList.Where(p => p.Price >= checkMinPrice).ToList();
                }

                if (Decimal.TryParse(maxPrice, out decimal checkMaxPrice))
                {
                    if (checkMaxPrice > 0)
                    {
                        newList = newList.Where(p => p.Price <= checkMaxPrice).ToList();
                    }
                }

                return newList;
            }
        }

        public static List<Product> UpdateDataGridProductsWithoutSearch()
        {
            using (BaseContext context = new BaseContext())
            {
                return context.Products.ToList();
            }
        }
        public static void UserCheckShoppingCartInOrder(Order order)
        {
            UserCheckOrderCartWindow userCheckOrderCartWindow = new UserCheckOrderCartWindow(order);
            userCheckOrderCartWindow.ShowDialog();
        }

        public static List<ProdInOrder> GetProductListInOrder(Order targerOrder)
        {
            List<ProdInOrder> newList = new List<ProdInOrder>();
            using (BaseContext baseContext = new BaseContext())
            {
                foreach (ProdInOrder pos in baseContext.ProdsInOrders.Where(p => p.OrderId == targerOrder.NumId))
                {
                    newList.Add(pos);
                }
            }
            return newList;
        }
    }
}