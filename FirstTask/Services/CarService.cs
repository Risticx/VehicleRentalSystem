using VehicleRentalSystem.Exceptions;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public class CarService : IVehicleService
    {
        public decimal CalculateBaseInsuranceCost(Vehicle vehicle, int days)
        {
            Car car = (Car)vehicle;

            if (car.SafetyRating < 0 || car.SafetyRating > 5)
                throw new SafetyRatingException("Safety Rating must be in range 1-5!");

            return days * vehicle.Value * 0.01m / 100;
        }
        public decimal CalculateAdditionalInsuranceCost(Vehicle vehicle, int days)
        {
            Car car = (Car)vehicle;
           
            decimal Cost = CalculateBaseInsuranceCost(vehicle, days);
            return car.SafetyRating < 4 ? Cost : Cost * 0.9m;
        }

        public decimal CalculateRentalCost(Vehicle vehicle, int days)
        {
            return days > 7 ? days * 15 : days * 20;
        }
    }
}
