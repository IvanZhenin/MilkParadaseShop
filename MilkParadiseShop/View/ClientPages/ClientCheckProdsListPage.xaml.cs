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
    /// Логика взаимодействия для ClientCheckProdsListPage.xaml
    /// </summary>
    public partial class ClientCheckProdsListPage : Page
    {
        private DispatcherTimer _timerForProducts = new DispatcherTimer();
        public ClientCheckProdsListPage()
        {
            InitializeComponent();
            ChooseProductCategory.ItemsSource = NamesCollector.GetSearchList(NamesCollector.CategoriesNames(), false);
            TimerActivate();
        }

        private void TimerActivate()
        {
            _timerForProducts.Interval = TimeSpan.FromSeconds(1.5);
            _timerForProducts.Tick += OnDispatcherTimerTick;
            _timerForProducts.Start();
        }
        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateProducts();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _timerForProducts.Start();
            UpdateProducts();
        }

        private void UpdateProducts()
        {
            if (CheckSearchProducts.IsChecked == true)
            {
                ListViewProducts.ItemsSource = BaseViewModel.UpdateDataGridProductsWithSearch(InputProductName.Text,
                    ChooseProductCategory.SelectedIndex == 0 ? null : ChooseProductCategory.SelectedItem.ToString(),
                    SelectMinimalProductPrice.Text, SelectMaximalProductPrice.Text);
            }
            else
            {
                ListViewProducts.ItemsSource = BaseViewModel.UpdateDataGridProductsWithoutSearch();
            }
            TextCurrentCountProds.Text = $"Товаров в корзине на данный момент: {ShoppingCart.ProductListCount()}";
        }

        private void ButtonGoToCheckShoppingCart(object sender, RoutedEventArgs e)
        {
            _timerForProducts.Stop();
            if (ShoppingCart.ProductListCount() <= 0)
            {
                MessageBox.Show("В корзине отсутствуют товары!", "Внимание");
                _timerForProducts.Start();
                return;
            }
            UIManager.ClientFrame.Navigate(new ClientPreviewCartInOrderPage());
        }

        private void ButtonClearCurrentShoppingCart(object sender, RoutedEventArgs e)
        {
            _timerForProducts.Stop();
            ClientViewModel.ClearClientShoppingCart();
            _timerForProducts.Start();
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            _timerForProducts.Stop();
            UIManager.ClientFrame.GoBack();
        }

        private void ButtonAddNewPositionInShoppingCart(object sender, RoutedEventArgs e)
        {
            _timerForProducts.Stop();
            ClientChooseProdQuantityWindow clientChooseProdQuantityWindow
                = new ClientChooseProdQuantityWindow((sender as Button).DataContext as Product, null);
            clientChooseProdQuantityWindow.ShowDialog();
            _timerForProducts.Start();
        }

        
    }
}