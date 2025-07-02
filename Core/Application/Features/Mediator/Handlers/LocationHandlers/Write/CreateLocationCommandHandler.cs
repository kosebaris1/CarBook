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
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;
        public CreateLocationCommandHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var result= _mapper.Map<Location>(request);
            await _repository.CreateAsync(result);
        }
    }
}
