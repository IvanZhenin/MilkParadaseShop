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

namespace MilkParadiseShop.View.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminCheckOrderListPage.xaml
    /// </summary>
    public partial class AdminCheckOrderListPage : Page
    {
        private DispatcherTimer _timerForOrders = new DispatcherTimer();
        public AdminCheckOrderListPage()
        {
            InitializeComponent();
            TimerActivate();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateOrders();
            _timerForOrders.Start();
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
        private void UpdateOrders()
        {
            if (CheckSearchOrders.IsChecked == true)
            {
                DataGridAdminOrders.ItemsSource = BaseViewModel.GetUserOrdersListWithSearch(
                    InputOrderId.Text,
                    SelectOrderDateCreate.SelectedDate ?? null,
                    ChooseOrderStatus.SelectedItem.ToString(), AdminViewModel.GetAdminOrdersList());
            }
            else
            {
                DataGridAdminOrders.ItemsSource = AdminViewModel.GetAdminOrdersList();
            }
        }
        private void ButtonCheckOrderCart(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            BaseViewModel.UserCheckShoppingCartInOrder((sender as Button).DataContext as Order);
            _timerForOrders.Start();
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonTakeOrderFromArchive(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            if (AdminViewModel.PutOrTakeOrderArchive((sender as Button).DataContext as Order, false))
                UpdateOrders();
            _timerForOrders.Start();
        }

        private void ButtonPutOrderInArchive(object sender, RoutedEventArgs e)
        {
            _timerForOrders.Stop();
            if (AdminViewModel.PutOrTakeOrderArchive((sender as Button).DataContext as Order, true))
                UpdateOrders();
            _timerForOrders.Start();
        }
    }
}
