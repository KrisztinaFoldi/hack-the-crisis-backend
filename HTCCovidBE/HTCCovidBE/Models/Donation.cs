using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Donation
    {
        public long DonationId { get; set; }
        public string Category { get; set; }
        public string DonationTitle { get; set; }
        public string UserId { get; set; }
    }
}
