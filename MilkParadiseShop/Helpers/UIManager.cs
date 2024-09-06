#nullable disable
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MilkParadiseShop.View.LoginPages;

namespace MilkParadiseShop.Helpers
{
    public static class UIManager
    {
        public static Window LoginTargetWindow { get; set; }
        public static Frame LoginDataPanelFrame { get; set; }

        public static Window ClientTargetWindow { get; set; }
        public static Frame ClientFrame { get; set; }

        public static Frame WorkerFrame { get; set; }
    }
}