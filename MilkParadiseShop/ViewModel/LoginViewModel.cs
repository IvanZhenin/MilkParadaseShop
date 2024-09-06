using MilkParadiseShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MilkParadiseShop.Enums;
using MilkParadiseShop.View;
using MilkParadiseShop.Helpers;
using Azure.Core;
using static System.Net.Mime.MediaTypeNames;

namespace MilkParadiseShop.ViewModel
{
    public static class LoginViewModel
    {
        public static void Authorization()
        {
            WorkerLogin workerLogin = new WorkerLogin();
            ClientLogin clientLogin = new ClientLogin();
            ClientOpenWindow();
        }
        public static void Authorization(string login, string password, UserOrientation orientation)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Необходимо заполнить оба поля!", "Ошибка");
                return;
            }

            using (BaseContext context = new BaseContext())
            {
                switch (orientation)
                {
                    case UserOrientation.Client:
                        var targetClient = context.Clients.Where(p => p.Login == login && p.Password == password).FirstOrDefault();
                        if (targetClient == null)
                        {
                            MessageBox.Show("Данные введены неверно!", "Ошибка");
                            return;
                        }
                        else
                        {
                            ClientLogged(targetClient);
                        }
                        break;
                    case UserOrientation.Worker:
                        var targetWorker = context.Workers.Where(p => p.Login == login && p.Password == password).FirstOrDefault();
                        if (targetWorker == null)
                        {
                            MessageBox.Show("Данные введены неверно!", "Ошибка");
                            return;
                        }
                        else
                        {
                            WorkerLogged(targetWorker);
                        }
                        break;
                }
            }
        }
        private static void ClientOpenWindow()
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            UIManager.LoginTargetWindow.Close();
        }
        private static void ClientLogged(Client client)
        {
            ClientLogin clientData = new ClientLogin(client.NumId, client.Name, client.SurName,
                client.Login, client.Password, client.Discount, client.Patronymic);
            ClientOpenWindow();
        }
        private static void WorkerLogged(Worker worker)
        {
            WorkerLogin workerData = new WorkerLogin(worker.NumId, worker.Name, worker.SurName,
                worker.Login, worker.Password, worker.RoleId, worker.Patronymic);

            switch (worker.RoleId)
            {
                case (1):
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    break;
                case (2):
                    SellerWindow sellerWindow = new SellerWindow();
                    sellerWindow.Show();
                    break;
                case (3):
                    CourierWindow courierWindow = new CourierWindow();
                    courierWindow.Show();
                    break;
            }
            UIManager.LoginTargetWindow.Close();
        }
        public static void Registration(string name, string surname, string gender, string phoneNumber, string email,
            string login, string password, string repeatPassword, string? patronymic = null)
        {
            using (BaseContext context = new BaseContext())
            {
                if (ValueValidator.CheckNullOrEmptyParams(name, surname, phoneNumber, email, login, password, repeatPassword))
                {
                    MessageBox.Show("Необходимо заполнить все обязательные поля!", "Ошибка");
                    return;
                }

                StringBuilder errors = new StringBuilder();

                var clientCheck = context.Clients.Where(p => p.Login == login).FirstOrDefault();
                if (clientCheck != null)
                {
                    errors.AppendLine("Такой логин уже занят, выберите другой!");
                }

                if (!phoneNumber.All(Char.IsDigit))
                {
                    errors.AppendLine("Номер телефона должен содержать только цифры!");
                }    

                if (InputValidator.CheckRussianLetters(login) || InputValidator.CheckRussianLetters(password))
                {
                    errors.AppendLine("Логин и пароль не должны содержать русских символов!");
                }
                else if (password != repeatPassword)
                {
                    errors.AppendLine("Пароли не совпадают!");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Ошибка");
                    return;
                }

                Client newClient = new Client
                {
                    NumId = UniqueId.GetNewNumId(context.Clients.Select(p => p.NumId).ToList()),
                    Name = name,
                    SurName = surname,
                    Patronymic = patronymic,
                    Gender = gender,
                    Login = login,
                    Password = password,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Discount = 0
                };

                AddNewClient(newClient);
            }
        }
        private static void AddNewClient(Client client)
        {
            try
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    baseContext.Clients.Add(client);
                    baseContext.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно!","Внимание");
                    UIManager.LoginDataPanelFrame.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка");
            }
        }
    }
}