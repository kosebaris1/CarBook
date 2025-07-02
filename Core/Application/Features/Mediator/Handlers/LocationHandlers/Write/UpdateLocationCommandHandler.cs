using Application.Features.Mediator.Commands.LocationCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.LocationHandlers.Write
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;
        public UpdateLocationCommandHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.LocationId);
            _mapper.Map(request, result);
            await _repository.UpdateAsync(result);
        }
    }
}
