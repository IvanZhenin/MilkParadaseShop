using MilkParadiseShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MilkParadiseShop.Model;

namespace MilkParadiseShop.View
{
    /// <summary>
    /// Логика взаимодействия для AdminChooseClientDiscountWindow.xaml
    /// </summary>
    public partial class AdminChooseClientDiscountWindow : Window
    {
        private Client _currentClient = new Client();
        public AdminChooseClientDiscountWindow(Client targetClient)
        {
            InitializeComponent();
            TextCurrentProduct.Text = $"Изменение скидки клиента {targetClient.NumId}";
            _currentClient = targetClient;
        }

        private void ButtonAcceptEditClientDiscount(object sender, RoutedEventArgs e)
        {
            if (AdminViewModel.EditClientDiscount(InputClientDiscount.Text, _currentClient))
                this.Close();
        }

        private void ButtonCloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
