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
        private static string _fileName;

        public static string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public static async void Save(ObservableCollection<Event> data)
        {
            string json = JsonConvert.SerializeObject(data);
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(json, CreationCollisionOption.ReplaceExisting);
        }

        public static async Task<ObservableCollection<Event>> Load()
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(FileName);
            string jsonFile = await FileIO.ReadTextAsync(localFile);
            return JsonConvert.DeserializeObject<ObservableCollection<Event>>(jsonFile);
        }
    }
}

