using System;
using System.Collections.ObjectModel;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;
        private ObservableCollection<Event> _observableCollection;

        public EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();
            Add(new Event(DateTime.Now, 1, "Beskrivelse", "Navn", "Sted"));
            Add(new Event(DateTime.Now, 2, "Beskrivelse 2", "Navn 2", "Sted 2"));
        }



        public static EventCatalogSingleton Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new EventCatalogSingleton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Event> Events
        {
            get { return _observableCollection; }
            set { _observableCollection = value; }
        }

        public void Add(Event newEvent)
        {
            Events.Add(newEvent);
            Persistency.PersistencyService.Save(Events);
        }

        public void Add(int id, string name, string place, DateTime dateTime, string description)
        {
            Events.Add(new Event(dateTime, id, description, name, place));
            Persistency.PersistencyService.Save(Events);
        }

        public async void LoadEventsAsync()
        {
            Events = await Persistency.PersistencyService.Load();
        }
        public void Remove(Event eventToBeRemoved)
        {
            Events.Remove(eventToBeRemoved);
        }


    }
}