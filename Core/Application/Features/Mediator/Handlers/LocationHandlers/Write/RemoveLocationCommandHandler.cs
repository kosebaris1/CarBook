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
    public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mappere;
        public RemoveLocationCommandHandler(IRepository<Location> repository, IMapper mappere)
        {
            _repository = repository;
            _mappere = mappere;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
           var result = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(result);
        }
    }
}
