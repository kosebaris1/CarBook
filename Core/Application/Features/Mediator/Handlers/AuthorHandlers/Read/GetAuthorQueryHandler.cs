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
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        private readonly IMapper _mapper;
        public GetAuthorQueryHandler(IRepository<Author> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repository.GetAllAsync();
                return _mapper.Map<List<GetAuthorQueryResult>>(result);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in GetAuthorQuery Handler: {ex.Message}");
                throw;
            }
        }
    }
}
