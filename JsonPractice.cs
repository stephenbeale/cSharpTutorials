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
            string json = File.ReadAllText(@"D:\Software Engineering\Repos");

            Console.WriteLine("Deserialised Data:");
            YouTuber deserialised = JsonConvert.DeserializeObject<YouTuber>(json);

        }
          
    }

    public class YouTuber
    {

    }
}
