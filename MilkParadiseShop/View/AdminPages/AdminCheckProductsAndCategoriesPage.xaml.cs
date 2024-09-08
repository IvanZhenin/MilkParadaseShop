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
    /// Логика взаимодействия для AdminCheckProductsAndCategoriesPage.xaml
    /// </summary>
    public partial class AdminCheckProductsAndCategoriesPage : Page
    {
        private DispatcherTimer _timerForProdsAndCategories = new DispatcherTimer();
        public AdminCheckProductsAndCategoriesPage()
        {
            InitializeComponent();
            TimerActivate();
        }

        private void TimerActivate()
        {
            _timerForProdsAndCategories.Interval = TimeSpan.FromSeconds(1.5);
            _timerForProdsAndCategories.Tick += OnDispatcherTimerTick;
            _timerForProdsAndCategories.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateProducts();
            UpdateCategories();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateProducts();
            UpdateCategories();
            _timerForProdsAndCategories.Start();
        }

        private void UpdateProducts()
        {
            ListViewProducts.ItemsSource = BaseViewModel.UpdateProductsListWithoutSearch();
        }

        private void UpdateCategories()
        {
            DataGridAdminCheckCategories.ItemsSource = AdminViewModel.GetAdminProdCategoriesList();
        }
        private void ButtonEditCurrentProduct(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminAddOrEditProductPage((sender as Button).DataContext as Product));
        }
        private void ButtonDeleteCurrentProduct(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();
            if (AdminViewModel.DeleteCurrentProduct((sender as Button).DataContext as Product))
                UpdateProducts();
            _timerForProdsAndCategories.Start();
        }
        private void ButtonAddNewProduct(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();
            UIManager.WorkerAdminFrame.Navigate(new AdminAddOrEditProductPage(null));
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonEditCategory(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();

        }

        private void ButtonDeleteCategory(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();

            _timerForProdsAndCategories.Start();
        }

        private void ButtonAddNewCategory(object sender, RoutedEventArgs e)
        {
            _timerForProdsAndCategories.Stop();

        }
    }
}
