using System;
namespace HTCCovidBE.DTOs
{
    public class NewAssignmentDTO
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
        public string UserId { get; set; }

    }
}
