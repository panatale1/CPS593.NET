//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Keyword
    {
        public Keyword()
        {
            this.Children = new HashSet<Keyword>();
            this.Contacts = new HashSet<Contact>();
            this.ContactMethod = new HashSet<ContactMethod>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Keyword> Children { get; set; }
        public virtual Keyword Parent { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<ContactMethod> ContactMethod { get; set; }
    }
}