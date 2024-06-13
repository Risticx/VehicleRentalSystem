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
        public decimal CalculateBaseInsuranceCost(Vehicle vehicle, int days)
        {
            return days * vehicle.Value * 0.03m / 100;
        }

        public decimal CalculateAdditionalInsuranceCost(Vehicle vehicle, int days)
        {
            CargoVan cargoVan = (CargoVan)vehicle;
            decimal Cost = CalculateBaseInsuranceCost(vehicle, days);

            return cargoVan.DriverExperience <= 5 ? Cost : Cost * 0.85m;
        }

        public decimal CalculateRentalCost(Vehicle vehicle, int days)
        {
            return days > 7 ? days * 40 : days * 50;
        }
    }
}
