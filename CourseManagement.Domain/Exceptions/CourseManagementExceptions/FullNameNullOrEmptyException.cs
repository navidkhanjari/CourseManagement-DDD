using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class FullNameNullOrEmptyException : CourseManagementException
    {
        public FullNameNullOrEmptyException() : base("FullName can not be null or empty!")
        {
        }
    }
}
