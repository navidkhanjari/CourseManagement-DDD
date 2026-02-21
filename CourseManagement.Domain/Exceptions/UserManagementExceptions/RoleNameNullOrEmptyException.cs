using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.UserManagementExceptions
{
    internal class RoleNameNullOrEmptyException : UserManagementException
    {
        public RoleNameNullOrEmptyException() : base("RoleName can not be null or empty!")
        {
        }
    }

    
}
