﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.FeatureResults
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
