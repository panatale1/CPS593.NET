//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public Contact()
        {
            this.PhoneNumbers = new HashSet<PhoneNumber>();
        }
    
        public int Id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
