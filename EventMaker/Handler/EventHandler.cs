using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Converter;
using EventMaker.ViewModel;

namespace EventMaker.Handler
{
    class EventHandler
    {
        public EventVM EventViewModel { get; set; }

        public EventHandler(EventVM eventViewModel)
        {
            EventViewModel = eventViewModel;
        }

        public void CreateEvent()
        {
            EventViewModel.CatalogSingleton.Add(EventViewModel.Id, EventViewModel.Name, EventViewModel.Place, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel.Date, EventViewModel.Time), EventViewModel.Description);
        }
    }
}
