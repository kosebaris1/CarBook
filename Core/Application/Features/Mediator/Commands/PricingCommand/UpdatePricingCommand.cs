using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.PricingCommand
{
    public class UpdatePricingCommand : IRequest
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
    }
}
