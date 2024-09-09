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
using MilkParadiseShop.Enums;
using MilkParadiseShop.Helpers;

namespace MilkParadiseShop.View.LoginPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationDataPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void ButtonEnterInAccount(object sender, RoutedEventArgs e)
        {
            LoginViewModel.Authorization(LoginField.Text, PasswordField.Password,
                ClientButtonCheck.IsChecked == true ? UserOrientation.Client : UserOrientation.Worker);
        }

        private void ButtonGoCreateNewAccount(object sender, RoutedEventArgs e)
        {
            UIManager.LoginDataPanelFrame.Navigate(new RegistrationPage());
        }
    }
}