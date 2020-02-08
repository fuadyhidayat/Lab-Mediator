using System;

namespace Mediator.Application.WeatherForecasts.Queries.GetWeatherForecasts
{
    public class WeatherForecastDTO
    {
        public DateTime Date { get; set; }
        public int TemperatureInCelcius { get; set; }
        public int TemperatureInFahrenheit => 32 + (int)(TemperatureInCelcius / 0.5556);
        public string Summary { get; set; }
    }
}