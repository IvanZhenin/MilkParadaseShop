﻿#pragma checksum "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17BAE5BAA4A0435AE3617D61DBC95E0BC4020BBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MilkParadiseShop.View.AdminPages;
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


namespace MilkParadiseShop.View.AdminPages {
    
    
    /// <summary>
    /// AdminGeneralPanelPage
    /// </summary>
    public partial class AdminGeneralPanelPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MilkParadiseShop;component/view/adminpages/admingeneralpanelpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoCheckWorkers);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoCheckClients);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoCheckOrders);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoCheckProductsAndCategories);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 16 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoCheckShopPoints);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 17 "..\..\..\..\..\View\AdminPages\AdminGeneralPanelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoLogout);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
