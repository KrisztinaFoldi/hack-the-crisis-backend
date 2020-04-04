using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HTCCovidBE.Models
{
    public class User : IdentityUser
    {
        public string Address { get; set; }
    }
}
