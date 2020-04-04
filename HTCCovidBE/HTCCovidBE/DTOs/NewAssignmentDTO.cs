using System;
using System.ComponentModel.DataAnnotations;

namespace HTCCovidBE.DTOs
{
    public class NewAssignmentDTO
    {
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
        public string UserId { get; set; }

    }
}
