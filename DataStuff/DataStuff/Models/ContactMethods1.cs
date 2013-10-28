using System;
using System.Collections.Generic;

namespace DataStuff.Models
{
    public partial class ContactMethods1
    {
        public int Id { get; set; }
        public int Contacts_Id { get; set; }
        public int Keywords_Id { get; set; }
        public virtual Contacts1 Contacts1 { get; set; }
        public virtual Keywords1 Keywords1 { get; set; }
    }
}
