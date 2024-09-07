using MilkParadiseShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.ViewModel
{
    public class SellerCourierViewModel
    {
        public static List<Order> GetSellerCourierOrdersList()
        {
            using (BaseContext baseContext = new BaseContext())
            {
                if (WorkerLogin.RoleId == 2)
                {
                    return baseContext.Orders.Where(p => p.OrderType == "Самовывоз" &&
                    (p.WorkerId == null || p.WorkerId == WorkerLogin.NumId)).ToList();
                }
                
                return baseContext.Orders.Where(p => p.OrderType == "Доставка" &&
                    (p.WorkerId == null || p.WorkerId == WorkerLogin.NumId)).ToList();
            }
        }
    }
}