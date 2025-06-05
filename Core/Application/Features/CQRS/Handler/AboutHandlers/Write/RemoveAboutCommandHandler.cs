using Application.Features.CQRS.Command.AboutCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.AboutHandler.Write
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public RemoveAboutCommandHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(RemoveAboutCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(values);
        }
    }
}
