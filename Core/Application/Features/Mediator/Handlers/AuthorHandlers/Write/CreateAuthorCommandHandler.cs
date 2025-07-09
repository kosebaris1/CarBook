using Application.Features.Mediator.Commands.AuthorCommand;
using Application.Features.Mediator.Queries.AuthorQueries;
using Application.Features.Mediator.Results.AuthorResults;
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
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        private readonly IMapper _mapper;
        public CreateAuthorCommandHandler(IRepository<Author> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var value= _mapper.Map<Author>(request);
                await _repository.CreateAsync(value);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in CreateAuthorCommand Handler: {ex.Message}");
                throw;
            }
        }
    }
}
