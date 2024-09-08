using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
using MilkParadiseShop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                        newList = newList.Where(p => p.Price <= checkMaxPrice).ToList();
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
        public static List<Order> GetUserOrdersListWithSearch(string orderId, DateTime? dateCreate,
            string selectedStatus, List<Order> currentOrderList)
        {
            int orderNumId = (orderId.All(c => char.IsDigit(c)) && orderId != null
                && orderId != string.Empty) ? Convert.ToInt32(orderId) : 0;

            using (BaseContext baseContext = new BaseContext())
            {
                if (orderNumId > 0)
                    currentOrderList = currentOrderList.Where(p => p.NumId == orderNumId).ToList();
                if (dateCreate != null)
                    currentOrderList = currentOrderList.Where(p => p.DateCreate == dateCreate).ToList();
                if (selectedStatus != "Любой" && !String.IsNullOrEmpty(selectedStatus))
                    currentOrderList = currentOrderList.Where(p => p.Status == selectedStatus).ToList();
                return currentOrderList;
            }
        }
        public static List<Order> UpdateUserOrdersListWithoutSearch(List<Order> currentOrderList)
        {
            using (BaseContext baseContext = new BaseContext())
            {
                return baseContext.Orders.Where(p => p.ClientId == ClientLogin.NumId).ToList();
            }
        }
        public static void WorkerTakesNewOrder(Order currentOrder)
        {
            if (currentOrder == null) 
                return;

            if (currentOrder.WorkerId == WorkerLogin.NumId)
            {
                MessageBox.Show("Данный заказ уже принят!", "Ошибка");
                return;
            }

            if (MessageBox.Show($"Вы точно хотите принять заказ под номером {currentOrder.NumId}?",
                  "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    try
                    {
                        var targetOrder = baseContext.Orders.Where(p => p.NumId == currentOrder.NumId).First();
                        targetOrder.WorkerId = WorkerLogin.NumId;
                        targetOrder.Status = NamesCollector.WorkingOrderStatusList[1];
                        baseContext.SaveChanges();
                        MessageBox.Show("Заказ успешно принят!", "Внимание");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }
        }
        public static void WorkerAcceptOrCancelNewOrder(Order currentOrder, bool acceptOrder)
        {
            if (currentOrder == null)
                return;

            if (currentOrder.Status != NamesCollector.WorkingOrderStatusList[1])
            {
                MessageBox.Show($"Вы не можете изменить статус заказа,так как он {currentOrder.Status.ToLower()}!", "Ошибка");
                return;
            }

            string orderVerdict = acceptOrder ? "завершен" : "отменен";
            if (MessageBox.Show($"Вы точно хотите изменить статус заказа под номером {currentOrder.NumId}?",
                 "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    try
                    {
                        var targetOrder = baseContext.Orders.Where(p => p.NumId == currentOrder.NumId).First();
                        targetOrder.Status = acceptOrder ? NamesCollector.WorkingOrderStatusList[2] : NamesCollector.WorkingOrderStatusList[3];
                        targetOrder.DateEnd = DateTime.Today;
                        baseContext.SaveChanges();
                        MessageBox.Show($"Заказ успешно {orderVerdict}!", "Внимание");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }
        }
    }
}