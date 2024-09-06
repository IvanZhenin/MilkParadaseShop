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

namespace MilkParadiseShop.View.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для ClientPreviewCartInOrder.xaml
    /// </summary>
    public partial class ClientPreviewCartInOrderPage : Page
    {
        public ClientPreviewCartInOrderPage()
        {
            InitializeComponent();
        }

        private void ButtonDeletePositionFromCart(object sender, RoutedEventArgs e)
        {
            ClientViewModel.DeletePositionFromCart((sender as Button).DataContext as ClientProduct);
            CheckProductsPositionInCart();
        }
        private void ButtonGoToChooseInOrder(object sender, RoutedEventArgs e)
        {
            UIManager.ClientFrame.Navigate(new ClientAcceptOrderOrCancelPage());
        }
        private void ButtonEditPositionQuantity(object sender, RoutedEventArgs e)
        {
            ClientChooseProdQuantityWindow clientChooseProdQuantityWindow
                = new ClientChooseProdQuantityWindow(null, (sender as Button).DataContext as ClientProduct);
            clientChooseProdQuantityWindow.ShowDialog();
            CheckProductsPositionInCart();
        }
        private void ButtonClearCurrentShoppingCart(object sender, RoutedEventArgs e)
        {
            ClientViewModel.ClearClientShoppingCart();
            CheckProductsPositionInCart();
        }
        private void CheckProductsPositionInCart()
        {
            UpdateCartList();
            if (DataGridProductsInCart.Items.Count == 0)
            {
                MessageBox.Show("Ваша корзина пустая!", "Внимание");
                UIManager.ClientFrame.GoBack();
                return;
            }
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateCartList();
        }
        private void UpdateCartList()
        {
            DataGridProductsInCart.ItemsSource = ClientViewModel.UpdateDataGridClientShoppingCart();
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.ClientFrame.GoBack();
        }
    }
}
