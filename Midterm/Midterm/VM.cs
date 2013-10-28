using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;

namespace Midterm
{
    public class VM : BaseVM
    {
        private string _Text;
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                OnPropertyChanged("Text");
                AddCommand.OnCanExecuteChanged();
            }
        }
        public ObservableCollection<Item> List { get; set; }
        private DelegateCommand _AddCommand;
        public DelegateCommand AddCommand
        {
            get { return _AddCommand; }

        }
        public VM()
        {
            List = new ObservableCollection<Item>();
            _AddCommand = new DelegateCommand(AddItem, () => Text != null && Text.Length > 0);
        }
        public void AddItem()
        {
            this.List.Add(new Item { Title = Text });
            Text = null;
        }
    }

    public class DelegateCommand : ICommand
    {
        private Action _Action;
        private Func<bool> _CanExecute;

        public DelegateCommand(Action action, Func<bool> canExecute = null)
        {
            _Action = action;
            _CanExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if (_CanExecute == null)
            {
                return true;
            }
            else
            {
                return _CanExecute();
            }
        }
        public event EventHandler CanExecuteChanged;
        public void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }
        public void Execute(object parameter)
        {
            _Action();
        }
    }


    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

