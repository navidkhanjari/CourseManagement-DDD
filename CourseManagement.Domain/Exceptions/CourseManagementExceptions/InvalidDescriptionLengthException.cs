using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidDescriptionLengthException : CourseManagementException
    {
        public InvalidDescriptionLengthException() : base("Description can not be more than 700 characters!")
        {
        }
    }
}
