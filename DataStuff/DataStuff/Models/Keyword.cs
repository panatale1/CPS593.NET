using System;
using System.Collections.Generic;

namespace DataStuff.Models
{
    public partial class Keyword
    {
        public Keyword()
        {
            this.ContactMethods = new List<ContactMethod>();
            this.Contacts = new List<Contact>();
            this.Keywords1 = new List<Keyword>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int KeywordsId { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public virtual ICollection<ContactMethod> ContactMethods { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Keyword> Keywords1 { get; set; }
        public virtual Keyword Keyword1 { get; set; }
    }
}
