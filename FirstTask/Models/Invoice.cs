using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Invoice
    {
        public Rental Rental { get; set; }
        public decimal RentalCost { get; set; }
        public decimal BaseInsuranceCost { get; set; }

        public decimal AdditionalInsuranceCost { get; set; }

        public void PrintInvoice()
        {
            decimal rentalCostPerDay = Math.Round(RentalCost / Rental.GetRentalDays(), 2);
            decimal baseInsuranceCostPerDay = Math.Round(BaseInsuranceCost / Rental.GetRentalDays(), 2);
            decimal additionInsuranceCostPerDay = Math.Round(AdditionalInsuranceCost / Rental.GetRentalDays(), 2);
            decimal resultInsuranceCostPerDay = 0;
            decimal earlyRentDiscount = 0;
            decimal earlyInsuranceDiscount = 0;

            if (Rental.Vehicle is Car car)
                Console.WriteLine($"A car that is valued at ${Math.Round(Rental.Vehicle.Value, 2)}," +
                $" and has a security rating of {car.SafetyRating}:");

            if (Rental.Vehicle is Motorcycle motorcycle)
                Console.WriteLine($"A motorcycle valued at ${Math.Round(Rental.Vehicle.Value, 2)}," +
                $" and the driver is {motorcycle.RiderAge} years old");

            if (Rental.Vehicle is CargoVan cargoVan)
                Console.WriteLine($"A cargo van valued at ${Math.Round(Rental.Vehicle.Value, 2)}," +
                $" and the driver has {cargoVan.DriverExperience} years of driving experience");

            Console.WriteLine();
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Customer Name:");
            Console.WriteLine($"Rented Vehicle: {Rental.Vehicle.Brand + " " + Rental.Vehicle.Model}");
            Console.WriteLine();

            Console.WriteLine($"Reservation start date: {Rental.StartDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Reservation end date: {Rental.EndDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Reserved rental days: {Rental.GetRentalDays()} days");
            Console.WriteLine();

            if (Rental.ReturnDate == null)
            {
                Console.WriteLine($"Actual return date: {Rental.EndDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Actual rental days: {Rental.GetRentalDays()} days");
            }
            else
            {
                Console.WriteLine($"Actual return date: {Rental.ReturnDate?.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Actual rental days: {Rental.GetActualRentalDays()} days");
            }
            Console.WriteLine();

            Console.WriteLine($"Rental cost per day: ${rentalCostPerDay}");
            if(AdditionalInsuranceCost == -1) 
                Console.WriteLine($"Insurance per day: ${resultInsuranceCostPerDay = baseInsuranceCostPerDay}");
            if (AdditionalInsuranceCost != -1)
            {
                Console.WriteLine($"Initial insurance per day: ${baseInsuranceCostPerDay}");

                decimal insuranceDifference = baseInsuranceCostPerDay - additionInsuranceCostPerDay;
                if (insuranceDifference > 0)
                {
                    Console.WriteLine($"Insurance discound per day: ${insuranceDifference}");
                    Console.WriteLine($"Insurance per day: ${resultInsuranceCostPerDay = additionInsuranceCostPerDay}");
                }
                if (insuranceDifference < 0)
                {
                    Console.WriteLine($"Insurance addition per day: ${Math.Abs(insuranceDifference)}");
                    Console.WriteLine($"Insurance per day: ${resultInsuranceCostPerDay = additionInsuranceCostPerDay}");
                }

            }
            Console.WriteLine();


            if (Rental.ReturnDate != null) 
            {
                earlyRentDiscount = rentalCostPerDay * Rental.GetDaysLeft() * 0.5m;
                Console.WriteLine($"Early return discount for rent: ${Math.Round(earlyRentDiscount, 2)}");
                earlyInsuranceDiscount = resultInsuranceCostPerDay * Rental.GetDaysLeft();
                Console.WriteLine($"Early return discount for insurance: ${Math.Round(earlyInsuranceDiscount, 2)}");

            }
            Console.WriteLine();

            Console.WriteLine($"Total rent: ${Math.Round(RentalCost - earlyRentDiscount, 2)}");
            Console.WriteLine($"Total insurance: ${Math.Round(AdditionalInsuranceCost - earlyInsuranceDiscount, 2)}");
            Console.WriteLine($"Total: ${Math.Round(RentalCost - earlyRentDiscount + AdditionalInsuranceCost - earlyInsuranceDiscount,2)}");
            Console.WriteLine("XXXXXXXXXX");
        }
    }
}
