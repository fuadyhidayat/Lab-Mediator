using Mediator.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mediator.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<IEnumerable<WeatherForecastDTO>> Get()
        {
            _logger.LogTrace("LogTrace Get IEnumerable<WeatherForecast>");
            _logger.LogDebug("LogDebug Get IEnumerable<WeatherForecast>");
            _logger.LogInformation("LogInformation Get IEnumerable<WeatherForecast>");
            _logger.LogWarning("LogWarning Get IEnumerable<WeatherForecast>");
            _logger.LogError("LogError Get IEnumerable<WeatherForecast>");
            _logger.LogCritical("LogCritical Get IEnumerable<WeatherForecast>");

            return GetWeatherForecastsQuery.Handle();
        }
    }
}