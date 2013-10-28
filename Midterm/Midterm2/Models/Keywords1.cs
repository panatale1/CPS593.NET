using System;
using System.Collections.Generic;

namespace Midterm2.Models
{
    public partial class Keywords1
    {
        public Keywords1()
        {
            this.ContactMethods1 = new List<ContactMethods1>();
            this.Contacts1 = new List<Contacts1>();
            this.Keywords11 = new List<Keywords1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent_Id { get; set; }
        public virtual ICollection<ContactMethods1> ContactMethods1 { get; set; }
        public virtual ICollection<Contacts1> Contacts1 { get; set; }
        public virtual ICollection<Keywords1> Keywords11 { get; set; }
        public virtual Keywords1 Keywords12 { get; set; }
    }
}
