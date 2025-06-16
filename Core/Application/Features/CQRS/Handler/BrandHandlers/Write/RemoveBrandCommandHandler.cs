using Application.Features.CQRS.Command.BrandCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handler.BrandHandlers.Write
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;


        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandCommand commad)
        {
            var values = await _repository.GetByIdAsync(commad.Id);
            await _repository.RemoveAsync(values);
        }
    }
}
