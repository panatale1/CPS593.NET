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
    
    public partial class Employment
    {
        public Employment()
        {
            this.People = new HashSet<Person>();
            this.Companies = new HashSet<Company>();
        }
    
        public int Id { get; set; }
        public short Person { get; set; }
        public short Company { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
