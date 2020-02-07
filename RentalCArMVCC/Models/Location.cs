using System.Collections.Generic;

namespace RentalCArMVCC.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}