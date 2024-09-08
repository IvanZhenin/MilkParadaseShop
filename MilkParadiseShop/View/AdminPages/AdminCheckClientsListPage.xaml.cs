#nullable disable
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
using MilkParadiseShop.Helpers;
using MilkParadiseShop.ViewModel;
using MilkParadiseShop.Model;

namespace MilkParadiseShop.View.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminCheckClientsListPage.xaml
    /// </summary>
    public partial class AdminCheckClientsListPage : Page
    {
        private DispatcherTimer _timerForClients = new DispatcherTimer();
        public AdminCheckClientsListPage()
        {
            InitializeComponent();
            ChooseClientGender.ItemsSource = NamesCollector.GetSearchList(NamesCollector.WorkersGenderTypeList, true);
            TimerActivate();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateClients();
            _timerForClients.Start();
        }
        private void TimerActivate()
        {
            _timerForClients.Interval = TimeSpan.FromSeconds(1.5);
            _timerForClients.Tick += OnDispatcherTimerTick;
            _timerForClients.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateClients();
        }
        private void UpdateClients()
        {
            if (CheckSearchWorkers.IsChecked == true)
            {
                DataGridAdminCheckClients.ItemsSource = AdminViewModel.UpdateDataGridClientsWithSearch(InputClientId.Text, InputClientName.Text,
                    ChooseClientGender.SelectedIndex == 0 ? null : ChooseClientGender.SelectedItem.ToString());
            }
            else
            {
                DataGridAdminCheckClients.ItemsSource = AdminViewModel.GetAdminClientsList();
            }
        }
        private void ButtonEditClientDiscout(object sender, RoutedEventArgs e)
        {
            _timerForClients.Stop();
            AdminChooseClientDiscountWindow adminChooseClientDiscountWindow
                = new AdminChooseClientDiscountWindow((sender as Button).DataContext as Client);
            adminChooseClientDiscountWindow.ShowDialog();
            UpdateClients();
            _timerForClients.Start();
        }

        private void ButtonDeleteClient(object sender, RoutedEventArgs e)
        {
            _timerForClients.Stop();
            if (AdminViewModel.DeleteCurrentClient((sender as Button).DataContext as Client))
                UpdateClients();
            _timerForClients.Start();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            _timerForClients.Stop();
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}
