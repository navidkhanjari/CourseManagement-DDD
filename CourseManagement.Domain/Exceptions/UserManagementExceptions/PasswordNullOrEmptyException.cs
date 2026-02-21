using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class PasswordNullOrEmptyException : UserManagementException
    {
        public PasswordNullOrEmptyException() : base("Password can not be null or empty!")
        {
        }
    }
    
}
