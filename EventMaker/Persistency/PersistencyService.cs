using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using EventMaker.Model;
using Newtonsoft.Json;

namespace EventMaker.Persistency
{
    class PersistencyService
    {
        private static string _eventFileName = "default_filename.json";

        public static string eventFileName
        {
            get { return _eventFileName; }
            set { _eventFileName = value; }
        }


        private static async void SerializeEventsFileAsync(string eventString, string filename)
        {
            // SAve til fil
            File.WriteAllText(ApplicationData.Current.RoamingFolder.Path + "/" +filename,eventString);
        }

        public static async void SaveEventAsJsonAsync(ObservableCollection<Event> data)
        {
            // Seraialse til json 
            string json = JsonConvert.SerializeObject(data);
            SerializeEventsFileAsync(json, eventFileName);
        }

        private static async Task<string> DeSerializeEventsFileAsync(string fileName)
        {

            // Hent fil
            string jsonData = File.ReadAllText(ApplicationData.Current.RoamingFolder.Path + "/" + fileName);
            return JsonConvert.DeserializeObject<ObservableCollection<Event>>(jsonData);
        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            // Do stuff

        }
    }
}
