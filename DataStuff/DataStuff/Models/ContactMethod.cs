using System;
using System.Collections.Generic;

namespace DataStuff.Models
{
    public partial class ContactMethod
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ContactsId { get; set; }
        public int KeywordId { get; set; }
        public Nullable<int> Contact_Id { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
