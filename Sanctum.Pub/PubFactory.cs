using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sanctum.Pub
{
    public static class PubFactory
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented
        };

        private static JsonSerializer serializer = new JsonSerializer();

        public static void SerializeToFile<T>(T pub, string file)
        {
            using (StreamWriter writer = new StreamWriter(file, false))
                serializer.Serialize(writer, pub);
        }

        public static T DeserializeFromFile<T>(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                JsonTextReader jsonReader = new JsonTextReader(reader);

                return serializer.Deserialize<T>(jsonReader);
            }
        }
    }
}
