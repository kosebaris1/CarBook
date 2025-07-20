using Application.Features.Mediator.Commands.TagCloudCommand;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.TagCloudHandlers.Write
{
    public class RemoveTagCloudCommandHandler : IRequestHandler<RemoveTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;
        private readonly IMapper _mapper;
        public RemoveTagCloudCommandHandler(IRepository<TagCloud> repository, IMapper mapper = null)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            _mapper.Map(request, values);
            await _repository.RemoveAsync(values);
        }
    }
}
