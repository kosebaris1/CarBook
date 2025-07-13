using Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet,Route("GetPricingWithCars")]
        public async Task<IActionResult> GetPricingWithCars()
        {
            var values= await _mediator.Send(new GetCarPricingWithCarsQuery());
            return Ok(values);
        }
    }
}
