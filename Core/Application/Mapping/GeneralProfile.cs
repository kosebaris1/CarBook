using Application.Features.CQRS.Command.AboutCommand;
using Application.Features.CQRS.Command.BannerCommand;
using Application.Features.CQRS.Command.BrandCommand;
using Application.Features.CQRS.Command.CarCommand;
using Application.Features.CQRS.Command.CategoryCommand;
using Application.Features.CQRS.Command.ContactCommand;
using Application.Features.CQRS.Handler.CarHandlers.Read;
using Application.Features.CQRS.Results.AboutResults;
using Application.Features.CQRS.Results.BannerResults;
using Application.Features.CQRS.Results.BrandResults;
using Application.Features.CQRS.Results.CarResults;
using Application.Features.CQRS.Results.CategoryResults;
using Application.Features.CQRS.Results.ContactResults;
using Application.Features.Mediator.Commands.FeatureCommand;
using Application.Features.Mediator.Commands.FooterAdressCommand;
using Application.Features.Mediator.Commands.LocationCommand;
using Application.Features.Mediator.Commands.PricingCommand;
using Application.Features.Mediator.Commands.ServiceCommand;
using Application.Features.Mediator.Results.FeatureResults;
using Application.Features.Mediator.Results.FooterAdressResults;
using Application.Features.Mediator.Results.LocationResults;
using Application.Features.Mediator.Results.PricingResults;
using Application.Features.Mediator.Results.ServiceResults;
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

            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<Brand, RemoveBrandCommand>().ReverseMap();

            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarCommand>().ReverseMap();
            CreateMap<Car, RemoveCarCommand>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
            CreateMap<Car, GetCarQueryResult>().ReverseMap();

           CreateMap<Car, GetCarWithBrandQueryResult>()
          .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name));

            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, RemoveCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();

            CreateMap<Contact, GetContactQueryResult>().ReverseMap();
            CreateMap<Contact, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
            CreateMap<Contact, RemoveContactCommand>().ReverseMap();

            CreateMap<Feature, GetFeatureQueryResult>().ReverseMap();
            CreateMap<Feature, GetFeatureByIdQueryResult>().ReverseMap();
            CreateMap<Feature, RemoveFeatureCommand>().ReverseMap();
            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();
            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();

            CreateMap<FooterAddress, GetFooterAdressQueryResult>().ReverseMap();
            CreateMap<FooterAddress, GetFooterAdressByIdQueryResult>().ReverseMap();
            CreateMap<FooterAddress, CreateFooterAdressCommand>().ReverseMap();
            CreateMap<FooterAddress, UpdateFooterAdressCommand>().ReverseMap();
            CreateMap<FooterAddress, RemoveFooterAdressCommand>().ReverseMap();

            CreateMap<Location, GetLocationQueryResult>().ReverseMap();
            CreateMap<Location, GetLocationByIdQueryResult>().ReverseMap();
            CreateMap<Location, CreateLocationCommand>().ReverseMap();
            CreateMap<Location, RemoveLocationCommand>().ReverseMap();
            CreateMap<Location, UpdateLocationCommand>().ReverseMap();

            CreateMap<Pricing, GetPricingQueryResult>().ReverseMap();
            CreateMap<Pricing, GetPricingByIdQueryResult>().ReverseMap();
            CreateMap<Pricing, UpdatePricingCommand>().ReverseMap();
            CreateMap<Pricing, CreatePricingCommand>().ReverseMap();
            CreateMap<Pricing, RemovePricingCommand>().ReverseMap();

            CreateMap<Service, GetServiceQueryResult>().ReverseMap();
            CreateMap<Service, GetServiceByIdQueryResult>().ReverseMap();
            CreateMap<Service, RemoveServiceCommand>().ReverseMap();
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();





        }
    }
}
