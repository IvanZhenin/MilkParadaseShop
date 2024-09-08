#nullable disable
using MilkParadiseShop.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using MilkParadiseShop.Helpers;
using System.IO;
using System.ComponentModel;
using System.Windows.Media;

namespace MilkParadiseShop.ViewModel
{
    public class AdminViewModel
    {
        public static List<Worker> GetAdminWorkersList()
        {
            using (BaseContext baseContext = new BaseContext())
            {
                return baseContext.Workers.Where(p => p.RoleId != 1).ToList();
            }
        }
        public static List<Worker> UpdateDataGridWorkersWithSearch(string numId,
            string roleName, string gender)
        {
            int numberId = (numId.All(c => char.IsDigit(c)) && numId != null
                && numId != string.Empty) ? Convert.ToInt32(numId) : 0;

            using (BaseContext baseContext = new BaseContext())
            {
                var newList = GetAdminWorkersList();
                if (numberId > 0)
                    newList = newList.Where(p => p.NumId == numberId).ToList();
                if (roleName != null && roleName != string.Empty)
                    newList = newList.Where(p => p.JobName == roleName).ToList();
                if (gender != null && gender != string.Empty)
                    newList = newList.Where(p => p.Gender[0] == gender[0]).ToList();

                return newList;
            }
        }

        public static List<string> GetJobRoleNamesForAdmin()
        {
            List<string> newList = new List<string>();
            using (BaseContext baseContext = new BaseContext())
            {
                foreach (JobRole role in baseContext.JobRoles)
                {
                    if (role.NumId != 1)
                        newList.Add(role.Name);
                }
            }
            return newList;
        }
        public static int GetIndexOfJobRoleName(Worker worker)
        {
            int index = 0;
            using (BaseContext baseContext = new BaseContext())
            {
                List<int> newlist = baseContext.JobRoles.Select(p => p.NumId).ToList();
                index = newlist.IndexOf(worker.RoleId) - 1;
            }
            if (index < 0)
                index = 0;
            return index;
        }
        private static int GetRoleIndex(string roleName)
        {
            using (BaseContext baseContext = new BaseContext())
            {
                return baseContext.JobRoles.Where(p => p.Name == roleName).First().NumId;
            }
        }

