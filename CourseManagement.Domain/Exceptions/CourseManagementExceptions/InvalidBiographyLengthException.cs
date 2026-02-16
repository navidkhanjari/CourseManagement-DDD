using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidBiographyLengthException : CourseManagementException
    {
        public InvalidBiographyLengthException() : base("Biography can not be more than 300 characters!")
        {
        }
    }
}
