using Application.Features.Mediator.Commands.FeatureCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FeatureHandlers.Write
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;
        private readonly IMapper _mapper;
        public UpdateFeatureCommandHandler(IRepository<Feature> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.FeatureId);
            if (result == null)
            {
                throw new KeyNotFoundException($"Feature with ID {request.FeatureId} not found.");
            }
            _mapper.Map(request, result);
            await _repository.UpdateAsync(result);
        }
    }
}
