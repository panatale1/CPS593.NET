﻿using System;
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

namespace Final2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            DataContext = new ContactsVM();
            System.Windows.Data.CollectionViewSource personViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("personViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // personViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource addressViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("addressViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // addressViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource emailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("emailViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // emailViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource phoneViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("phoneViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // phoneViewSource.Source = [generic data source]
        }
    }
}