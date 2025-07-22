using Application.Features.Mediator.Commands.AuthorCommand;
using Application.Features.Mediator.Commands.BlogCommand;
using Application.Features.Mediator.Queries.AuthorQueries;
using Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBlog()
        {
            var result = await _mediator.Send(new GetBlogQuery());
            if (result is null || !result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet,Route("GetLast3BlogsWithAuthor")]
        public async Task<IActionResult> GetLast3BlogsWithAuthor()
        {
            var result = await _mediator.Send(new GetLast3BlogsWithAuthorQuery());
            if (result is null || !result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("GetAllBlogsWithAuthor")]
        public async Task<IActionResult> GetAllBlogsWithAuthor()
        {
            var result = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
            if (result is null || !result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var result = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
           
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var result = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog bilgisi başarıyla eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog bilgisi başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog bilgisi başarıyla silindi");
        }
    }
}
