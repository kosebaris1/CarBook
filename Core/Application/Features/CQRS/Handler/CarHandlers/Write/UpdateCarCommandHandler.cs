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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;

        public UpdateCarCommandHandler(IRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    public async Task Handle(UpdateCarCommand command)
    {
        var result= await _repository.GetByIdAsync(command.CarId);
        _mapper.Map(command,result);

        await _repository.UpdateAsync(result);
    }
    }
}
