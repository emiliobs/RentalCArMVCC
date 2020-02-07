using System;

namespace RentalCArMVCC.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}