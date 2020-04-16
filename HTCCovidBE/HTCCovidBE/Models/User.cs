using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HTCCovidBE.Models
{
    public class User : IdentityUser
    {
       public List<Dog> Dogs { get; set; }
       public List<Reservation> Reservations { get; set; }
       public ICollection<Favourite> Favourites { get; set; }
    }
}
