using Application.Features.Mediator.Queries.PricingQueries;
using Application.Features.Mediator.Results.PricingResults;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.PricingHandlers.Read
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;
        private readonly IMapper _mapper;
        public GetPricingQueryHandler(IRepository<Pricing> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<GetPricingQueryResult>>(result);
        }
    }
}
