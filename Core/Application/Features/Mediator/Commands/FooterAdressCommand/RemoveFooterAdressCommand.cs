using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.FooterAdressCommand
{
    public class RemoveFooterAdressCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterAdressCommand(int id)
        {
            Id = id;
        }
    }
}
