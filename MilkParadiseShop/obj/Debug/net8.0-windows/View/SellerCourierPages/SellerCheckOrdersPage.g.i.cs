// Updated by XamlIntelliSenseFileGenerator 07.09.2024 23:16:29
#pragma checksum "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644D129BD0743AE7CE1C132893891E39E8227C1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MilkParadiseShop.View.SellerPages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MilkParadiseShop.View.SellerPages
{


    /// <summary>
    /// SellerCheckOrdersPage
    /// </summary>
    public partial class SellerCourierCheckOrdersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {


#line 22 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextDataOfSellerAccount;

#line default
#line hidden


#line 27 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextOrdersCount;

#line default
#line hidden


#line 30 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputOrderId;

#line default
#line hidden


#line 33 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SelectOrderDateCreate;

#line default
#line hidden


#line 36 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ChooseOrderStatus;

#line default
#line hidden


#line 38 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckSearchOrders;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MilkParadiseShop;V1.0.0.0;component/view/sellercourierpages/sellercheckorderspag" +
                    "e.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((MilkParadiseShop.View.SellerPages.SellerCourierCheckOrdersPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.PageIsVisibleChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.TextDataOfSellerAccount = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.TextOrdersCount = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.InputOrderId = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.SelectOrderDateCreate = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 6:
                    this.ChooseOrderStatus = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 7:
                    this.CheckSearchOrders = ((System.Windows.Controls.CheckBox)(target));
                    return;
                case 8:
                    this.DataGridSellerOrders = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 13:

#line 86 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoLogout);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 9:

#line 55 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCheckOrderCart);

#line default
#line hidden
                    break;
                case 10:

#line 62 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonTakeOrder);

#line default
#line hidden
                    break;
                case 11:

#line 69 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAcceptOrder);

#line default
#line hidden
                    break;
                case 12:

#line 76 "..\..\..\..\..\View\SellerCourierPages\SellerCheckOrdersPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCancelOrder);

#line default
#line hidden
                    break;
            }
        }

        internal System.Windows.Controls.DataGrid DataGridSellerCourierOrders;
    }
}

