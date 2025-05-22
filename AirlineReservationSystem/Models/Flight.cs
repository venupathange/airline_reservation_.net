namespace AirlineReservationSystem.Models
// Namespace: AirlineReservationSystem.Data.Entities

{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightName { get; set; }
        public int AirplaneId { get; set; }
        public int SourceAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; }
    }
}
