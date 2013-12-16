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
using Final2.Bubble;

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
            var BubbleClient = new Bubble.ContactsSoapClient();
            //db = new FinalContext();

            //ContactList = db.People.Local;
            //db.People.Load();

            //EmailList = db.Emails.Local;
            //db.Emails.Load();

            //PhoneList = db.Phones.Local;
            //db.Phones.Load();

            //AddressList = db.Addresses.Local;
            //db.Addresses.Load();
            ContactList = new ObservableCollection<Person>();
            EmailList = new ObservableCollection<Email>();
            PhoneList = new ObservableCollection<Phone>();
            AddressList = new ObservableCollection<Address>();
            Init();

            SaveCommand = new DelegateCommand(() => BubbleClient.Save());
            AddPersonCommand = new DelegateCommand(() => {
                CurrentPerson = new Person();
                ContactList.Add(CurrentPerson);
                BubbleClient.AddPersonAsync(CurrentPerson);
            });
            AddEmailCommand = new DelegateCommand(() => {
                var em = new Email();
                em.PersonID = CurrentPerson.PID;
                EmailList.Add(em);
                CurrentPerson.elist.Add(em);
                BubbleClient.AddEmailAsync(em);
            });
            DeletePersonCommand = new DelegateCommand(() => {
                db.People.Remove(CurrentPerson);
                ContactList.Remove(CurrentPerson);
            });
            AddPhoneCommand = new DelegateCommand(() => {
                var pn = new Phone();
                pn.PersonID = CurrentPerson.PID;
                PhoneList.Add(pn);
                CurrentPerson.plist.Add(pn);
                BubbleClient.AddPhoneAsync(pn);
            });
            AddAddressCommand = new DelegateCommand(() => {
                var ad = new Address();
                ad.PersonID = CurrentPerson.PID;
                CurrentPerson.alist.Add(ad);
                AddressList.Add(ad);
                BubbleClient.AddAddressAsync(ad);
            });
            DeleteAddressCommand = new DelegateCommand(() => {
                CurrentPerson.alist.Remove(CurrentAddress);
                AddressList.Remove(CurrentAddress);
                BubbleClient.RemoveAddressAsync(CurrentAddress);
            });
            DeletePhoneCommand = new DelegateCommand(() => {

                CurrentPerson.plist.Remove(CurrentPhone);
                PhoneList.Remove(CurrentPhone);
                BubbleClient.RemovePhoneAsync(CurrentPhone);
            });
            DeleteEmailCommand = new DelegateCommand(() => {

                CurrentPerson.elist.Remove(CurrentEmail);
                EmailList.Remove(CurrentEmail);
                BubbleClient.RemoveEmailAsync(CurrentEmail);
            });
        }

        async void Init() {
            var soapClient = new Bubble.ContactsSoapClient();
            IEnumerable<Person> persons;
            IEnumerable<Email> ems;
            IEnumerable<Address> ads;
            IEnumerable<Phone> phs;

            persons = await soapClient.GetPeopleAsync();
            foreach (var dude in persons) {
                ContactList.Add(dude);
            }
            ems = await soapClient.GetEmailsAsync();
            foreach (var e in ems) {
                EmailList.Add(e);
            }
            ads = await soapClient.GetAddressesAsync();
            foreach (var a in ads) {
                AddressList.Add(a);
            }
            phs = await soapClient.GetPhonesAsync();
            foreach (var p in phs) {
                PhoneList.Add(p);
            }

            foreach (var dude in ContactList) {
                foreach (var e in EmailList) {
                    if (dude.PID == e.PersonID) {
                        dude.elist.Add(e);
                    }
                }
                foreach (var a in AddressList) {
                    if (dude.PID == a.PersonID){
                        dude.alist.Add(a);
                    }
                }
                foreach (var p in PhoneList) {
                    if (dude.PID == p.PersonID) {
                        dude.plist.Add(p);
                    }
                }
            }
        }
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

