using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    class Item:BaseVM
    {
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; OnPropertyChanged("Title"); }
        }
        private bool _Done;
        public bool Done
        {
            get { return _Done; }
            set { _Done = value; OnPropertyChanged("Done"); }
        }
        
    }
}
