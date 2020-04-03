using System;
using Microsoft.AspNetCore.Identity;

namespace HTCCovidBE.Models
{
    public class User : IdentityUser
    {
        string Address { get; set; }
    }
}
