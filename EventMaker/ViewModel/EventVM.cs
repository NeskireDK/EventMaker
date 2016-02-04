using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EventMaker.Annotations;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    public class EventVM : INotifyPropertyChanged
    {
        private EventCatalogSingleton _catalogSingleton = Model.EventCatalogSingleton.Instance;
        private TimeSpan _time;
        private DateTimeOffset _date;
        private string _place;
        private string _description;
        private string _name;
        private int _id;

        public EventCatalogSingleton CatalogSingleton
        {
            get { return _catalogSingleton; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged();}
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        public string Place
        {
            get { return _place; }
            set { _place = value; OnPropertyChanged(); }
        }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; OnPropertyChanged(); }
        }
        // Constructor 

        public EventVM()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}