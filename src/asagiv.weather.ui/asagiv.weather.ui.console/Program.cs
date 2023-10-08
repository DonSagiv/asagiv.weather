using asagiv.infrastructure.weather.webscraping;

namespace asagiv.ui.weather.console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await WeatherDataScraper.GetWeatherAsync();
        }
    }
}