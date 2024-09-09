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
    /// Логика взаимодействия для AdminAddOrEditProdCategoryPage.xaml
    /// </summary>
    public partial class AdminAddOrEditProdCategoryPage : Page
    {
        private Category _currentCategory = new Category();
        public AdminAddOrEditProdCategoryPage(Category targetCategory)
        {
            InitializeComponent();
            if (targetCategory != null)
            {
                DataContext = targetCategory;
                _currentCategory = targetCategory;
            }
        }

        private void ButtonSaveCategoryChanges(object sender, RoutedEventArgs e)
        {
            if(AdminViewModel.AddOrEditProductCategory(_currentCategory, InputName.Text))
                UIManager.WorkerAdminFrame.GoBack();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            UIManager.WorkerAdminFrame.GoBack();
        }
    }
}
