using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerForFinal;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Data.Entity;

namespace Final2 {
    class ContactsVM : BaseVM {
        public ICommand SaveCommand { get; set; }
        public ICommand AddPersonCommand { get; set; }
        public ICommand AddEmailCommand { get; set; }
        public ICommand AddAddressCommand { get; set; }
        public ICommand AddPhoneCommand { get; set; }
        public ICommand DeletePersonCommand { get; set; }
        public ICommand DeleteEmailCommand { get; set; }
        public ICommand DeleteAddressCommand { get; set; }
        public ICommand DeletePhoneCommand { get; set; }

        public ObservableCollection<Person> ContactList { get; private set; }
        public ObservableCollection<Email> EmailList { get; private set; }
        public ObservableCollection<Address> AddressList { get; private set; }
        public ObservableCollection<Phone> PhoneList { get; private set; }
        public ObservableCollection<CType> TypeList { get; private set; }
        private Person _CurrentPerson;

        public Person CurrentPerson {
            get { return _CurrentPerson; }
            set {
                _CurrentPerson = value;
                OnPropertyChanged();
            }
        }
        private Address _CurrentAddress;

        public Address CurrentAddress {
            get { return _CurrentAddress; }
            set { _CurrentAddress = value; OnPropertyChanged(); }
        }
        private Email _CurrentEmail;

        public Email CurrentEmail {
            get { return _CurrentEmail; }
            set { _CurrentEmail = value; OnPropertyChanged(); }
        }
        private Phone _CurrentPhone;

        public Phone CurrentPhone {
            get { return _CurrentPhone; }
            set { _CurrentPhone = value; OnPropertyChanged(); }
        }
        FinalContext db;
        public ContactsVM() {
            db = new FinalContext();

            ContactList = db.People.Local;
            db.People.Load();

            EmailList = db.Emails.Local;
            db.Emails.Load();

            PhoneList = db.Phones.Local;
            db.Phones.Load();

            AddressList = db.Addresses.Local;
            db.Addresses.Load();



            SaveCommand = new DelegateCommand(() => db.SaveChanges());
            AddPersonCommand = new DelegateCommand(() => {
                CurrentPerson = new Person();
                ContactList.Add(CurrentPerson);
                db.People.Add(CurrentPerson);
            });
            AddEmailCommand = new DelegateCommand(() => {
                var em = new Email();
                EmailList.Add(em);
                db.Emails.Add(em);
            });
            DeletePersonCommand = new DelegateCommand(() => {
                db.People.Remove(CurrentPerson);
                ContactList.Remove(CurrentPerson);
            });
            AddPhoneCommand = new DelegateCommand(() => {
                var pn = new Phone();
                PhoneList.Add(pn);
                db.Phones.Add(pn);
            });
            AddAddressCommand = new DelegateCommand(() => {
                var ad = new Address();
                AddressList.Add(ad);
                db.Addresses.Add(ad);
            });
            DeleteAddressCommand = new DelegateCommand(() => {
                db.Addresses.Remove(CurrentAddress);
                AddressList.Remove(CurrentAddress);
            });
            DeletePhoneCommand = new DelegateCommand(() => {
                
                db.Phones.Remove(CurrentPhone);
                PhoneList.Remove(CurrentPhone);
            });
            DeleteEmailCommand = new DelegateCommand(() => {
                
                db.Emails.Remove(CurrentEmail);
                EmailList.Remove(CurrentEmail);
            });
        }
        void LoadEmails() {

        }
    }
    public class BaseVM : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class DelegateCommand : ICommand {
        public Action _Action;
        private Func<bool> _CanExecute;

        public DelegateCommand(Action action, Func<bool> canExecute = null) {
            _Action = action;
            _CanExecute = canExecute;
        }
        public bool CanExecute(object parameter) {
            if (_CanExecute == null)
                return true;
            else
                return _CanExecute();
        }
        public event EventHandler CanExecuteChanged;
        public void OnCanExecuteChanged() {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }
        public void Execute(object parameter) {
            _Action();
        }
    }
}
