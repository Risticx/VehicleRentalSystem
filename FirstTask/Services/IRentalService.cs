using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public interface IRentalService
    {
        public Rental CreateRental(Vehicle vehicle, string customerName, DateTime startDate, DateTime endDate);

        public void CalculateTotalCost(Rental rental);

        public IVehicleService GetVehicleService(Vehicle vehicle);
    }
}
