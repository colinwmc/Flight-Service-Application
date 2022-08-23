namespace FlightServiceBackEnd.Models
{
    public class ReservationList
    {
        public int Id { get; set; }
        
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
  
        public string FlightNumber { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
     

    }
}
