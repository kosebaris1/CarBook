using Application.Features.CQRS.Queries;
using Application.Features.CQRS.Queries.CarQueries;
using Application.Features.CQRS.Results.AboutResults;
using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.CarHandlers.Read
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;
    public GetCarByIdQueryHandler(IRepository<Car> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery result)
    {
            var values= await _repository.GetByIdAsync(result.Id);
            return _mapper.Map<GetCarByIdQueryResult>(values);

    }


    }
}
