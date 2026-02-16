using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class DescriptionNullOrEmptyException : CourseManagementException
    {
        public DescriptionNullOrEmptyException() : base("Description can not be null or empty!")
        {
        }
    }
}
