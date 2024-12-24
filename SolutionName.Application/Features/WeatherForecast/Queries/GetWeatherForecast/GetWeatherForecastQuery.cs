using MediatR;
using SolutionName.Application.DTOs.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Application.Features.WeatherForecast.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQuery : IRequest<IEnumerable<WeatherForecastResponse>>
    {
    }
}
