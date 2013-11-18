using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataLayer.Models
{
    public partial class Contact
    {
        public Contact()
        {
            this.ContactMethods = new ObservableCollection<ContactMethod>();
            this.Addresses = new ObservableCollection<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int KeywordId { get; set; }
        public string fbid { get; set; }
        public virtual ICollection<ContactMethod> ContactMethods { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
