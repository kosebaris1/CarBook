using Application.Features.Mediator.Commands.FooterAdressCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FooterAdressHandlers.Write
{
    public class CreateFooterAdressCommandHandler : IRequestHandler<CreateFooterAdressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        private readonly IMapper _mapper;

        public CreateFooterAdressCommandHandler(IMapper mapper, IRepository<FooterAddress> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(CreateFooterAdressCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<FooterAddress>(request);
            await _repository.CreateAsync(result);
        }
    }
}
