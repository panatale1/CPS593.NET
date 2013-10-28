using System;
using System.Collections.Generic;

namespace Midterm2.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
