using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Information
    {
        public long InformationId { get; set; }
        public string UserId { get; set; }
        public long KennelId { get; set; }
        public string Info { get; set; }
    }
}
