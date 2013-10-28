using Midterm2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Input;

namespace Midterm2 {
    class DispVM : BaseVM{
        public ObservableCollection<Contact> Contacts {get; private set;}
        public ObservableCollection<Address> Addresses{get; private set;}
        public ObservableCollection<Keyword> Keywords{get; private set;}
        public ObservableCollection<ContactMethod> ContactMethods { get; private set; }
        private string _ContactsMsg;
        public string ContactsMsg {
            get { return _ContactsMsg; }
            set { _ContactsMsg = value; }
        }
        private string _AddressMsg;
        public string AddressMsg {
            get { return _AddressMsg; }
            set { _AddressMsg = value; }
        }
        private string _MethodsMsg;
        public string MethodsMsg {
            get { return _MethodsMsg; }
            set { _MethodsMsg = value; }
        }
        private string _KeywordsMsg;
        public string KeywordsMsg {
            get { return _KeywordsMsg; }
            set { _KeywordsMsg = value; }
        }
        public DispVM() {
            var db = new CSharpContext();
            Contacts = db.Contacts.Local;
            db.Contacts.Load();
            Addresses = db.Addresses.Local;
            db.Addresses.Load();
            Keywords = db.Keywords.Local;
            db.Keywords.Load();
            ContactMethods = db.ContactMethods.Local;
            db.ContactMethods.Load();
            ContactsMsg = "There are " + Contacts.Count + " entries in the table.";
            KeywordsMsg = "There are " + Keywords.Count + " entries in the table.";
            MethodsMsg = "There are " + ContactMethods.Count + " entries in the table.";
            AddressMsg = "There are " + Addresses.Count + " entries in the table.";
            

        }
    }
}
