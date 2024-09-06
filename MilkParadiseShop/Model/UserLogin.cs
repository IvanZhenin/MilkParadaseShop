#nullable disable
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkParadiseShop.Model
{
    public class UserLogin
    {
        public UserLogin() 
        {
            NumId = 0;
            Name = null;
            SurName = null;
            Patronymic = null;
            Login = null;
            Password = null;
        }
        public UserLogin(int numId, string name, string surName, 
            string login, string password, string patronymic = null)
        {
            NumId = numId;
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
            Login = login;
            Password = password;
        }
        public static int NumId { get; private set; }
        public static string Name { get; private set; }
        public static string SurName { get; private set; }
        public static string Patronymic { get; private set; }
        public static string Gender { get; private set; }
        public static string Login { get; private set; }
        public static string Password { get; private set; }
    }
}