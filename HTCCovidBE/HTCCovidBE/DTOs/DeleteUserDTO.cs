using System;
using System.ComponentModel.DataAnnotations;

namespace HTCCovidBE.DTOs
{
    public class DeleteUserDTO
    {
        [Required]
        public string UserId { get; set; }
    }
}
