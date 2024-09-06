using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using MilkParadiseShop.Model;
using MilkParadiseShop.Helpers;
using MilkParadiseShop.View.LoginPages;

namespace MilkParadiseShop
{
    /// <summary>
    /// Interaction logic for AuthorizationWindowWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            UIManager.LoginTargetWindow = this;
            UIManager.LoginDataPanelFrame = LoginDataPanelFrame;
            UIManager.LoginDataPanelFrame.Navigate(new AuthorizationPage());
        }
    }
}