
using Application.Features.CQRS.Handler.AboutHandler.Read;
using Application.Features.CQRS.Handler.AboutHandler.Write;
using Application.Features.CQRS.Handler.BannerHandlers.Read;
using Application.Features.CQRS.Handler.BannerHandlers.Write;
using Application.Features.CQRS.Handler.BrandHandlers.Read;
using Application.Features.CQRS.Handler.BrandHandlers.Write;
using Application.Features.CQRS.Handler.CarHandlers.Read;
using Application.Features.CQRS.Handler.CarHandlers.Write;
using Application.Features.CQRS.Handler.CategoryHandler.Read;
using Application.Features.CQRS.Handler.CategoryHandler.Write;
using Application.Features.CQRS.Handler.ContactHandlers.Read;
using Application.Features.CQRS.Handler.ContactHandlers.Write;
using Application.Features.CQRS.Queries;
using Application.Interfaces;
using Application.Interfaces.BlogInterfaces;
using Application.Interfaces.CarInterfaces;
using Application.Interfaces.CarPricingInterface;
using Application.Mapping;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using Persistance.Repository;
using Persistance.Repository.BlogRepositories;
using Persistance.Repository.CarPricingRepository;
using Persistance.Repository.CarRepositories;

namespace CarWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAutoMapper(typeof(GeneralProfile).Assembly);
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<ICarRepository, CarRepository>();
            builder.Services.AddScoped<IBlogRepository, BlogRepository>();
            builder.Services.AddScoped<ICarPricingRepository, CarPricingRepository>();

            builder.Services.AddScoped<GetAboutByIdQueryHandler>();
            builder.Services.AddScoped<GetAboutQueryHandler>();
            builder.Services.AddScoped<CreateAboutCommandHandler>();
            builder.Services.AddScoped<UpdateAboutCommandHandler>();
            builder.Services.AddScoped<RemoveAboutCommandHandler>();

            builder.Services.AddScoped<GetBannerByIdQueryHandler>();
            builder.Services.AddScoped<GetBannerQueryHandler>();
            builder.Services.AddScoped<CreateBannerCommandHandler>();
            builder.Services.AddScoped<UpdateBannerCommandHandler>();
            builder.Services.AddScoped<RemoveBannerCommandHandler>();

            builder.Services.AddScoped<GetBrandQueryHandler>();
            builder.Services.AddScoped<GetBrandByIdQueryHandler>();
            builder.Services.AddScoped<CreateBrandCommandHandler>();
            builder.Services.AddScoped<UpdateBrandCommandHandler>();
            builder.Services.AddScoped<RemoveBrandCommandHandler>();


            builder.Services.AddScoped<RemoveCarCommandHandler>();
            builder.Services.AddScoped<CreateCarCommandHandler>();
            builder.Services.AddScoped<UpdateCarCommandHandler>();
            builder.Services.AddScoped<GetCarByIdQueryHandler>();
            builder.Services.AddScoped<GetCarQueryHandler>();

            builder.Services.AddScoped<GetCarWithBrandQueryHandler>();


            builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
            builder.Services.AddScoped<GetCategoryQueryHandler>();
            builder.Services.AddScoped<CreateCategoryCommandHandler>();
            builder.Services.AddScoped<UpdateCategoryCommandHandler>();
            builder.Services.AddScoped<RemoveCategoryCommandHandler>();

            builder.Services.AddScoped<GetContactQueryHandler>();
            builder.Services.AddScoped<GetContactByIdQueryHandler>();
            builder.Services.AddScoped<CreateContactCommandHandler>();
            builder.Services.AddScoped<UpdateContactCommandHandler>();
            builder.Services.AddScoped<RemoveContactCommandHandler>();
            builder.Services.AddScoped<RemoveContactCommandHandler>();

            builder.Services.AddApplicationService(builder.Configuration);





            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddDbContext<CarBookContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
