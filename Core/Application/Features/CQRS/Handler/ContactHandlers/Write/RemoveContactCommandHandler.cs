using Application.Features.CQRS.Command.ContactCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.ContactHandlers.Write
{
    public class RemoveContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public RemoveContactCommandHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(RemoveContactCommand command)
        {
            var result = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(result);
        }
    }
}
