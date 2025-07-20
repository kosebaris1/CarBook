using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.TagCloudCommand
{
    public class CreateTagCloudCommand : IRequest
    {
        public string Title { get; set; }

        public int BlogId { get; set; }
    }
}
