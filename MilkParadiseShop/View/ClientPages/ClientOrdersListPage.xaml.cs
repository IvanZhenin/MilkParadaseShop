#nullable disable
using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
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
using MilkParadiseShop.ViewModel;
using System.Windows.Threading;

namespace MilkParadiseShop.View.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для ClientOrdersListPage.xaml
    /// </summary>
    public partial class ClientOrdersListPage : Page
    {
        private DispatcherTimer _timerForOrders = new DispatcherTimer();
        public ClientOrdersListPage()
        {
            InitializeComponent();
            TextDataOfClientAccount.Text += $"клиент {ClientLogin.SurName} {ClientLogin.Name}, имя записи - {ClientLogin.Login}";
            ChooseOrderStatus.ItemsSource = NamesCollector.GetSearchList(NamesCollector.WorkingOrderStatusList, true);
            TimerActivate();
        }
        private void ButtonGoEditAccountDataClient(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            UIManager.ClientFrame.Navigate(new ClientEditHisProfilePage());
        }
        private void ButtonCheckProductList(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            UIManager.ClientFrame.Navigate(new ClientCheckProdsListPage());
        }
        private void ButtonCheckOrderCart(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            BaseViewModel.UserCheckShoppingCartInOrder((sender as Button).DataContext as Order);
            _timerForOrders.Start();
        }
        private void ButtonGoLogout(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            UIManager.ClientTargetWindow.Close();
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

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateOrders();
            _timerForOrders.Start();
        }

        private void UpdateOrders()
        {
            if (CheckSearchOrders.IsChecked == true)
            {
                DataGridClientOrders.ItemsSource = BaseViewModel.GetUserOrdersListWithSearch(
                    InputOrderId.Text,
                    SelectOrderDateCreate.SelectedDate ?? null,
                    ChooseOrderStatus.SelectedItem.ToString(), ClientViewModel.GetClientOrdersList());
            }
            else
            {
                DataGridClientOrders.ItemsSource = ClientViewModel.GetClientOrdersList();
            }
            TextOrdersCount.Text = $"Количество заказов: {DataGridClientOrders.Items.Count}";
        }

        private void ButtonCancelOrder(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            if (ClientViewModel.CancelCurrentClientOrder((sender as Button).DataContext as Order))
                UpdateOrders();
            _timerForOrders.Start();
        }
    }
}