﻿#pragma checksum "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DA6422CCE30FA9FCA5DD910B566795D2BB55E0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MilkParadiseShop.View.ClientPages;
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


namespace MilkParadiseShop.View.ClientPages {
    
    
    /// <summary>
    /// ClientAcceptOrderOrCancelPage
    /// </summary>
    public partial class ClientAcceptOrderOrCancelPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridFinalShoppingCart;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectMethodReceiveProds;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectMarketPoint;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputAddress;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextClientDiscountPercent;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTotalOrderAmount;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/MilkParadiseShop;component/view/clientpages/clientacceptorderorcancelpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
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
            
            #line 10 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
            ((MilkParadiseShop.View.ClientPages.ClientAcceptOrderOrCancelPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.PageIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridFinalShoppingCart = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.SelectMethodReceiveProds = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
            this.SelectMethodReceiveProds.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectMethodReceiveProdsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SelectMarketPoint = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
            this.SelectMarketPoint.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectMethodReceiveProdsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InputAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextClientDiscountPercent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.InputTotalOrderAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 62 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAcceptOrder);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 66 "..\..\..\..\..\View\ClientPages\ClientAcceptOrderOrCancelPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

