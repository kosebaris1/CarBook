using Application.Features.CQRS.Command.BannerCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.BannerHandlers.Write
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public CreateBannerCommandHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            var values = _mapper.Map<Banner>(command);
            await _repository.CreateAsync(values);
        }
    }
}
