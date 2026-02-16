using CourseManagement.Domain.Entities.CourseManagement;
using CourseManagement.Domain.Entities.UserManagment;

namespace CourseManagement.Domain.Entities.PaymentManagment
{
    public class Invoice
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateTime { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
