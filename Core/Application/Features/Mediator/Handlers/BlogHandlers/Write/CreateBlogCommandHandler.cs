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
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;
        public CreateBlogCommandHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _mapper.Map<Blog>(request);
                await _repository.CreateAsync(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateBlogCommand Handler: {ex.Message}");
                throw;
            }
        }
    }
}
