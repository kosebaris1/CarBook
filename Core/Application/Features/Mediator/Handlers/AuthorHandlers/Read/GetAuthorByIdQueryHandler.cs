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

namespace Application.Features.Mediator.Handlers.AuthorHandlers.Read
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;
        private readonly IMapper _mapper;
        public GetAuthorByIdQueryHandler(IRepository<Author> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repository.GetByIdAsync(request.Id);
                return _mapper.Map<GetAuthorByIdQueryResult>(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in GetAuthorByIdQuery Handler: {ex.Message}");
                throw;
            }
        }
    }
    
    
}
