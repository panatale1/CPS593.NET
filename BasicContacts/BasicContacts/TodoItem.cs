using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BasicContacts
{
    public class TodoItem : BaseVM
    {
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set {_Title = value; OnPropertyChanged("Title");}
        }

            
    private Boolean _Done;
	public Boolean Done
	{
		get { return _Done;}
		set { _Done = value;}
	}
	
    private DateTime _DueDate;

	public DateTime DueDate
	{
		get { return _DueDate;}
		set { _DueDate = value; OnPropertyChanged("DueDate");}
	}

    }	
}
