namespace VehicleRentalSystem.Models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public decimal Value { get; set; }
    }
}
