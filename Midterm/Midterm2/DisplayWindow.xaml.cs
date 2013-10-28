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
using System.Windows.Shapes;

namespace Midterm2 {
    /// <summary>
    /// Interaction logic for DisplayWindow.xaml
    /// </summary>
    public partial class DisplayWindow : Window {
        public DisplayWindow() {
            InitializeComponent();
        }
        private string _AddressMessage;
        public string AddressMessage {
            get { return _AddressMessage; }
            set { _AddressMessage = value; }
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            DataContext = new DispVM();   
            System.Windows.Data.CollectionViewSource addressViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("addressViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // addressViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource contactViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // contactViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource contactMethodViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactMethodViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // contactMethodViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource keywordViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("keywordViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // keywordViewSource.Source = [generic data source]
        }
    }
}
