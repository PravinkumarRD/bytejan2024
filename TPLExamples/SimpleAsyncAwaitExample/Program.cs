using System.Threading.Channels;

namespace SimpleAsyncAwaitExample
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetTravelCountryAsync().Result);
        //    Console.WriteLine(GetTravelStateAsync().Result);
        //    Console.WriteLine(GetTravelCityAsync().Result);
        //    Console.WriteLine(GetVisitingCompanyAsync().Result);
        //}
        static async Task Main(string[] args)
        {
            string country = await GetTravelCountryAsync();
            string state = await GetTravelStateAsync();
            string city = await GetTravelCityAsync();
            string company = await GetVisitingCompanyAsync();
            await Console.Out.WriteLineAsync($"{country} - {state} - {city} - {company}");
        }
        private static async Task<string> GetTravelCountryAsync()
        {
            await Task.Delay(4000);
            return "I am Travelling to India!";
        }
        private static async Task<string> GetTravelStateAsync()
        {
            await Task.Delay(3000);
            return "I am Travelling to Maharashtra!";
        }
        private static async Task<string> GetTravelCityAsync()
        {
            await Task.Delay(1000);
            return "I am Travelling to Pune!";
        }
        private static async Task<string> GetVisitingCompanyAsync()
        {
            await Task.Delay(2000);
            return "I am visiting Baja Ltd.!";
        }
    }
}
