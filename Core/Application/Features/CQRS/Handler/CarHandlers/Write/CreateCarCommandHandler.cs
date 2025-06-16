using Application.Features.CQRS.Command.AboutCommand;
using Application.Features.CQRS.Command.CarCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.CarHandlers.Write
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;
        public CreateCarCommandHandler(IRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCarCommand command)
        {
            var result = _mapper.Map<Car>(command);
            await _repository.CreateAsync(result);
        }
    }
}
