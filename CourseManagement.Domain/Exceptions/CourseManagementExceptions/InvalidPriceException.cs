using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidPriceException : CourseManagementException
    {
        public InvalidPriceException() : base("Price value is not valid!")
        {
        }
    }
}
