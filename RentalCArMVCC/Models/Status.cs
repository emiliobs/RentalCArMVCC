using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCArMVCC.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}
