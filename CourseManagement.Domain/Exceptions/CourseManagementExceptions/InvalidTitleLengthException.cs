using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidTitleLengthException : CourseManagementException
    {
        public InvalidTitleLengthException(int validLenght) : base($"Title can not be more than {validLenght} characters!")
        {
        }
    }
}
