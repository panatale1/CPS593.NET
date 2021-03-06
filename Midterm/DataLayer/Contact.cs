//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public Contact()
        {
            this.Addresses = new HashSet<Address>();
            this.ContactMethods = new HashSet<ContactMethod>();
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
