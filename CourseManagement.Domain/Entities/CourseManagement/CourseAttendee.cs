using CourseManagement.Domain.Entities.UserManagment;

namespace CourseManagement.Domain.Entities.CourseManagement;

public class CourseAttendee
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid CourseId { get; set; }
    public Course Course { get; set; }
}