        public static bool AddNewWorker(string name, string surName, string roleName, string gender, string phoneNumber,
            string email, string login, string password, string patronymic = null, BitmapImage image = null)
        {
            if (ValueValidator.CheckNullOrEmptyParams(name, surName, roleName, gender, phoneNumber, email, login))
            {
                MessageBox.Show("Поля: имя, фамилия, должность, пол, номер теелфона, " +
                    "почта и логин являются обязательными к заполнению!", "Ошибка");
                return false;
            }

            if (MessageBox.Show("Вы точно хотите создать нового сотрудника?",
                  "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    StringBuilder errors = new StringBuilder();
                    if (!phoneNumber.All(Char.IsDigit))
                    {
                        errors.AppendLine("Номер телефона должен содержать только цифры!");
                    }

                    if (InputValidator.CheckRussianLetters(login))
                    {
                        errors.AppendLine("Логин не должен содержать русских символов!");
                    }
                    else if (baseContext.Workers.Where(p => p.Login == login).FirstOrDefault() != null)
                    {
                        errors.AppendLine("Данный логин уже занят!");
                    }

                    if (InputValidator.CheckRussianLetters(password))
                    {
                        errors.AppendLine("Пароль не должен содержать русских символов!");
                    }

                    if (errors.Length > 0)
                    {
                        MessageBox.Show(errors.ToString(), "Ошибка");
                        return false;
                    }

                    try
                    {
                        Worker newWorker = new Worker();
                        newWorker.NumId = UniqueNewId.GetNewNumId(baseContext.Workers.Select(p => p.NumId).ToList());
                        newWorker.Name = name;
                        newWorker.SurName = surName;
                        newWorker.Patronymic = patronymic;
                        newWorker.RoleId = GetRoleIndex(roleName);
                        newWorker.PhoneNumber = phoneNumber;
                        newWorker.Gender = gender;
                        newWorker.Email = email;
                        newWorker.Login = login;
                        newWorker.Password = password;
                        newWorker.Image = ImageConverterToByte(image);
                        baseContext.Workers.Add(newWorker);
                        baseContext.SaveChanges();
                        MessageBox.Show("Новый сотрудник успешно добавлен!", "Внимание");
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

        public static bool EditCurrentWorker(Worker targetWorker, string name, string surName, string roleName, string gender, string phoneNumber,
            string email, string login, string newPassword, bool changePassword, string patronymic = null, BitmapImage image = null)
        {
            if (ValueValidator.CheckNullOrEmptyParams(name, surName, roleName, gender, phoneNumber, email, login))
            {
                MessageBox.Show("Поля: имя, фамилия, должность, пол, номер теелфона, " +
                    "почта и логин являются обязательными к заполнению!", "Ошибка");
                return false;
            }

            if (MessageBox.Show("Вы точно хотите внести данные изменения в данный аккаунт?",
                  "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    StringBuilder errors = new StringBuilder();
                    if (!phoneNumber.All(Char.IsDigit))
                    {
                        errors.AppendLine("Номер телефона должен содержать только цифры!");
                    }

                    if (InputValidator.CheckRussianLetters(login))
                    {
                        errors.AppendLine("Логин не должен содержать русских символов!");
                    }
                    else if (baseContext.Workers.Where(p => p.Login == login && p.NumId != targetWorker.NumId).FirstOrDefault() != null)
                    {
                        errors.AppendLine("Данный логин уже занят!");
                    }

                    if (changePassword)
                    {
                        if (InputValidator.CheckRussianLetters(newPassword))
                        {
                            errors.AppendLine("Пароль не должен содержать русских символов!");
                        }
                    }

                    if (errors.Length > 0)
                    {
                        MessageBox.Show(errors.ToString(), "Ошибка");
                        return false;
                    }

                    try
                    {
                        var currentWorker = baseContext.Workers.Where(p => p.NumId == targetWorker.NumId).First();
                        currentWorker.Name = name;
                        currentWorker.SurName = surName;
                        currentWorker.Patronymic = patronymic;
                        currentWorker.RoleId = GetRoleIndex(roleName);
                        currentWorker.PhoneNumber = phoneNumber;
                        currentWorker.Gender = gender;
                        currentWorker.Email = email;
                        currentWorker.Login = login;
                        if (changePassword)
                            currentWorker.Password = newPassword;
                        currentWorker.Image = ImageConverterToByte(image);
                        baseContext.SaveChanges();
                        MessageBox.Show("Изменения успешно сохранены!","Внимание");
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
        public static ImageSource ByteConvertToImageSource(byte[] data)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            } 
            return bitmapImage;
        }
        private static byte[] ImageConverterToByte(BitmapImage image)
        {
            if (image == null)
                return null;

            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        public static BitmapImage GetNewImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files | *.jpg; *.jpeg; *.png; *.bmp | All Files | *.*";

            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    BitmapImage bitmapImage = new BitmapImage(new Uri(selectedImagePath));
                    return bitmapImage;
                }
            }
            catch (System.NotSupportedException)
            {
                MessageBox.Show("Выбран неподходящий тип файла", "Ошибка");
            }

            return null;
        }
        public static void DeleteCurrentWorker(Worker targetWorker)
        {
            if (targetWorker == null)
                return;

            if (MessageBox.Show($"Вы точно хотите удалить сотрудника под номером {targetWorker.NumId}?",
                   "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (BaseContext baseContext = new BaseContext())
                {
                    var workersOrderList = baseContext.Orders.Where(p => p.WorkerId == targetWorker.NumId).ToList();
                    if (workersOrderList.Count > 0)
                    {
                        MessageBox.Show("Вы не можете удалить сотрудника, так как у него имеются заказы", "Ошибка");
                        return;
                    }

                    try
                    {
                        baseContext.Workers.Remove(targetWorker);
                        baseContext.SaveChanges();
                        MessageBox.Show("Сотрудник был успешно удален!", "Внимание");
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