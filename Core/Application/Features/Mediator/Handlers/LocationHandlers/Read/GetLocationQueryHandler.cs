using Application.Features.Mediator.Queries.LocationQueries;
using Application.Features.Mediator.Results.LocationResults;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.LocationHandlers.Read
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;
        public GetLocationQueryHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<GetLocationQueryResult>>(result);
        }
    }
}
