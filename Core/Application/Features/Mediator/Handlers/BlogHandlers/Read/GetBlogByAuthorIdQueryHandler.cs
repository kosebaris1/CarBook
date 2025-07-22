using Application.Features.Mediator.Queries.BlogQueries;
using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces.BlogInterfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery,GetBlogByAuthorIdQueryResult>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetBlogByAuthorIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<GetBlogByAuthorIdQueryResult> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var result= await _blogRepository.GetBlogsByAuthorId(request.Id);
            return _mapper.Map<GetBlogByAuthorIdQueryResult>(result.FirstOrDefault());
        }
    }
    
    
}
