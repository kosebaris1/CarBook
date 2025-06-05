using Application.Features.CQRS.Queries;
using Application.Features.CQRS.Results.BannerResults;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.BannerHandlers.Read
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values=await _repository.GetByIdAsync(query.Id);
            return _mapper.Map<GetBannerByIdQueryResult>(values);
        }
    }
}
