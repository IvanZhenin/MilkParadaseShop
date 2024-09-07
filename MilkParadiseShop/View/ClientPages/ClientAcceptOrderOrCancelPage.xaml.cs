using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
using MilkParadiseShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MilkParadiseShop.View.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для ClientAcceptOrderOrCancelPage.xaml
    /// </summary>
    public partial class ClientAcceptOrderOrCancelPage : Page
    {
        public ClientAcceptOrderOrCancelPage()
        {
            InitializeComponent();
            SelectMethodReceiveProds.ItemsSource = NamesCollector.WorkingOrderTypeList;
            SelectMarketPoint.ItemsSource = ClientViewModel.GetMarketPointsNames();
            TextClientDiscountPercent.Text += $"{ClientLogin.Discount}%";
        }

        private void UpdateCartList()
        {
            DataGridFinalShoppingCart.ItemsSource = ClientViewModel.UpdateDataGridClientShoppingCart();
            InputTotalOrderAmount.Text = ClientViewModel.GetTotalPrice().ToString();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateCartList();
        }
        private void ButtonAcceptOrder(object sender, RoutedEventArgs e)
        {
            if (ClientViewModel.AcceptNewClientOrder(ClientLogin.NumId, SelectMarketPoint.Visibility == Visibility.Visible ?
                SelectMarketPoint.SelectedItem.ToString() : InputAddress.Text,
                SelectMethodReceiveProds.SelectedItem.ToString(), ClientViewModel.GetTotalPrice()))
                UIManager.ClientGoStartPageAfterOrder();
        }
        
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.ClientFrame.GoBack();
        }

        private void SelectMethodReceiveProdsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectMethodReceiveProds.SelectedIndex == 0) 
            {
                InputAddress.Visibility = Visibility.Collapsed;
                SelectMarketPoint.Visibility = Visibility.Visible;
            }
            else
            {
                InputAddress.Visibility = Visibility.Visible;
                SelectMarketPoint.Visibility = Visibility.Collapsed;
            }
        }
    }
}