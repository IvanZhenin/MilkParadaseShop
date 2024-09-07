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
using System.Windows.Threading;

namespace MilkParadiseShop.View.SellerPages
{
    /// <summary>
    /// Логика взаимодействия для SellerCheckOrdersPage.xaml
    /// </summary>
    public partial class SellerCourierCheckOrdersPage : Page
    {
        private DispatcherTimer _timerForOrders = new DispatcherTimer();
        public SellerCourierCheckOrdersPage()
        {
            InitializeComponent();
            string roleName = WorkerLogin.RoleId == 2 ? "продавец" : "курьер";
            TextDataOfSellerAccount.Text += $"{roleName} {WorkerLogin.SurName} {WorkerLogin.Name}, имя записи - {WorkerLogin.Login}";
            ChooseOrderStatus.ItemsSource = NamesCollector.GetSearchList(NamesCollector.WorkingOrderStatusList, true);
            TimerActivate();
        }

        private void TimerActivate()
        {
            _timerForOrders.Interval = TimeSpan.FromSeconds(1.5);
            _timerForOrders.Tick += OnDispatcherTimerTick;
            _timerForOrders.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateOrders();
        }
        private void ButtonCheckOrderCart(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            BaseViewModel.UserCheckShoppingCartInOrder((sender as Button).DataContext as Order);
            _timerForOrders.Start();
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _timerForOrders.Start();
            UpdateOrders();
        }
        private void UpdateOrders()
        {
            if (CheckSearchOrders.IsChecked == true)
            {
                DataGridSellerCourierOrders.ItemsSource = BaseViewModel.GetUserOrdersListWithSearch(
                    InputOrderId.Text,
                    SelectOrderDateCreate.SelectedDate ?? null,
                    ChooseOrderStatus.SelectedItem.ToString(), SellerCourierViewModel.GetSellerCourierOrdersList());
            }
            else
            {
                DataGridSellerCourierOrders.ItemsSource = SellerCourierViewModel.GetSellerCourierOrdersList();
            }
            TextOrdersCount.Text = $"Количество заказов: {DataGridSellerCourierOrders.Items.Count}";
        }
        private void ButtonTakeOrder(object sender, RoutedEventArgs e)
        {
            BaseViewModel.WorkerTakesNewOrder((sender as Button).DataContext as Order);
        }
        private void ButtonGoLogout(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            UIManager.WorkerSellerCourierTargetWindow.Close();
        }

        private void ButtonAcceptOrder(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            BaseViewModel.WorkerAcceptOrCancelNewOrder((sender as Button).DataContext as Order, true);
            _timerForOrders.Start();
        }

        private void ButtonCancelOrder(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            BaseViewModel.WorkerAcceptOrCancelNewOrder((sender as Button).DataContext as Order, false);
            _timerForOrders.Start();
        }
    }
}