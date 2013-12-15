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

namespace FinalProject {
    /// <summary>
    /// Interaction logic for DisplayWindow.xaml
    /// </summary>
    public partial class DisplayWindow : Window {
        public DisplayWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            FinalProject._DataLayerForFinal_FinalContextDataSet _DataLayerForFinal_FinalContextDataSet = ((FinalProject._DataLayerForFinal_FinalContextDataSet)(this.FindResource("_DataLayerForFinal_FinalContextDataSet")));
            // Load data into the table People. You can modify this code as needed.
            FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.PeopleTableAdapter _DataLayerForFinal_FinalContextDataSetPeopleTableAdapter = new FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.PeopleTableAdapter();
            _DataLayerForFinal_FinalContextDataSetPeopleTableAdapter.Fill(_DataLayerForFinal_FinalContextDataSet.People);
            System.Windows.Data.CollectionViewSource peopleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peopleViewSource")));
            peopleViewSource.View.MoveCurrentToFirst();
            // Load data into the table Addresses. You can modify this code as needed.
            FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.AddressesTableAdapter _DataLayerForFinal_FinalContextDataSetAddressesTableAdapter = new FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.AddressesTableAdapter();
            _DataLayerForFinal_FinalContextDataSetAddressesTableAdapter.Fill(_DataLayerForFinal_FinalContextDataSet.Addresses);
            System.Windows.Data.CollectionViewSource addressesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("addressesViewSource")));
            addressesViewSource.View.MoveCurrentToFirst();
            // Load data into the table Emails. You can modify this code as needed.
            FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.EmailsTableAdapter _DataLayerForFinal_FinalContextDataSetEmailsTableAdapter = new FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.EmailsTableAdapter();
            _DataLayerForFinal_FinalContextDataSetEmailsTableAdapter.Fill(_DataLayerForFinal_FinalContextDataSet.Emails);
            System.Windows.Data.CollectionViewSource emailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("emailsViewSource")));
            emailsViewSource.View.MoveCurrentToFirst();
            // Load data into the table Phones. You can modify this code as needed.
            FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.PhonesTableAdapter _DataLayerForFinal_FinalContextDataSetPhonesTableAdapter = new FinalProject._DataLayerForFinal_FinalContextDataSetTableAdapters.PhonesTableAdapter();
            _DataLayerForFinal_FinalContextDataSetPhonesTableAdapter.Fill(_DataLayerForFinal_FinalContextDataSet.Phones);
            System.Windows.Data.CollectionViewSource phonesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("phonesViewSource")));
            phonesViewSource.View.MoveCurrentToFirst();
        }
    }
}
