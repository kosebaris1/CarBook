using Application.Features.Mediator.Commands.BlogCommand;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers.Write
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;
        public RemoveBlogCommandHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repository.GetByIdAsync(request.Id);
                await _repository.RemoveAsync(result);
            }catch(Exception ex)
            {
                Console.WriteLine($"Error in RemoveBlogCommand Handler: {ex.Message}");
                throw;
            }
        }
    }
}
