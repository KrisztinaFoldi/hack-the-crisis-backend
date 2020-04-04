using System;
namespace HTCCovidBE.Models
{
    public class Assignment
    {
        public long AssignmentId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public User AssigneedUser { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
    }
}
