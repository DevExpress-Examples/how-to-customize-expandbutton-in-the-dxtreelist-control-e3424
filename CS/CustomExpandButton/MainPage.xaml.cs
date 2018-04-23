using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace CustomExpandButton {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            ThemeManager.ApplicationTheme = Theme.DeepBlue;
        }
    }
    public class SimpleData {
        public string Column1 { get; set; }
        public int Column2 { get; set; }

        public int Id { get; set; }
        public int ParentId { get; set; }

        public SimpleData() { }

        public SimpleData(string str1, int int2) {
            Column1 = str1;
            Column2 = int2;
        }
    }   
}