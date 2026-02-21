using CourseManagement.Domain.Exceptions.UserManagementExceptions;
using System.Text.RegularExpressions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Password
    {
        public string Value { get; }

        public Password(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new PasswordNullOrEmptyException();
            }

            string pattern = "[^a-zA-Z0-9^]";

            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new InvalidPasswordException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(Password password) => password.Value;

        // For Create New Instance
        public static implicit operator Password(string password) => new(password);
    }
}
