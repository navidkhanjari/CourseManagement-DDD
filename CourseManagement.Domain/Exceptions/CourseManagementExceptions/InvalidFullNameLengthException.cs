using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidFullNameLengthException : CourseManagementException
    {
        public InvalidFullNameLengthException(int validLenght) : base($"FullName can not be more than {validLenght} characters!")
        {
        }
    }
}
