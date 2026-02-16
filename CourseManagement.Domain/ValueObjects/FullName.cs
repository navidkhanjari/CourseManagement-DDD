using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record FullName
    {

        public string Value { get; }

        public FullName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FullNameNullOrEmptyException();
            }

            if (value.Length > 30)
            {
                throw new InvalidFullNameLengthException(30);
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(FullName fullName) => fullName.Value;

        // For Create New Instance
        public static implicit operator FullName(string fullName) => new(fullName);
    }
}
