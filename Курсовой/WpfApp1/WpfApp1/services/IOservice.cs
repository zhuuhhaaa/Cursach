using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace WpfApp1.Services
{
    class IOservice 
    {
        private BindingList<Vehicle> cloth;
        private readonly string PATH;

        public IOservice(string path)
        {
            PATH = path;
        }

        public BindingList<Vehicle> vehicle_Data()
        {        
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<Vehicle>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Vehicle>>(fileText);
            }
        }

        public void SaveData(BindingList<Vehicle> vehicle_Data, object obj)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(vehicle_Data);
                writer.Write(output);
            }

        }
    }
}
