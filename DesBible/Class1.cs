using Newtonsoft.Json;

namespace DesBible
{
    public class Class1
    {
        public static void Ser<T>(T obj, string filename)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(filename, json);
        }

        public static T Des<T>(string filename)
        {
            string json = File.ReadAllText(filename);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

    }
}