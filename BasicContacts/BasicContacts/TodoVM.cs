using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BasicContacts
{
    public class TodoVM:BaseVM{
    
        public TodoVM(){
            List = new ObservableCollection<TodoItem>();
            _AddCommand = new DelagateCommand(AddTodo, () => Text != null && _Text.Length > 0);
        }
         private string _Text;

        public string Text
        {
            get { return _Text; }
            set { 
                _Text = value;
                OnPropertyChanged("Text");
                AddCommand.OnCanExecuteChanged();
            }
        }
        public ObservableCollection<TodoItem> List { get; set; }

        private DelagateCommand _AddCommand;

        public DelagateCommand AddCommand
        {
            get { return _AddCommand; }
        }
        

        public void AddTodo()
        {
            List.Add(new TodoItem());
            Text = null;

        }

       // public event PropertyChangedEventHandler PropertyChanged;
    }
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DelagateCommand : ICommand
    {
        private Action _Action;
        private Func<bool> _CanExecute;
        public DelagateCommand(Action action, Func<bool> canExecute = null)
        {
            _Action = action;
            _CanExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if (_CanExecute == null)
                return true;
            return _CanExecute();
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
}
