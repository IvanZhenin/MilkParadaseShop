using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Model
{
    public class WorkerLogin : UserLogin
    {
        public WorkerLogin() : base()
        { 
            RoleId = 0;
        }    
        public WorkerLogin(int numId, string name, string surName,
            string login, string password, int roleId, string? patronymic = null)
            : base(numId, name, surName, login, password, patronymic)
        {
            RoleId = roleId;
        }
        public static int RoleId { get; private set; }
    }
}