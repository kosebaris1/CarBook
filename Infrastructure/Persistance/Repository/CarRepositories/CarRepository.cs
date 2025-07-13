using Application.Interfaces.CarInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async  Task<List<Car>> GetCarsListWithBrands()
        {
            return  await _context.Cars
                .Include(c => c.Brand)
                .ToListAsync();

        }


        public async Task<List<Car>> GetLast5CarsWithBrands()
        {
            var values = await _context.Cars
                .Include(c => c.Brand)
                .OrderByDescending(c => c.CarId)
                .Take(5)
                .ToListAsync();

            return values;
        }
    }
}
