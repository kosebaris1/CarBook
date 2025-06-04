using Application.Features.CQRS.Command.AboutCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Application.Features.CQRS.Handler.AboutHandler.Write
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public UpdateAboutCommandHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            
            var values =await _repository.GetByIdAsync(command.AboutId);
            _mapper.Map(command, values);
          

            await _repository.UpdateAsync(values);
        }
    }
}
