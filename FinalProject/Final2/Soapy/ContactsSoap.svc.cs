using DataLayerForFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace Soapy {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ContactsSoap" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ContactsSoap.svc or ContactsSoap.svc.cs at the Solution Explorer and start debugging.
    public class ContactsSoap : IContactsSoap{
        public void DoWork() {
        }

        FinalContext db = new FinalContext();
        //db.Configuration.ProxyCreationENabled = false;
        public IEnumerable<Person> GetPeople() {
            /*var db = new FinalContext();*/
            db.Configuration.ProxyCreationEnabled = false;
            return db.People.OrderBy(x => x.LastName).ToList();
        }
        
        public IEnumerable<Email> GetEmails() {
            //var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Emails.ToList();
        }
        
        public IEnumerable<Phone> GetPhones() {
           // var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Phones.ToList();
        }
        
        public IEnumerable<Address> GetAddresses() {
            //var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Addresses.ToList();
        }

        public void AddPerson(Person dude) {
            //var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            db.People.Add(dude);
        }
        public void AddAddress(Address ad) {
           // var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            db.Addresses.Add(ad);
        }
        public void AddEmail(Email em) {
          //  var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            db.Emails.Add(em);
        }
        public void AddPhone(Phone pn) {
          //  var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            db.Phones.Add(pn);
        }
        public void Save() {
            //var db = new FinalContext();
            db.Configuration.ProxyCreationEnabled = false;
            db.SaveChanges();
        }
        public void RemovePerson(Person dude) {
            db.Configuration.ProxyCreationEnabled = false;
            db.People.Remove(dude);
        }
        public void RemoveEmail(Email em) {
            db.Configuration.ProxyCreationEnabled = false;
            db.Emails.Remove(em);
        }
        public void RemoveAddress(Address ad) {
            db.Configuration.ProxyCreationEnabled = false;
            db.Addresses.Remove(ad);
        }
        public void RemovePhone(Phone pn) {
            db.Configuration.ProxyCreationEnabled = false;
            db.Phones.Remove(pn);
        }
    }
}
