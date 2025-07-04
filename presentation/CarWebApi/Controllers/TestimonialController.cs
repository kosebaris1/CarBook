using Application.Features.Mediator.Commands.TestimonialCommand;
using Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly IMediator _mediator;

		public TestimonialController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetTestimonials()
		{
			var result = await _mediator.Send(new GetTestimonialQuery());
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetTestimonialById(int id)
		{
			var result = await _mediator.Send(new GetTestimonialByIdQuery(id));
			if (result == null)
			{
				return NotFound();
			}
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
		{
			await _mediator.Send(command);
			return Ok("Testimonial oluşturuldu");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
		{
			await _mediator.Send(command);
			return Ok("Testimonial güncellendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTestimonial(int id)
		{
			await _mediator.Send(new RemoveTestimonialCommand(id));
			return Ok("Testimonial silindi");
		}
	}
}
