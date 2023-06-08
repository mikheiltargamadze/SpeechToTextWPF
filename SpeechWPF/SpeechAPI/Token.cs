using System.IO;
using System.Reflection;

namespace SpeechWPF.SpeechAPI
{
    public class Token
    {
        public static void Write(object obj)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = Path.Combine(path, "token.txt");
            File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(obj));
        }
        public static T Read<T>()
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = Path.Combine(path, "token.txt");
            var token = File.ReadAllText(path);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(token);
        }
    }
}
