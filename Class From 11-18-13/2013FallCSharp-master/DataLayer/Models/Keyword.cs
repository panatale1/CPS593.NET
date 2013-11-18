using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public partial class Keyword
    {
        public Keyword()
        {
            this.ContactMethods = new ObservableCollection<ContactMethod>();
            this.Contacts = new ObservableCollection<Contact>();
            this.Children = new ObservableCollection<Keyword>();
        }


        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public virtual ICollection<ContactMethod> ContactMethods { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        
        [ForeignKey("ParentId")]
        public virtual ICollection<Keyword> Children { get; set; }

        
        public virtual Keyword Parent { get; set; }
    }
}
