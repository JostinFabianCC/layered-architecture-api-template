using MediatR;
using SolutionName.Application.DTOs.WeatherForecast;
using SolutionName.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Application.Features.WeatherForecast.Queries.GetWeatherForecast
{
    public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastQuery, IEnumerable<WeatherForecastResponse>>
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public GetWeatherForecastHandler(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService ?? throw new ArgumentNullException(nameof(weatherForecastService), "Weather forecast service cannot be null.");
        }

        public async Task<IEnumerable<WeatherForecastResponse>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var forecasts = await _weatherForecastService.GetWeatherForecastAsync();
            return forecasts;
        }
    }
}
