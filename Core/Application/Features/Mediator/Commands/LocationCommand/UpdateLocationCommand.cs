using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.LocationCommand
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
