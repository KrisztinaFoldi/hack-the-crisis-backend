using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Donation
    {
        public long DonationId { get; set; }
        public long CategoryId { get; set; }
        public string DonationTitle { get; set; }
    }
}
