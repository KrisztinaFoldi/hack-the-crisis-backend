using System;
namespace HTCCovidBE.DTOs
{
    public class NewAssignmentDTO
    {
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
    }
}
