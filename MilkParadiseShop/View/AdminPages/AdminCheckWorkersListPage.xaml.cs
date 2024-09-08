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
    /// Логика взаимодействия для AdminCheckWorkersListPage.xaml
    /// </summary>
    public partial class AdminCheckWorkersListPage : Page
    {
        private DispatcherTimer _timerForWorkers = new DispatcherTimer();
        public AdminCheckWorkersListPage()
        {
            InitializeComponent();
            SelectWorkerRole.ItemsSource = NamesCollector.GetSearchList(AdminViewModel.GetJobRoleNamesForAdmin(), false);
            ChooseWorkerGender.ItemsSource = NamesCollector.GetSearchList(NamesCollector.WorkersGenderTypeList, true);
            TimerActivate();
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _timerForWorkers.Start();
            UpdateWorkers();
        }
        private void TimerActivate()
        {
            _timerForWorkers.Interval = TimeSpan.FromSeconds(1.5);
            _timerForWorkers.Tick += OnDispatcherTimerTick;
            _timerForWorkers.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateWorkers();
        }
        private void UpdateWorkers()
        {
            if (CheckSearchWorkers.IsChecked == true)
            {
                DataGridAdminCheckWorkers.ItemsSource = AdminViewModel.UpdateDataGridWorkersWithSearch(InputWorkerId.Text,
                    SelectWorkerRole.SelectedIndex == 0 ? null : SelectWorkerRole.SelectedItem.ToString(),
                    ChooseWorkerGender.SelectedIndex == 0 ? null : ChooseWorkerGender.SelectedItem.ToString());
            }
            else
            {
                DataGridAdminCheckWorkers.ItemsSource = AdminViewModel.GetAdminWorkersList();
            }
        }

        private void ButtonAddNewWorker(object sender, RoutedEventArgs e)
        {
            _timerForWorkers.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminAddNewWorkerPage());
        }

        private void ButtonEditWorker(object sender, RoutedEventArgs e)
        {
            _timerForWorkers.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminEditWorkersDataPage((sender as Button).DataContext as Worker));
            _timerForWorkers.Start();
        }

        private void ButtonDeleteWorker(object sender, RoutedEventArgs e)
        {
            _timerForWorkers.Stop();
            if (AdminViewModel.DeleteCurrentWorker((sender as Button).DataContext as Worker))
                UpdateWorkers();
            _timerForWorkers.Start();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            _timerForWorkers.Stop();
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}
