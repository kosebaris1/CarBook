using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.TagCloudCommand
{
    public class UpdateTagCloudCommand : IRequest
    {
        public int TagCloudId { get; set; }

        public string Title { get; set; }

        public int BlogId { get; set; }
    }
}
