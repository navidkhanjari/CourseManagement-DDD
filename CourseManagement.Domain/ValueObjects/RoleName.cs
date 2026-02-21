using CourseManagement.Domain.Exceptions.UserManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record RoleName
    {
        public string Value { get; }

        public RoleName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new RoleNameNullOrEmptyException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(RoleName roleName) => roleName.Value;

        // For Create New Instance
        public static implicit operator RoleName(string roleName) => new(roleName);
    }
}
