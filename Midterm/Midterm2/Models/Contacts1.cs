using System;
using System.Collections.Generic;

namespace Midterm2.Models
{
    public partial class Contacts1
    {
        public Contacts1()
        {
            this.ContactMethods1 = new List<ContactMethods1>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Keyword_Id { get; set; }
        public virtual ICollection<ContactMethods1> ContactMethods1 { get; set; }
        public virtual Keywords1 Keywords1 { get; set; }
    }
}
