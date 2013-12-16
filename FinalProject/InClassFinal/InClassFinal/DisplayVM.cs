using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net.Http;
using System.Text.RegularExpressions;



namespace InClassFinal {
    public class DisplayVM : BaseVM {
        public ObservableCollection<string> SuggestionList { get; private set; }
        private string _Suggestion;

        public string Suggestion {
            get { return _Suggestion; }
            set { _Suggestion = value; OnPropertyChanged(); GetSuggestions(); }
        }
        private string PrevSug = "";
        public DisplayVM() {
            SuggestionList = new ObservableCollection<string>();
            GetSuggestions();
        }
        async void GetSuggestions() {
            if (Suggestion == null) return;
            if (Suggestion == PrevSug) return;
            var client = new HttpClient {
                BaseAddress = new Uri("http://cs.newpaltz.edu/~plotkinm/2012Grad/Final/api/Cities.php"),
                DefaultRequestHeaders = { { "accept", "application/json" } }
            };
            SuggestionList = new ObservableCollection<string>();
            try {
               var response = await client.GetAsync("?term=" + Suggestion);
               var setup = await response.Content.ReadAsStringAsync();
               var set = Regex.Split(setup, "\"");
               foreach (var sug in set) {
                   if (sug != "," && sug != "[" && sug != "]") {
                       SuggestionList.Add(sug);
                   }
               }
               PrevSug = Suggestion;
                
            }
            catch (Exception) { }
            
            
        }


    }
    public class BaseVM : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class DelegateCommand : ICommand {
        private Action _Action;
        private Func<bool> _CanExecute;
        public DelegateCommand(Action action, Func<bool> canExecute = null) {
            _Action = action;
            _CanExecute = canExecute;
        }
        public bool CanExecute(object parameter) {
            if (_CanExecute == null)
                return true;
            else
                return _CanExecute();
        }
        public event EventHandler CanExecuteChanged;
        public void OnCanExecuteChanged() {
            if (CanExecuteChanged != null) {
                CanExecuteChanged(this, new EventArgs());
            }
        }
        public void Execute(object parameter) {
            _Action();
        }
    }
}
