#nullable disable
using MilkParadiseShop.Helpers;
using MilkParadiseShop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для AdminAddNewWorkerPage.xaml
    /// </summary>
    public partial class AdminAddNewWorkerPage : Page
    {
        public AdminAddNewWorkerPage()
        {
            InitializeComponent();
            ChooseWorkerRole.ItemsSource = AdminViewModel.GetJobRoleNamesForAdmin();
            ChooseWorkerGender.ItemsSource = NamesCollector.WorkersGenderTypeList;
        }

        private void ButtonLoadNewImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = AdminViewModel.GetNewImage();
        }

        private void ButtonClearCurrentImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = null;
        }
        private void ButtonSaveNewWorkerAccount(object sender, RoutedEventArgs e)
        {
            if (AdminViewModel.AddNewWorker(InputName.Text, InputSurName.Text,ChooseWorkerRole.SelectedItem.ToString(), 
                ChooseWorkerGender.SelectedItem.ToString(), InputPhoneNumber.Text, InputEmail.Text, InputLogin.Text, 
                InputPassword.Text, InputPatronymic.Text, InputImage.Source as BitmapImage))
                UIManager.WorkerAdminFrame.GoBack();
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}