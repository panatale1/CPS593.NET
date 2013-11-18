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

namespace BasicContacts
{
    /// <summary>
    /// Interaction logic for ContactsWindow.xaml
    /// </summary>
    public partial class ContactsWindow : Window
    {
        public ContactsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactsVM();
            //System.Windows.Data.CollectionViewSource contactsVMViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactsVMViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // contactsVMViewSource.Source = [generic data source]
        }
    }
}
