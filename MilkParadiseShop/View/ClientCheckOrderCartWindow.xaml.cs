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
using System.Windows.Shapes;

namespace MilkParadiseShop.View
{
    /// <summary>
    /// Логика взаимодействия для ClientCheckOrderCartWindow.xaml
    /// </summary>
    public partial class ClientCheckOrderCartWindow : Window
    {
        public ClientCheckOrderCartWindow(Order currentOrder)
        {
            InitializeComponent();
            Title += $" [{currentOrder.NumId}]";
            DataGridProductsInOrder.ItemsSource = ClientViewModel.GetProductListInOrder(currentOrder);
        }
    }
}
