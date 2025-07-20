using Application.Features.Mediator.Queries.TagCloudQueries;
using Application.Features.Mediator.Results.TagCloudResults;
using Application.Interfaces.TagCloudInterfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;
        private readonly IMapper _mapper;
        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository, IMapper mapper)
        {
            _tagCloudRepository = tagCloudRepository;
            _mapper = mapper;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _tagCloudRepository.GetTagCloudByBlogId(request.Id);
            return _mapper.Map<List<GetTagCloudByBlogIdQueryResult>>(result);
        }
    }
}
