using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace D_D_Character_Creator.Helpers
{
    public static class Helpers
    {
        public static bool HasProperty(dynamic item, string propertyName)
        {
            if (item is JObject)
            {
                return item.ContainsKey(propertyName);
                
            }
            else if (item is JProperty)
            {
                return item.HasValue;
            }
            else
            {
                return false;
            }
        }
    }
}
