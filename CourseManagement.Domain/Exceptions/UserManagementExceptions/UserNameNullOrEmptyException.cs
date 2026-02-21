using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class UserNameNullOrEmptyException : UserManagementException
    {
        public UserNameNullOrEmptyException() : base("UserName can not be null or empty!")
        {
        }
    }

    
}
