using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class ContactMethod
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ContactId { get; set; }
        public int KeywordId { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
