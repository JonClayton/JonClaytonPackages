using Newtonsoft.Json;

namespace JonClayton.Packages.HelloWorld
{
    public class Communication
    {
        public static string Greet(string name)
        {
            var obj = new { greetings = name };
            return JsonConvert.SerializeObject(obj);
        }
    }
}