using VehicleRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Services
{
    public class MotorcycleService : IVehicleService
    {
        public decimal CalculateBaseInsuranceCost(Vehicle vehicle, int days)
        {
            return days * vehicle.Value * 0.02m / 100;
        }

        public decimal CalculateAdditionalInsuranceCost(Vehicle vehicle, int days)
        {
            Motorcycle motorcycle = (Motorcycle)vehicle;
            decimal Cost = CalculateBaseInsuranceCost(vehicle, days);

            return motorcycle.RiderAge >= 25 ? -1 : Cost * 1.2m;
        }

        public decimal CalculateRentalCost(Vehicle vehicle, int days)
        {
            return days > 7 ? days * 10 : days * 15;
        }
    }
}
