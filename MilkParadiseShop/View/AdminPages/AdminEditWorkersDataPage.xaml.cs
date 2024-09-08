#nullable disable
using MilkParadiseShop.Helpers;
using MilkParadiseShop.Model;
using MilkParadiseShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для AdminEditWorkersDataPage.xaml
    /// </summary>
    public partial class AdminEditWorkersDataPage : Page
    {
        public AdminEditWorkersDataPage(Worker targerWorker)
        {
            InitializeComponent();
            DataContext = targerWorker;
            if(targerWorker.Image != null)
                InputImage.Source = AdminViewModel.ByteConvertToImageSource(targerWorker.Image);
            ChooseWorkerRole.ItemsSource = AdminViewModel.GetJobRoleNamesForAdmin();
            ChooseWorkerRole.SelectedIndex = AdminViewModel.GetIndexOfJobRoleName(targerWorker);
            ChooseWorkerGender.ItemsSource = NamesCollector.WorkersGenderTypeList;
            ChooseWorkerGender.SelectedIndex = targerWorker.Gender[0] == 'М' ? 0 : 1;
        }

        private void ButtonLoadNewImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = AdminViewModel.GetNewImage();
        }

        private void ButtonClearCurrentImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = null;
        }

        private void ButtonSaveWorkerAccountChanges(object sender, RoutedEventArgs e)
        {
            if (AdminViewModel.EditCurrentWorker((sender as Button).DataContext as Worker,
                InputName.Text, InputSurName.Text, ChooseWorkerRole.SelectedItem.ToString(),
                ChooseWorkerGender.SelectedItem.ToString(), InputPhoneNumber.Text, InputEmail.Text, InputLogin.Text, InputNewPassword.Text,
                CheckEditPassword.IsChecked == true ? true : false, InputPatronymic.Text,
                InputImage.Source as BitmapImage))
                UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}