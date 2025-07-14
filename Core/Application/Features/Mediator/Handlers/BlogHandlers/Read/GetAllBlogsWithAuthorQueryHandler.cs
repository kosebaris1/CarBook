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
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;
        private readonly IMapper _mapper;
        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository, IMapper mapper = null)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllBlogsWithAuthor();
            return _mapper.Map<List<GetAllBlogsWithAuthorQueryResult>>(result);
        }
    }
}
