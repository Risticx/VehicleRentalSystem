using VehicleRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Services
{
    public class CargoVanService : IVehicleService
    {
        public decimal CalculateInsuranceCost(Vehicle vehicle, int days)
        {
            CargoVan cargoVan = (CargoVan)vehicle;
            decimal Cost = days * cargoVan.Value * 0.03m;

            return cargoVan.DriverExperience <= 5 ? Cost : Cost * 0.85m;
        }

        public decimal CalculateRentalCost(Vehicle vehicle, int days)
        {
            return days > 7 ? days * 40 : days * 50;
        }
    }
}
