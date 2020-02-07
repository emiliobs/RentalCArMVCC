using System.Collections.Generic;

namespace RentalCArMVCC.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Code{ get; set; }
        public string Description { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}