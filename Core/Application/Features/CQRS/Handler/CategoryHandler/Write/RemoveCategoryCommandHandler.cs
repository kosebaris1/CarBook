using Application.Features.CQRS.Command.CategoryCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.CategoryHandler.Write
{
    public class RemoveCategoryCommandHandler
    {

        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public RemoveCategoryCommandHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(RemoveCategoryCommand command)
        {
            var result = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(result);
        }
    }
}
