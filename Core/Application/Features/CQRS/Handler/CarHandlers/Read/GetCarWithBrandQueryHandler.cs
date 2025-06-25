using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces;
using Application.Interfaces.CarInterfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.CarHandlers.Read
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;
        private readonly IMapper _mapper;

        public GetCarWithBrandQueryHandler(IMapper mapper, ICarRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var result = await _repository.GetCarsListWithBrands();
            return _mapper.Map<List<GetCarWithBrandQueryResult>>(result);
        }
    }
}
