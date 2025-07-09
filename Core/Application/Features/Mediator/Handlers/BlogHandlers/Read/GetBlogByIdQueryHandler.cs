using Application.Features.Mediator.Queries.BlogQueries;
using Application.Features.Mediator.Results.AuthorResults;
using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;
        public GetBlogByIdQueryHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repository.GetByIdAsync(request.Id);
                return _mapper.Map<GetBlogByIdQueryResult>(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in GetBlogByIdQuery Handler: {ex.Message}");
                throw;
            }
        }
    }
}
