using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace asagiv.infrastructure.weather.webscraping
{
    public class WeatherDataScraper
    {
        private static readonly string temperatureElementXPath = "/html/body/app-root/app-today/one-column-layout/wu-header/sidenav/mat-sidenav-container/mat-sidenav-content/div/section/div[3]/div[1]/div/div[1]/div[1]/lib-city-current-conditions/div/div[2]/div/div/div[2]/lib-display-unit/span/span[1]";
        private static readonly string weatherConditionElementPath = "/html/body/app-root/app-today/one-column-layout/wu-header/sidenav/mat-sidenav-container/mat-sidenav-content/div/section/div[3]/div[1]/div/div[1]/div[1]/lib-city-current-conditions/div/div[3]/div/div[1]/p";

        public static async Task GetWeatherAsync()
        {
            var url = "https://www.wunderground.com/weather/us/ny/merrick/11566";

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--no-sandbox");
            var driver = new RemoteWebDriver(new Uri("http://localhost:3000/webdriver"), chromeOptions);
            driver.Navigate().GoToUrl(url);
        }
    }
}