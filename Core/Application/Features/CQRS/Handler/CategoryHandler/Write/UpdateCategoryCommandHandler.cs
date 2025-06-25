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
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var category = await _repository.GetByIdAsync(command.CategoryId);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {command.CategoryId} not found.");
            }

            _mapper.Map(command, category);
            await _repository.UpdateAsync(category);
        }
     }
}
