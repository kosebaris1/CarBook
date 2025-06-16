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
        

        public RemoveAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAboutCommand command)
        {
            var result = await _repository.GetByIdAsync(command.Id);
            if(result != null)
            await _repository.RemoveAsync(result);
        }
    }
}
