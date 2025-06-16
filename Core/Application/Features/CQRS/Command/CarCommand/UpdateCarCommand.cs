using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Command.CarCommand
{
    public class UpdateCarCommand
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; } // koltuk sayısı
        public byte Luggage { get; set; } // Bağaj
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
    }
}
