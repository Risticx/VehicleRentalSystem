// See https://aka.ms/new-console-template for more information
using VehicleRentalSystem.Models;
using VehicleRentalSystem.Services;



Vehicle vehicle = new CargoVan { Brand = "Citroen", Model = "Jumper", Value = 20000, DriverExperience = 8 };

IRentalService rentalService = new RentalService();

Rental rental = rentalService.CreateRental(vehicle, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(5));
rental.ReturnDate = DateTime.Now;
rentalService.CalculateTotalCost(rental);
