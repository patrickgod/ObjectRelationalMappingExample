using ObjectRelationalMappingExample.Data;

namespace ObjectRelationalMappingExample.Services.WeatherForecastService
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly DataContext _context;

        public WeatherForecastService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            return _context.Forecasts.ToArray();
        }
    }
}
