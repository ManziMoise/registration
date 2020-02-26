using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string PlateNo { get; set; }
        public string Model { get; set; }

        public string Type { get; set; }
        public string Color { get; set; }

        public DateTimeOffset DateOfManufacture { get; set; }

        public DateTimeOffset DateOfPurchase { get; set; }

        public string Status { get; set; }
    }
}
