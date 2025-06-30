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
    public class RemoveFooterAdressCommandHandler : IRequestHandler<RemoveFooterAdressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        private readonly IMapper _mapper;

        public RemoveFooterAdressCommandHandler(IMapper mapper, IRepository<FooterAddress> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
        {
           var result = await _repository.GetByIdAsync(request.Id);
            if (result == null)
            {
                throw new Exception("Footer address not found");
            }
            await _repository.RemoveAsync(result);
        }
    }
}
