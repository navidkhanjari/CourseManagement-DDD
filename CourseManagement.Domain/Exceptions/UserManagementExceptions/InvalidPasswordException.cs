using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidPasswordException : UserManagementException
    {
        public InvalidPasswordException() : base("Password value is not valid!")
        {
        }
    }
    
}
