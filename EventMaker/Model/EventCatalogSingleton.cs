using System;
using System.Collections.ObjectModel;

namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        private EventCatalogSingleton _instance;
        private ObservableCollection<Event> _observableCollection;

        public EventCatalogSingleton()
        {
            Add(new Event(DateTime.Now, 1, "Beskrivelse", "Navn", "Sted"));
        }



        public EventCatalogSingleton Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new EventCatalogSingleton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Event> ObservableCollection
        {
            get { return _observableCollection; }
            set { _observableCollection = value; }
        }

        public void Add(Event newEvent)
        {
            ObservableCollection.Add(newEvent);
        }

        public void LoadEventsAsync()
        {
            // DO SOMETHING
        }
        public void Remove(Event eventToBeRemoved)
        {
            ObservableCollection.Remove(eventToBeRemoved);
        }


    }
}