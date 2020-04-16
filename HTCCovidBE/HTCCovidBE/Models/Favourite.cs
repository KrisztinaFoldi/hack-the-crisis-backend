using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Favourite
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public long KennelId { get; set; }
        public Kennel Kennel { get; set; }
    }
}
