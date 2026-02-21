using CourseManagement.Domain.Exceptions.UserManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record UserName
    {
        public string Value { get; }

        public UserName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new UserNameNullOrEmptyException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(UserName userName) => userName.Value;

        // For Create New Instance
        public static implicit operator UserName(string userName) => new(userName);
    }
}
