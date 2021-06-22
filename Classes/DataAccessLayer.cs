using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuetaManager.Classes;
using Newtonsoft.Json;

namespace SuetaManager
{
    class DataAccessLayer
    {
        public UserManager UserManager { get; }
        private string filePath = "Data.json";
        ISettingsProvider settingsProvider = new StandartJsonSettingsProvider();
        public DataAccessLayer()
        {
            if (File.Exists(filePath))
            {
                JsonSerializerSettings serializerSettings = settingsProvider.GetSettings();
                ISerializer<UserManager> serializer = new UserManagerSerializer();
                UserManager = serializer.Deserialize(filePath, serializerSettings); 
            }
            else
            {
                UserManager = new UserManager();
                UserManager.AddDefault();
            }
        }
        public void SaveData()
        {
            JsonSerializerSettings serializerSettings = settingsProvider.GetSettings();
            ISerializer<UserManager> serializer = new UserManagerSerializer();
            ISerializer<List<Schedule>> serializer1 = new ScheduleSerializer();
            serializer.Serialize(UserManager, filePath, serializerSettings);
            serializer1.Serialize(UserManager.CurrentUser.GetSchedules().ToList(), "ScheduleBackUp.json", serializerSettings);
        }
    }
}
