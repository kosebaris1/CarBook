using Application.Features.Mediator.Commands.TagCloudCommand;
using Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllTagCloud")]
        public async Task<IActionResult> GetAllTagCloud()
        {
            var result = await _mediator.Send(new GetTagCloudQuery());
            return Ok(result);
        }

        [HttpGet("GetTagCloudById/{id}")]
        public async Task<IActionResult> GetTagCloudById(int id)
        {
            var result = await _mediator.Send(new GetTagCloudByIdQuery(id));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid data.");
           }

            await _mediator.Send(command);
            return Ok("Etiket başarıyla oluşturuldu");
        
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid data.");
            }

            await _mediator.Send(command);
            return Ok("Etiket başarıyla Güncellendi");

        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(RemoveTagCloudCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid data.");
            }

            await _mediator.Send(command);
            return Ok("Etiket başarıyla Silindi");

        }
    }
}
