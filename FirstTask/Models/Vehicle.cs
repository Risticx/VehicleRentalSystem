﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Text;
    using System.Threading.Tasks;

    namespace VehicleRentalSystem.Models
    {
        public abstract class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public decimal Value { get; set; }
        }
}
