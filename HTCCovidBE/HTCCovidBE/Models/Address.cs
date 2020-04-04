using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Models
{
    public class Address
    {
        public long AddressId { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public long KennelId { get; set; }
    }
}
