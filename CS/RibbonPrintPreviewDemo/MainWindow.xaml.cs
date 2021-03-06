﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;

namespace RibbonPrintPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }

        //static MainWindow() {
        //    BarManager.CheckBarItemNames = false;
        //}

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            SimpleLink link = new SimpleLink((DataTemplate)Resources["rowTemplate"], 1000);
            LinkPreviewModel model = new LinkPreviewModel();
            model.Link = link;
            viewer.Model = model;
            link.CreateDocument(true);
        }
    }
}
