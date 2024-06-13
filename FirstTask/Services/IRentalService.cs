using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public interface IRentalService
    {
        public Rental CreateRental(Vehicle vehicle, string customerName, DateTime startDate, DateTime endDate, DateTime? returnDate);

        public void CalculateTotalCost(Rental rental);

        public IVehicleService GetVehicleService(Vehicle vehicle);
    }
}
