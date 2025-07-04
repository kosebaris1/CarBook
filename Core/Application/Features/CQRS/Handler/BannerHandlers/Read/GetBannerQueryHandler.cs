﻿using Application.Features.CQRS.Results.AboutResults;
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
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public GetBannerQueryHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values =await _repository.GetAllAsync();
            return _mapper.Map<List<GetBannerQueryResult>>(values);
        }
    }
}
