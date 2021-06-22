using Newtonsoft.Json;

namespace SuetaManager.Classes
{
    interface ISerializer<T>
    {
        void Serialize(T obj, string filePath, JsonSerializerSettings settings);
        T Deserialize(string filePath, JsonSerializerSettings settings);
    }
}
