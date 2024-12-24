using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SolutionName.API.Controllers.BaseController
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseController<T> : ControllerBase
    {
        protected readonly IMediator Mediator;

        protected BaseController(IMediator mediator)
        {
            Mediator = mediator;
        }

        // Métodos CRUD comunes, si aplica
        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            // Aquí podrías manejar consultas genéricas como "GetAll<T>"
            return Ok($"This is a generic GetAll for {typeof(T).Name}");
        }
    }
}
