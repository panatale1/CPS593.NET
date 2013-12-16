using DataLayerForFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Soapy {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContactsSoap" in both code and config file together.
    [ServiceContract]
    public interface IContactsSoap {
        [OperationContract]
        void DoWork();
        [OperationContract]
        IEnumerable<Person> GetPeople();
        [OperationContract]
        IEnumerable<Email> GetEmails();
        [OperationContract]
        IEnumerable<Phone> GetPhones();
        [OperationContract]
        IEnumerable<Address> GetAddresses();
        [OperationContract]
        void AddPerson(Person dude);
        [OperationContract]
        void AddEmail(Email em);
        [OperationContract]
        void AddAddress(Address ad);
        [OperationContract]
        void AddPhone(Phone pn);
        [OperationContract]
        void Save();
        [OperationContract]
        void RemovePerson(Person dude);
        [OperationContract]
        void RemoveEmail(Email em);
        [OperationContract]
        void RemoveAddress(Address ad);
        [OperationContract]
        void RemovePhone(Phone pn);
    }
}
