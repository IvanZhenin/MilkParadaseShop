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
    /// Логика взаимодействия для AdminAddOrEditProductPage.xaml
    /// </summary>
    public partial class AdminAddOrEditProductPage : Page
    {
        private Product _currentProduct = new Product();
        public AdminAddOrEditProductPage(Product targetProduct)
        {
            InitializeComponent();
            if (targetProduct != null) 
            {
                DataContext = targetProduct;
                _currentProduct = targetProduct;
                if (targetProduct.Image != null)
                    InputImage.Source = ImageByteConverter.ByteConvertToImageSource(targetProduct.Image);
            }
            
            ChooseProductCategory.ItemsSource = NamesCollector.CategoriesNames();
            if (targetProduct != null)
                ChooseProductCategory.SelectedIndex = NamesCollector.CategoriesNames().IndexOf(targetProduct.CategoryName);
        }
        private void ButtonSaveProductChanges(object sender, RoutedEventArgs e)
        {
            if (AdminViewModel.AddOrEditProduct(_currentProduct,InputName.Text,
                ChooseProductCategory.SelectedIndex >= 0 ? ChooseProductCategory.SelectedItem.ToString() : null,
                InputEquipment.Text, InputWeight.Text, InputPrice.Text, InputImage.Source as BitmapImage))
                UIManager.WorkerAdminFrame.GoBack();
        }
        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonLoadNewImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = ImageByteConverter.GetNewBitmapImage();
        }

        private void ButtonClearCurrentImage(object sender, RoutedEventArgs e)
        {
            InputImage.Source = null;
        }
    }
}
