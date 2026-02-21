using CourseManagement.Domain.Exceptions.UserManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EmailNullOrEmptyException();
            }

            var emailAddress = new System.Net.Mail.MailAddress(value);

            if (emailAddress.Address != value)
            {
                throw new InvalidEmailException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(Email email) => email.Value;

        // For Create New Instance
        public static implicit operator Email(string email) => new(email);
    }
}
