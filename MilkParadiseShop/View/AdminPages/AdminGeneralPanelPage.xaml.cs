using MilkParadiseShop.Helpers;
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

namespace MilkParadiseShop.View.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminGeneralPanelPage.xaml
    /// </summary>
    public partial class AdminGeneralPanelPage : Page
    {
        public AdminGeneralPanelPage()
        {
            InitializeComponent();
        }
       
        private void ButtonGoCheckWorkers(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.Navigate(new AdminCheckWorkersListPage());
        }

        private void ButtonGoCheckClients(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.Navigate(new AdminCheckClientsListPage());
        }

        private void ButtonGoCheckOrders(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.Navigate(new AdminCheckOrderListPage());
        }

        private void ButtonGoCheckProductsAndCategories(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGoCheckShopPoints(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGoLogout(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            UIManager.WorkerAdminTargetWindow.Close();
        }
    }
}
