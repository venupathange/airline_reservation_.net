namespace AirlineReservationSystem.Models
{
    public class Airport
    {
        public int Id { get; set; } // PK, auto-generated
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
