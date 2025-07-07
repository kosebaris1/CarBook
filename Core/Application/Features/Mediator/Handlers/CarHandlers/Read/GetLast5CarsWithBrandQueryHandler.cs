using Application.Features.Mediator.Queries.CarQueries;
using Application.Features.Mediator.Results.CarResults;
using Application.Interfaces.CarInterfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetLast5CarsWithBrandQueryHandler : IRequestHandler<GetLast5CarsWithBrandQuery, List<GetLast5CarsWithBrandQueryResult>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<GetLast5CarsWithBrandQueryResult>> Handle(GetLast5CarsWithBrandQuery request, CancellationToken cancellationToken)
        {
            var result = await _carRepository.GetLast5CarsWithBrands();
            return _mapper.Map<List<GetLast5CarsWithBrandQueryResult>>(result);
        }
    }
}
