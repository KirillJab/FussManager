using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class UserManagerSerializer:ISerializer<UserManager>
    {
        public void Serialize(UserManager obj, string filePath, JsonSerializerSettings settings)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(obj, Formatting.Indented, settings));
        }
        public UserManager Deserialize(string filePath, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject<UserManager>(File.ReadAllText(filePath), settings);
        }
    }
}
