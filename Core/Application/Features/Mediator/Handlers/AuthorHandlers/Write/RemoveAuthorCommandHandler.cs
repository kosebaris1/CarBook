using Application.Features.Mediator.Commands.AuthorCommand;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandlers.Write
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        private readonly IMapper _mapper;
        public RemoveAuthorCommandHandler(IRepository<Author> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var value = await _repository.GetByIdAsync(request.Id);
                await _repository.RemoveAsync(value);
            }
            catch(Exception ex) {
                Console.WriteLine($"Error in RemoveAuthorCommand Handler: {ex.Message}");
                throw;
            }
    }
}
