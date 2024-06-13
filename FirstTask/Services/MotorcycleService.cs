using VehicleRentalSystem.Models;
using VehicleRentalSystem.Exceptions;

namespace VehicleRentalSystem.Services
{
    public class MotorcycleService : IVehicleService
    {
        public decimal CalculateBaseInsuranceCost(Vehicle vehicle, int days)
        {

            Motorcycle motorcycle = (Motorcycle)vehicle;

            if (motorcycle.RiderAge < 0 || motorcycle.RiderAge > 100)
                throw new SafetyRatingException("Rider age value not acceptable!");

            return days * vehicle.Value * 0.02m / 100;
        }

        public decimal CalculateAdditionalInsuranceCost(Vehicle vehicle, int days)
        {
            Motorcycle motorcycle = (Motorcycle)vehicle;
            decimal Cost = CalculateBaseInsuranceCost(vehicle, days);

            return motorcycle.RiderAge >= 25 ? Cost : Cost * 1.2m;
        }

        public decimal CalculateRentalCost(Vehicle vehicle, int days)
        {
            return days > 7 ? days * 10 : days * 15;
        }
    }
}
