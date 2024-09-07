#nullable disable
using Microsoft.IdentityModel.Tokens;
using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using MilkParadiseShop.View;

namespace MilkParadiseShop.ViewModel
{
    public class ClientViewModel
    {
        public static List<Order> GetClientOrdersList()
        {
            using (BaseContext baseContext = new BaseContext())
            {
                return baseContext.Orders.Where(p => p.ClientId == ClientLogin.NumId).ToList();
            }
        }
        public static void CancelCurrentClientOrder(Order order)
        {
            if (order == null)
                return;

            if (order.Status == NamesCollector.WorkingOrderStatusList[2] || order.Status == NamesCollector.WorkingOrderStatusList[3])
            {
                MessageBox.Show($"Вы не можете отменить данный заказ, так как он {order.Status.ToLower()}!", "Ошибка");
                return;
            }

            if (MessageBox.Show($"Вы точно хотите отменить заказ под номером {order.NumId}?",
                "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    try
                    {
                        var currentOrder = baseContext.Orders.Where(p => p.NumId == order.NumId).First();
                        currentOrder.Status = NamesCollector.WorkingOrderStatusList[3];
                        baseContext.SaveChanges();
                        MessageBox.Show("Заказ успешно отменен!", "Внимание");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }
        }
        public static void ClearClientShoppingCart()
        {
            using (BaseContext baseContext = new BaseContext())
            {
                List<ClientProduct> prodList = baseContext.ClientProducts.Where(p => p.ClientId == ClientLogin.NumId).ToList();
                if (prodList.Count <= 0)
                {
                    MessageBox.Show("Корзина итак пустая!", "Внимание");
                    return;
                }

                if (MessageBox.Show($"Вы точно хотите очистить корзину с {ShoppingCart.ProductListCount()} товарами?",
                    "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        baseContext.ClientProducts.RemoveRange(prodList);
                        baseContext.SaveChanges();
                        MessageBox.Show("Корзина была успешно очищена!", "Внимание");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }
        }
        public static bool AddNewPositionInClientShoppingCart(string quantity, Product product = null, ClientProduct targetProdPos = null)
        {
            if (quantity == null || quantity == string.Empty || !quantity.All(p => Char.IsDigit(p)) || Convert.ToInt32(quantity) <= 0)
            {
                MessageBox.Show("Неверно указано количество товара!", "Ошибка");
                return false;
            }

            using (BaseContext baseContext = new BaseContext())
            {
                try
                {
                    if (targetProdPos == null)
                    {
                        ClientProduct newPos = new ClientProduct(ClientLogin.NumId, product.NumId, Convert.ToInt32(quantity));
                        ClientProduct checkCurrentPos = baseContext.ClientProducts
                            .Where(p => p.ClientId == newPos.ClientId && p.ProdId == newPos.ProdId).FirstOrDefault();
                        if (checkCurrentPos == null)
                        {
                            baseContext.ClientProducts.Add(newPos);
                        }
                        else
                        {
                            checkCurrentPos.Quantity += newPos.Quantity;
                        }
                        MessageBox.Show("Товар успешно добавлен в корзину!", "Внимание");
                    }
                    else
                    {
                        ClientProduct newPos = baseContext.ClientProducts
                            .Where(p => p.ClientId == targetProdPos.ClientId && p.ProdId == targetProdPos.ProdId).First();
                        newPos.Quantity = Convert.ToInt32(quantity);
                        MessageBox.Show("Количество позиции товара успешно изменено!", "Внимание");
                    }
                    baseContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Критическая ошибка");
                }
            }

            return true;
        }
        public static void DeletePositionFromClientShoppingCart(ClientProduct prodPosition)
        {
            if (MessageBox.Show($"Вы точно хотите удалить позицию товара {prodPosition.ProdName} из корзины?",
                   "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    try
                    {
                        baseContext.ClientProducts.Remove(prodPosition);
                        baseContext.SaveChanges();
                        MessageBox.Show("Позиция товара была успешно убрана из корзины!", "Внимание");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }
        }
        public static List<ClientProduct> UpdateDataGridClientShoppingCart()
        {
            using (BaseContext baseContext = new BaseContext())
            {
                return baseContext.ClientProducts.ToList();
            }
        }
        public static bool AcceptNewClientOrder(int clientId, string address, string orderType, decimal totalPrice)
        {
            if (address == null || address == string.Empty)
            {
                MessageBox.Show("Вы неправильно указали адрес!", "Ошибка");
                return false;
            }

            using (BaseContext baseContext = new BaseContext())
            {
                if (MessageBox.Show($"Вы подтверждаете заказ на сумму {BaseViewModel.GetTotalPrice()}?",
                   "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Order newOrder = new Order(
                            UniqueNewId.GetNewNumId(baseContext.Orders.Select(p => p.NumId).ToList()),
                            clientId, DateTime.Today, address, orderType, NamesCollector.WorkingOrderStatusList[0], totalPrice)
                        {
                            ArchStatus = false,
                        };
                        baseContext.Orders.Add(newOrder);
                        foreach (var clientPos in baseContext.ClientProducts)
                        {
                            baseContext.ProdsInOrders.Add(new ProdInOrder(newOrder.NumId, clientPos.ProdId, clientPos.Quantity));
                            baseContext.ClientProducts.Remove(clientPos);
                        }
                        baseContext.SaveChanges();
                        MessageBox.Show("Заказ был успешно создан!", "Внимание");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Критическая ошибка");
                    }
                }
            }

            return false;
        }
    }
}