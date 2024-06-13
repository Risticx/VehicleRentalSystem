using VehicleRentalSystem.Models;
using VehicleRentalSystem.Services;


IRentalService rentalService = new RentalService();


Vehicle vehicle = new Car { Brand = "Mitsubishi", Model = "Mirage", Value = 15000, SafetyRating = 3 };
Rental rental = rentalService.CreateRental(vehicle, "John Doe", DateTime.Now.AddDays(-10), DateTime.Now, null);
//rental.ReturnDate = DateTime.Now;
rentalService.CalculateTotalCost(rental);

Console.WriteLine("\nPress Enter for next test case.\n");
Console.ReadLine();



vehicle = new Motorcycle { Brand = "Triumph", Model = "Tiger Sport 660", Value = 10000, RiderAge = 20 };
rental = rentalService.CreateRental(vehicle, "Mary Johnson", DateTime.Now.AddDays(-10), DateTime.Now, null);
//rental.ReturnDate = DateTime.Now;
rentalService.CalculateTotalCost(rental);

Console.WriteLine("\nPress Enter for next test case.\n");
Console.ReadLine();



vehicle = new CargoVan { Brand = "Citroen", Model = "Jumper", Value = 20000, DriverExperience = 8 };

rental = rentalService.CreateRental(vehicle, "John Markson", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(5), DateTime.Now);
rentalService.CalculateTotalCost(rental);