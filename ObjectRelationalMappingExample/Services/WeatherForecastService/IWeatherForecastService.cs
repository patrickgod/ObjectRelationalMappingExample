namespace ObjectRelationalMappingExample.Services.WeatherForecastService
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
