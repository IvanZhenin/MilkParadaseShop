using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Model
{
    public class ClientLogin : UserLogin
    {
        public ClientLogin() : base()
        {
            Discount = 0;
        }
        public ClientLogin(int numId, string name, string surName,
            string login, string password, int discount, string? patronymic = null)
            : base(numId, name, surName, login, password, patronymic)
        { 
            Discount = discount;
        }
        public static int Discount { get; private set; }
    }
}