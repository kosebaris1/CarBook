using Application.Features.CQRS.Queries;
using Application.Features.CQRS.Results.AboutResults;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.AboutHandler.Read
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public GetAboutByIdQueryHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery result)
        {
            var values = await _repository.GetByIdAsync(result.Id);
            return _mapper.Map<GetAboutByIdQueryResult>(values);
        }


    }
}
