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
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        private readonly IMapper _mapper;
        public UpdateAuthorCommandHandler(IRepository<Author> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            
               
                try
                {
                var value = await _repository.GetByIdAsync(request.AuthorId);
                _mapper.Map(request, value);
                    await _repository.UpdateAsync(value);
                }catch(Exception ex)
                {
                    Console.WriteLine($"Error in UpdateAuthorCommand Handler: {ex.Message}");
                    throw;
                }
            
            
        }
    }
}
