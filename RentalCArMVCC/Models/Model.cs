using System.Collections.Generic;

namespace RentalCArMVCC.Models
{
    public class Model
    {
        public int Id { get; set; }
        public decimal DailyHireRate { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public IEnumerable <Vehicle> Vehicles { get; set; }
    }
}