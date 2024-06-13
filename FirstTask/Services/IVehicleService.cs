using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public interface IVehicleService
    {
        public decimal CalculateRentalCost(Vehicle vehicle, int days);

        public decimal CalculateInsuranceCost(Vehicle vehicle, int days);
    }
}
