﻿using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.FeatureCommand
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
