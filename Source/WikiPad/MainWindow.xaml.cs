﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WikiPad
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = !((MainViewModel)this.DataContext).CanClose();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ((MainViewModel)this.DataContext).Closed();
        }

        private void WebBrowser_OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            // ((MainViewModel)this.DataContext).OnLoadCompleted();
            var webBrowser = sender as WebBrowser;
            var dom = webBrowser.Document;
            var body = dom.GetType().GetProperty("body").GetValue(dom, null);
        }
    }
}
