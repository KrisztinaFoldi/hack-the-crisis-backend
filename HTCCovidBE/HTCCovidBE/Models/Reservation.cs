using System;

namespace HTCCovidBE.Models
{
    public class Reservation
    {
        public long ReservationId { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public string UserId { get; set; }
        public long KennelId { get; set; }
    }
}
