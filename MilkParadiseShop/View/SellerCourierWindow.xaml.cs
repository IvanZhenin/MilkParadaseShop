using MilkParadiseShop.Helpers;
using MilkParadiseShop.View.ClientPages;
using MilkParadiseShop.View.SellerPages;
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
    /// Логика взаимодействия для SellerWindow.xaml
    /// </summary>
    public partial class SellerCourierWindow : Window
    {
        public SellerCourierWindow()
        {
            InitializeComponent();
            UIManager.WorkerSellerCourierTargetWindow = this;
            UIManager.WorkerSellerCourierFrame = SellerCourierDataPanelFrame;
            UIManager.WorkerSellerCourierFrame.Navigate(new SellerCourierCheckOrdersPage());
        }
    }
}
