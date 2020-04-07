using System;
using System.Collections.Generic;
using HTCCovidBE.Models;

namespace HTCCovidBE.DTOs
{
    public class KennelDTO
    {
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Description { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public List<Information> Informations { get; set; }
    }
}
