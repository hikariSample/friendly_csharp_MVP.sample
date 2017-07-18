using System.ComponentModel;
using Microsoft.Practices.Prism.Commands;

namespace MVP.Sample.WPF.Models
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public DelegateCommand<object> ClickCommand { get; set; }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        #region INotifyPropertyChanged 成员  

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}