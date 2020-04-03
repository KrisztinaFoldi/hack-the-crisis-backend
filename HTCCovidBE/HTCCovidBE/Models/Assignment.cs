using System;
namespace HTCCovidBE.Models
{
    public class Assignment
    {
        public long AssignmentId { get; set; }
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string OwnerId { get; set; }
        public string AssigneeId { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
    }
}
