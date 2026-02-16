using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class BiographyNullOrEmptyException : CourseManagementException
    {
        public BiographyNullOrEmptyException() : base("biography can not be empty!")
        {
        }
    }
}
