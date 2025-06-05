using Application.Features.CQRS.Command.AboutCommand;
using Application.Features.CQRS.Command.BannerCommand;
using Application.Features.CQRS.Results.AboutResults;
using Application.Features.CQRS.Results.BannerResults;
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

            CreateMap<Banner, GetBannerQueryResult>().ReverseMap();
            CreateMap<Banner, GetBannerByIdQueryResult>().ReverseMap();
            CreateMap<Banner, CreateBannerCommand>().ReverseMap();
            CreateMap<Banner, UpdateBannerCommand>().ReverseMap();
            CreateMap<Banner, RemoveBannerCommand>().ReverseMap();



        }
    }
}
