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

namespace MilkParadiseShop.View.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminAddOrEditMarketPointPage.xaml
    /// </summary>
    public partial class AdminAddOrEditMarketPointPage : Page
    {
        private MarketPoint _currentPoint = new MarketPoint();
        public AdminAddOrEditMarketPointPage(MarketPoint targetPoint)
        {
            InitializeComponent();
            if (targetPoint != null) 
            {
                DataContext = targetPoint;
                _currentPoint = targetPoint;
            }
        }

        private void ButtonSaveMarketPointChanges(object sender, RoutedEventArgs e)
        {
            if (AdminViewModel.AddOrEditMarketPoint(_currentPoint, InputAddress.Text))
                UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}
