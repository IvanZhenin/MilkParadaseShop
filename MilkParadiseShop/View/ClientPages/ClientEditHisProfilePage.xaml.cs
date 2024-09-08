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
    /// Логика взаимодействия для ClientEditHisProfilePage.xaml
    /// </summary>
    public partial class ClientEditHisProfilePage : Page
    {
        public ClientEditHisProfilePage()
        {
            InitializeComponent();
            DataContext = ClientViewModel.GetClientContext();
            if (ClientViewModel.GetClientContext().Gender[0] == 'Ж')
                FemaleGenderCheck.IsChecked = true;
        }

        private void ButtonSaveClientAccountChanges(object sender, RoutedEventArgs e)
        {
            ClientViewModel.EditClientAccountData(InputName.Text, InputSurName.Text, InputPhoneNumber.Text, 
                MaleGenderCheck.IsChecked == true ? "Мужской" : "Женский", InputEmail.Text, 
                InputNewPassword.Text, InputNewPasswordRepeat.Text, CheckEditPassword.IsChecked == true ? true : false,
                String.IsNullOrEmpty(InputPatronymic.Text) == true ? null : InputPatronymic.Text);
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.ClientFrame.GoBack();
        }
    }
}
