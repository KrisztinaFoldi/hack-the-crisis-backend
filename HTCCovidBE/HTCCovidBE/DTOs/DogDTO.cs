using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.DTOs
{
    public class DogDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Sex { get; set; }
        public string Size { get; set; }
        public bool Neutered { get; set; }
        public int Age { get; set; }
        public string Info { get; set; }
    }
}
