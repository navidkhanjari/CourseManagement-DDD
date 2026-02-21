using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidEmailException : UserManagementException
    {
        public InvalidEmailException() : base("Price value is not valid!")
        {
        }
    }
    
}
