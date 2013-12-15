using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerForFinal {
    public class Email {
        [Key]
        public int EID { get; set; }
        public string EmailAddress { get; set; }
        public int Type { get; set; }
        public int PersonID { get; set; }
    }
}
