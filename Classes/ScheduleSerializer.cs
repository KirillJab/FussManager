using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace SuetaManager.Classes
{
    class ScheduleSerializer : ISerializer<List<Schedule>>
    {
        public void Serialize(List<Schedule> obj, string filePath, JsonSerializerSettings settings)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(obj, Formatting.Indented, settings));
        }
        public List<Schedule> Deserialize(string filePath, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject<List<Schedule>>(filePath, settings); 
        }

    }
}
