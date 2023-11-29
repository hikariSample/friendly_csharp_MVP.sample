namespace MVP.Sample.WPF.Models
{
    public class PersonViewModel : NotificationObject
    {
        public DelegateCommand<object> ClickCommand { get; set; }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; NotifyPropertyChanged("Id"); }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }

    }
}