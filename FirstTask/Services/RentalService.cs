﻿using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public class RentalService : IRentalService
    {
        private readonly IVehicleService _carService;
        private readonly IVehicleService _motorcycleService;
        private readonly IVehicleService _cargoVanService;

        public RentalService()
        {
            _carService = new CarService();
            _motorcycleService = new MotorcycleService();
            _cargoVanService = new CargoVanService();
        }
        public Rental CreateRental(Vehicle vehicle, string customerName, DateTime startDate, DateTime endDate, DateTime? returnDate)
        {
            if (startDate >= endDate)
            {
                throw new ArgumentException("Start date must be before end date!");
            }

            if (returnDate.HasValue && (returnDate.Value < startDate || returnDate.Value > endDate))
            {
                throw new ArgumentException("Return date must be between start and end dates!");
            }

            return new Rental { Vehicle = vehicle, CustomerName = customerName, StartDate = startDate, EndDate = endDate , ReturnDate = returnDate};
        }
        public void CalculateTotalCost(Rental rental)
        {
            IVehicleService vehicleService = GetVehicleService(rental.Vehicle);

            int rentalDays = rental.GetRentalDays();

            decimal rentalCost = vehicleService.CalculateRentalCost(rental.Vehicle, rentalDays);
            decimal baseInsuranceCost = vehicleService.CalculateBaseInsuranceCost(rental.Vehicle, rentalDays);
            decimal additionalInsuranceCost = vehicleService.CalculateAdditionalInsuranceCost(rental.Vehicle, rentalDays);

            Invoice invoice = new Invoice { Rental = rental, RentalCost = rentalCost, BaseInsuranceCost = baseInsuranceCost, AdditionalInsuranceCost = additionalInsuranceCost };
            invoice.PrintInvoice();
        }

        public IVehicleService GetVehicleService(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                return _carService;
            }
            else if (vehicle is Motorcycle)
            {
                return _motorcycleService;
            }
            else if (vehicle is CargoVan)
            {
                return _cargoVanService;
            }
            else
            {
                throw new ArgumentException("Unknown vehicle type");
            }
        }
    }
}
