using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cSharpTutorials
{
    public class JsonPractice
    {
        public JsonPractice() { }

        public void DeserialiseJson() {
            //File path
            //string json = File.ReadAllText(@"C:\Users\s.j.beale\Downloads");
            string json = @"{
                'Name': 'Jose Luis', 
                'Channel': 'ParametricCamp',
                'Active': true,
                'Age': 3,
                'Members': [
                    'Richard',
                    'Tim',
                    'Victor',
                    'Chandra',
                    'Andres',
                    'Nicholas'
                ]
            }";

            Console.WriteLine($"Read file from: {json}");
            Console.WriteLine("Deserialised Data:");
            YouTuber deserialised = JsonConvert.DeserializeObject<YouTuber>(json);
            Console.WriteLine(deserialised.Name);
            Console.WriteLine(deserialised.Channel);
            Console.WriteLine(deserialised.Active);
            Console.WriteLine(deserialised.Age);
            foreach (var member in deserialised.Members)
            {
                Console.WriteLine($"Member: {member}");
            }

            Console.WriteLine("");
            Console.WriteLine("Serialised Data:");
            string serialised = JsonConvert.SerializeObject(deserialised);
            Console.WriteLine(serialised);

            Console.ReadKey();
        }
    }

    public class YouTuber
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public bool Active { get; set; }
        public int Age { get; set; }
        public List<string> Members { get; set; }
    }
}
