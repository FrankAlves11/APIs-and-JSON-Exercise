using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void ConvoAsync()
        {

            HttpClient client = new HttpClient();
      
            for (int i = 0; i < 10; i++)
            {
            

                string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JArray.Parse(ronResponse);

                string kayneURL = "https://api.kanye.rest";
                var kanyeResponse = client.GetStringAsync(kayneURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse);

                Console.WriteLine($"Ron: {ronQuote}");
                Console.WriteLine();
                Console.WriteLine($"Kanye: {kanyeQuote}");


            }

        }
    }
}
