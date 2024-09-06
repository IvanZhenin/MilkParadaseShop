#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MilkParadiseShop.Model
{
    public class ShoppingCart
    {    
        public static List<ClientProduct> ProductList { get; set; }

        public static int ProductListCount()
        {
            int count = 0;
            using(BaseContext baseContext = new BaseContext())
            {
                foreach (ClientProduct pos in baseContext.ClientProducts.Where(p => p.ClientId == ClientLogin.NumId))
                {
                    count += pos.Quantity;
                }
            }
            return count;
        }
    }
}