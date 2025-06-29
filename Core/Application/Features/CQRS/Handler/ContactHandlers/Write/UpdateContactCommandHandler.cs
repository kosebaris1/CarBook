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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var result = await _repository.GetByIdAsync(command.ContactId);
            if (result == null)
            {
                throw new KeyNotFoundException($"Category with ID {command.ContactId} not found.");
            }
            _mapper.Map(command, result);
            await _repository.UpdateAsync(result);
        }
    }
}
