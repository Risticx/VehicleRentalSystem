using VehicleRentalSystem.Models;
using VehicleRentalSystem.Exceptions;

namespace VehicleRentalSystem.Services
{
    public class CargoVanService : IVehicleService
    {
        public decimal CalculateBaseInsuranceCost(Vehicle vehicle, int days)
        {

            CargoVan cargoVan = (CargoVan)vehicle;

            if (cargoVan.DriverExperience < 0)
                throw new SafetyRatingException("Driver experience must be positive value!");

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
