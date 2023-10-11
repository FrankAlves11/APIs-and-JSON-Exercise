namespace APIsAndJSON
{
    public class Program
    {
        public static string apiKey { get; private set; } = "cd9eb6488063f94d90868db1f0a0b1cb";
        public static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            Console.WriteLine();
            Console.WriteLine();
            var fetchWeather = new OpenWeatherMapAPI(client, apiKey);
            Console.WriteLine("Please enter the name of the city you wish to display the weather for:");
            var userInput = Console.ReadLine();

            RonVSKanyeAPI.ConvoAsync();

            try
            {
                var temperature = await fetchWeather.GetTemperatureAsync(userInput, apiKey);
                Console.WriteLine($"The current temperature in {userInput} is {temperature} degrees Fahrenheit.");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        
        
        
    }
}
