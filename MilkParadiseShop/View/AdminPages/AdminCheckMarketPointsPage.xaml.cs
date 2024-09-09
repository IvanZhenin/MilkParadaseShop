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
    /// Логика взаимодействия для AdminCheckMarketPointsPage.xaml
    /// </summary>
    public partial class AdminCheckMarketPointsPage : Page
    {
        private DispatcherTimer _timerForMarketPoints = new DispatcherTimer();
        public AdminCheckMarketPointsPage()
        {
            InitializeComponent();
            TimerActivate();
        }
        private void TimerActivate()
        {
            _timerForMarketPoints.Interval = TimeSpan.FromSeconds(1.5);
            _timerForMarketPoints.Tick += OnDispatcherTimerTick;
            _timerForMarketPoints.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateMarketPoints();
        }
        private void UpdateMarketPoints()
        {
            DataGridAdminCheckMarketPoints.ItemsSource = AdminViewModel.GetAdminMarketPointsList();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _timerForMarketPoints.Start();
            UpdateMarketPoints();
        }
        private void ButtonEditMarketPoint(object sender, RoutedEventArgs e)
        {
            _timerForMarketPoints.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminAddOrEditMarketPointPage((sender as Button).DataContext as MarketPoint));
        }

        private void ButtonAddNewMarketPoint(object sender, RoutedEventArgs e)
        {
            _timerForMarketPoints.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminAddOrEditMarketPointPage(null));
        }

        private void ButtonDeleteMarketPoint(object sender, RoutedEventArgs e)
        {
            _timerForMarketPoints.Stop();
            if (AdminViewModel.DeleteCurrentMarketPoint((sender as Button).DataContext as MarketPoint))
                UpdateMarketPoints();
            _timerForMarketPoints.Start();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            _timerForMarketPoints.Stop();
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}