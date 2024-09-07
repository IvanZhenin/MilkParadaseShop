#nullable disable
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
using System.Windows.Shapes;
using MilkParadiseShop.ViewModel;

namespace MilkParadiseShop.View
{
    /// <summary>
    /// Логика взаимодействия для ClientChooseProdQuantity.xaml
    /// </summary>
    public partial class ClientChooseProdQuantityWindow : Window
    {
        private Product _currentProd = new Product();
        private ClientProduct _currentPos = new ClientProduct();
        public ClientChooseProdQuantityWindow(Product product = null, ClientProduct clientProduct = null)
        {
            InitializeComponent();
            if (clientProduct == null)
            {
                TextCurrentProduct.Text = $"Добавление товара {product.Name}";
                _currentProd = product;
            }
            else
            {
                Title = $"Изменение позиции";
                TextCurrentProduct.Text = $"Изменение позиции товара {clientProduct.ProdName}";
                _currentPos = clientProduct;
            }
        }

        private void ButtonAcceptNewProductInShoppingCart(object sender, RoutedEventArgs e)
        {
            if (_currentPos.ProdId <= 0)
            {
                if (ClientViewModel.AddNewPositionInClientShoppingCart(InputProductQuantity.Text, _currentProd, null))
                    this.Close();
            }
            else
            {
                if (ClientViewModel.AddNewPositionInClientShoppingCart(InputProductQuantity.Text, null, _currentPos))
                    this.Close();
            }
        }
        private void ButtonCloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}