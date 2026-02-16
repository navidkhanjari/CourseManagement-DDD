using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoUrlLengthException : CourseManagementException
    {
        public InvalidVideoUrlLengthException() : base("VideoUrl can not be more than 50 characters!")
        {
        }
    }
}
