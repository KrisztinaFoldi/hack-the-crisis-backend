using System;

namespace HTCCovidBE.Models
{
    public class Information
    {
        public long InformationId { get; set; }
        public long KennelId { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
    }
}
