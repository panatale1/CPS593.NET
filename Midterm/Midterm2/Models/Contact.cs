using System;
using System.Collections.Generic;

namespace Midterm2.Models
{
    public partial class Contact
    {
        public Contact()
        {
            this.Addresses = new List<Address>();
            this.ContactMethods = new List<ContactMethod>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int KeywordsId { get; set; }
        public string fbid { get; set; }
        public Nullable<int> Keyword_Id { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ContactMethod> ContactMethods { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
