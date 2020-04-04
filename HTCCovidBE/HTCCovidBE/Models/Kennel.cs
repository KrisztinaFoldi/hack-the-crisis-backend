using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Kennel
    {
        public long KennelId { get; set; }
        public Address Address { get; set; }
        public string Description { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public List<Information> Informations { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
