using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerForFinal {
    public class Person {
        [Key]
        public int PID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
