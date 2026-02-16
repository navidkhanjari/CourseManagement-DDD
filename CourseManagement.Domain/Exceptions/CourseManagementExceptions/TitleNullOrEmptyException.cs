using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("Title can not be null or empty!")
        {
        }
    }
}
