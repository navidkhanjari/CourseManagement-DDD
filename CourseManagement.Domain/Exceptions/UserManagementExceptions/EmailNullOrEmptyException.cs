using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class EmailNullOrEmptyException : UserManagementException
    {
        public EmailNullOrEmptyException() : base("Email can not be null or empty!")
        {
        }
    }
}
