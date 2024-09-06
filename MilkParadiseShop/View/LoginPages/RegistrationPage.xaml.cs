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
using MilkParadiseShop.Helpers;

namespace MilkParadiseShop.View.LoginPages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationDataPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void ButtonAddNewAccount(object sender, RoutedEventArgs e)
        {
            LoginViewModel.Registration(NameField.Text, SurnameField.Text, MaleGenderCheck.IsChecked == true ? "Муж" : "Жен", 
                PhoneNumberField.Text, EmailField.Text, LoginField.Text, 
                PasswordField.Text, RepeatPasswordField.Text, PatronymicField.Text);
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.LoginDataPanelFrame.GoBack();
        }
    }
}
