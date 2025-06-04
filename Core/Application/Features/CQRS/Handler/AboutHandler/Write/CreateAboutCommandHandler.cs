using Application.Features.CQRS.Command.AboutCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.AboutHandler.Write
{
    public class CreateAboutCommandHandler 
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;
        public CreateAboutCommandHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            
            var result= _mapper.Map<About>(command);
            await _repository.CreateAsync(result);

            
        }
    }
}
