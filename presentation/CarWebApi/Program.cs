
using Application.Features.CQRS.Handler.AboutHandler.Read;
using Application.Features.CQRS.Handler.AboutHandler.Write;
using Application.Features.CQRS.Queries;
using Application.Interfaces;
using Application.Mapping;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using Persistance.Repository;

namespace CarWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAutoMapper(typeof(GeneralProfile).Assembly);
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            builder.Services.AddScoped<GetAboutByIdQueryHandler>();
            builder.Services.AddScoped<GetAboutQueryHandler>();
            builder.Services.AddScoped<CreateAboutCommandHandler>();
            builder.Services.AddScoped<UpdateAboutCommandHandler>();
            builder.Services.AddScoped<RemoveAboutCommandHandler>();


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
