using System.Collections.Generic;
using VueTmp.Models;

namespace VueTmp.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
