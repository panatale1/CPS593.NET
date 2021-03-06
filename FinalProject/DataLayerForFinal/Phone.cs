﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerForFinal {
    public class Phone {
        [Key]
        public int PhID { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public int PersonID { get; set; }
        public virtual Person person { get; set; }
    }
}
