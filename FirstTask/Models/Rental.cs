namespace VehicleRentalSystem.Models
{
    public class Rental
    {

        public Vehicle Vehicle { get; set; }

        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public int GetRentalDays()
        {
            return (int)(EndDate - StartDate).TotalDays;
        }

        public int GetActualRentalDays()
        {
            var returnDate = ReturnDate ?? EndDate;
            return (int)(returnDate - StartDate).TotalDays;
        }

        public int GetDaysLeft()
        {
            var returnDate = ReturnDate ?? EndDate;
            return (int)(EndDate - returnDate).TotalDays + 1;
        }
    }
}
