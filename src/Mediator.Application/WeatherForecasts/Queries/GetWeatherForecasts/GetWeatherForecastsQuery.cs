using Mediator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Application.WeatherForecasts.Queries.GetWeatherForecasts
{
    public static class GetWeatherForecastsQuery
    {
        public static Task<IEnumerable<WeatherForecastDTO>> Handle()
        {
            Random randomTemperature = new Random();
            Array values = Enum.GetValues(typeof(WeatherSummary));
            WeatherSummary randomWeatherSummary = (WeatherSummary)values.GetValue(randomTemperature.Next(values.Length));

            IEnumerable<WeatherForecastDTO> weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecastDTO
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureInCelcius = randomTemperature.Next(-20, 55),
                Summary = randomWeatherSummary.ToString()
            });

            return Task.FromResult(weatherForecasts);
        }
    }
}