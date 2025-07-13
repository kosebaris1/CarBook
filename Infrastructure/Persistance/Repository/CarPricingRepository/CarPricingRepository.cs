using Application.Interfaces.CarPricingInterface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository.CarPricingRepository
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<CarPricing>> GetCarPricingWithCars()
        {
            var values = await _context.CarPricings
                .Include(cp => cp.Car)
                .ThenInclude(c => c.Brand)
                .Include(cp => cp.Pricing)
                .Where(z=> z.PricingId==3)
                .ToListAsync();
            return values;
        }
    }
}
