namespace AirlineReservationSystem.Data.Entities
{
    public class Airplane
    {
        public int Id { get; set; }
        public string AirplaneNumber { get; set; }
        public string Model { get; set; }
        public int TotalSeats { get; set; }
        public int EconomySeats { get; set; }
        public int BusinessSeats { get; set; }
    }

}
