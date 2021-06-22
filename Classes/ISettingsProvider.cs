using Newtonsoft.Json;

namespace SuetaManager.Classes
{
    public interface ISettingsProvider
    {
        JsonSerializerSettings GetSettings();
    }
}