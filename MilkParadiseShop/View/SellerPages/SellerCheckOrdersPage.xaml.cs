#nullable disable
using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MilkParadiseShop.View.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для SellerCheckOrdersPage.xaml
    /// </summary>
    public partial class SellerCheckOrdersPage : Page
    {
        public SellerCheckOrdersPage()
        {
            InitializeComponent();
            ChooseOrderStatus.ItemsSource = NamesCollector.GetSearchList(NamesCollector.WorkingOrderStatusList, true);
            using (BaseContext context = new BaseContext())
            {
                DataGridSellerOrders.ItemsSource = context.Orders.Where(p => p.OrderType == "Самовывоз").ToList();
            }
        }
        private void ButtonCheckOrderCart(object sender, RoutedEventArgs e)
        {
            BaseViewModel.UserCheckShoppingCartInOrder((sender as Button).DataContext as Order);
        }

        private void ButtonGoLogout(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            UIManager.WorkerSellerTargetWindow.Close();
        }

    }
}