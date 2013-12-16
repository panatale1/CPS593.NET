using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerForFinal {
    public class Person {
        public Person() {
            this.elist = new ObservableCollection<Email>();
            this.plist = new ObservableCollection<Phone>();
            this.alist = new ObservableCollection<Address>();
        }
        [Key]
        public int PID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Type { get; set; }
        public virtual ObservableCollection<Email> elist { get; set; }
        public virtual ObservableCollection<Phone> plist { get; set; }
        public virtual ObservableCollection<Address> alist { get; set; }
    }
}
