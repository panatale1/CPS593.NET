//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.Companies = new HashSet<Company>();
        }
    
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public short State { get; set; }
        public string ZIP { get; set; }
        public string Type { get; set; }
        public string Person { get; set; }
        public string Company { get; set; }
    
        public virtual Person Person1 { get; set; }
        public virtual State State1 { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
