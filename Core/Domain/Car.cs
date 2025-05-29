using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; } // koltuk sayısı
        public byte Luggage { get; set; } // Bağaj
        public string Fuel { get; set; } // Bağaj
        public string BigImageUrl{ get; set; } // Bağaj
        public List<CarFeature> CarFeatures{ get; set; }
        public List<CarDescription> CarDescriptions{ get; set; }
        public List<CarPricing> CarPricings{ get; set; }
    }
}
