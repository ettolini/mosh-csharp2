using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary; // Dictionary <key type, value type>

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]  // Indexers are defined as methods, but they don't have a name, we use the This Keyword to identify them
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            System.Console.WriteLine(cookie["name"]);   // Returns "Mosh"
        }
    }
}