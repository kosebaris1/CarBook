using Application.Features.Mediator.Commands.LocationCommand;
using Application.Features.Mediator.Commands.PricingCommand;
using Application.Features.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPricing()
        {
            var result = await _mediator.Send(new GetPricingQuery());
            if (result is null || !result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricingById(int id)
        {
            var result = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("fiyat bilgisi başarıyla eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("fiyat bilgisi başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("fiyat bilgisi başarıyla silindi");
        }
    }
}
