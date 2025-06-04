using Application.Features.CQRS.Command.AboutCommand;
using Application.Features.CQRS.Results.AboutResults;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<About, GetAboutByIdQueryResult>().ReverseMap();
            CreateMap<About, GetAboutQueryResult>().ReverseMap();
            CreateMap<About, CreateAboutCommand>().ReverseMap();
            CreateMap<About, UpdateAboutCommand>().ReverseMap();
            CreateMap<About, RemoveAboutCommand>().ReverseMap();
        }
    }
}
